using ApplicationScreening.Domain.Common;
using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate
{
    public class ApplicationQuestion : Entity<Guid>
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
