import { Component, Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Question } from '../models/question.model';
import { Application } from '../models/application.model';

@Injectable({ providedIn: 'root' })
export class FetchDataComponent {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  public getQuestions(): Observable<Question[]> {
    return this.http.get<Question[]>(this.baseUrl + 'api/question');
  }

  public getApplications(): Observable<Application[]> {
    return this.http.get<Application[]>(this.baseUrl + 'api/application');
  }

  public postQuestion(question: Question): Observable<Question> {
    return this.http.post<Question>((this.baseUrl + 'api/question'), question);
  }
}
