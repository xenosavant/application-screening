using ApplicationScreening.Domain.Common;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
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

        private readonly List<Response> _responses;
        public IReadOnlyCollection<Response> Responses => _responses;

        public ApplicationQuestion(string question)
        {
            _responses = new List<Response>();
            Question = question;
        }

        public void SetAnswer(string answer)
        {
            Answer = new Answer(answer);
        }
    }
}
