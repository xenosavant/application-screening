using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Api.Dtos
{
    public class ResponseDto
    {
        public string Id { get; set; }
        public string Answer { get; set; }
    }
}
