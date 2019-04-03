
export class Question {

  constructor(question: string, answer: string) {
    this.id = null;
    this.question = question;
    this.answer = answer;
  }

  public id: string;
  public question: string;
  public answer: string;
}
