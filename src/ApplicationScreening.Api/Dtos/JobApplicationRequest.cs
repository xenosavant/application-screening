using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using AutoMapper;
using System.Collections.Generic;

namespace ApplicationScreening.Api.Dtos
{
    public class JobApplicationRequest
    {
        public string Name { get; set; }
        public List<ApplicationRequestResponse> Questions { get; set; }
    }

    public class ApplicationRequestResponse
    {
        public string Id { get; set; }
        public string Answer { get; set; }
    }
}
