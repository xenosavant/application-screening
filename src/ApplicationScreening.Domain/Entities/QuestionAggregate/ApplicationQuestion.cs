using ApplicationScreening.Domain.Common;
using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.QuestionAggregate
{
    public class ApplicationQuestion : Entity<string>
    {
        public string Question { get; private set; }
        public Answer Answer { get; private set; }

        public ApplicationQuestion(string question, Answer answer )
        {
            Question = question;
            Answer = answer;
        }
    }
}
