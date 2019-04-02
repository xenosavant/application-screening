using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Services
{
    class ApplicationService : IApplicationService
    {
        public ApplicationService()
        {

        }

        public bool VerifyApplication(JobApplication Application)
        {
            throw new NotImplementedException();
        }
    }
}
