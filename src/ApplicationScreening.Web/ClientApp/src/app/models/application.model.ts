import { Question } from './question.model';

export class Application {

  constructor(name: string, responses: Question[]) {
    this.name = name;
    this.responses = responses;
  }

  public name: string;
  public responses: Question[];
}
