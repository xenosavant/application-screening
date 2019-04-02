using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.JobApplicationAggregate
{
    public class Response
    {
        private readonly string _questionId;

        public ApplicationQuestion Question { get; private set; }
        public Answer Answer { get; private set; }

        public Response(string questionId, Answer answer)
        {
            _questionId = questionId;
            Answer = answer;
        }
    }
}
