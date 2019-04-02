using ApplicationScreening.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.JobApplicationAggregate
{
    public class JobApplication : AuditableEntity<Guid>
    {
        public string Name { get; private set; }

        private readonly List<Response> _responses;
        public IReadOnlyCollection<Response> Responses => _responses;

        public JobApplication(string name)
        {
            _responses = new List<Response>();
            Name = name;
        }

        public void AddResponse(Response response)
        {
            _responses.Add(response);
        }
    }
}
