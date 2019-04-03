using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    public interface IApplicationService
    {
        bool VerifyApplication(List<Response> Responses, List<ApplicationQuestion> Answers);
    }
}
