import { Component, OnInit } from '@angular/core';
import { FetchDataComponent } from '../fetch-data/fetch-data.component';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Question } from '../models/question.model';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {

  public form: FormGroup;
  public questions: Question[];
  private isPosting: boolean;

  constructor(private apiService: FetchDataComponent, private formBuilder: FormBuilder) { }

  public ngOnInit() {
    this.form = this.formBuilder.group({
      question: ['', Validators.required],
      answer: ['', Validators.required]
    });
    this.apiService.getQuestions().subscribe(response => {
      this.questions = response;
    });
  }

  public onSubmit() {
    if (this.form.valid) {
      this.isPosting = true;
      this.apiService.postQuestion(new Question(this.form.value.question, this.form.value.answer))
        .subscribe((question: Question) => {
          this.questions.push(question);
          this.isPosting = false;
        });
    }
  }

}
