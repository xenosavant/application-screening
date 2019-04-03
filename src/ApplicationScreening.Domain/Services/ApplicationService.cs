using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationScreening.Domain.Services
{
    public class ApplicationService : IApplicationService
    {
        public ApplicationService()
        {

        }

        public bool VerifyApplication(List<Response> Responses, List<ApplicationQuestion> Answers)
        {
            foreach (var response in Responses)
            {
                var answer = Answers.Where(a => a.Id == response.QuestionId).FirstOrDefault();
                if (answer == null || !response.Answer.Equals(answer.Answer))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
