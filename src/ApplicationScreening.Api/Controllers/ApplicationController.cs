using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using QuestionFilters = ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate.ApplicationQuestionFilters;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using ApplicationScreening.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationScreening.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ApplicationController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IJobApplicationRepository _repository;
        private readonly IApplicationQuestionRepository _questionsRepository;
        private readonly IApplicationService _applicationService;

        public ApplicationController(IJobApplicationRepository repository,
            IApplicationQuestionRepository questionsRepository,
            IApplicationService applicationService)
        {
            _questionsRepository = questionsRepository;
            _repository = repository;
            _applicationService = applicationService;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody] JobApplicationDto applicationDto)
        {
            var application = new JobApplication(applicationDto.Name);
            var questionIds = new List<Guid>();
            foreach (var response in applicationDto.Questions)
            {
                application.AddResponse(response.Id, response.Answer);
                questionIds.Add(new Guid(response.Id));
            }
            var filters = new List<IFilter<ApplicationQuestion>>()
            {
                new QuestionFilters.QuestionsWithIds(questionIds)
            };
            var answers = await _questionsRepository.GetList(filters);
            if (answers.Count != applicationDto.Questions.Count)
            {
                return BadRequest();
            }
            if (_applicationService.VerifyApplication(application.Responses.ToList(), answers))
            {
                _repository.Create(application);
            }
            await _repository.SaveAsync();
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<JobApplication>>> Get()
        {
            return await _repository.GetList();
        }
    }
}
