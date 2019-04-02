using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    public interface IApplicationService
    {
        bool VerifyApplication(JobApplication Application);
    }
}
