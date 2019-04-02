using ApplicationScreening.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Entities.ApplicationAggregate
{
    class Application : AuditableEntity<string>
    {
        public string Name { get; private set; }

        private readonly List<Response> _responses;
        public IReadOnlyCollection<Response> Responses => _responses;

        public Application(string name)
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
