using ApplicationScreening.Domain.Common;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.JobApplicationAggregate
{
    public class Response : Entity<Guid>
    {
        public Guid QuestionId { get; private set; }

        public ApplicationQuestion Question { get; private set; }
        public Answer Answer { get; private set; }

        public Response(Guid questionId)
        {
            QuestionId = questionId;
        }

        public void SetAnswer(string answer)
        {
            Answer = new Answer(answer);
        }
    }
}
