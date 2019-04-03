import { Component, OnInit } from '@angular/core';
import { FetchDataComponent } from '../fetch-data/fetch-data.component';
import { Question } from '../models/question.model';
import { Application } from '../models/application.model';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit {

  public applications: Application[];

  constructor(private fetchService: FetchDataComponent) { }

  ngOnInit() {
    this.fetchService.getApplications().subscribe(response => {
      this.applications = [new Application('John', [new Question('test 1', 'answer 1'), new Question('Test 2', 'Answer 2')])];
    });
  }
}
