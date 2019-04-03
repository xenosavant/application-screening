using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationScreening.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly IApplicationQuestionRepository _repository;
        private readonly IMapper _mapper;

        public QuestionController(IApplicationQuestionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ApplicationQuestion>> Post([FromBody] ApplicationQuestionDto questionDto)
        {
            var question = new ApplicationQuestion(questionDto.Question);
            question.SetAnswer(questionDto.Answer);
            _repository.Create(question);
            await _repository.SaveAsync();
            return Ok(_mapper.Map<ApplicationQuestionDto>(question));
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<List<ApplicationQuestionDto>>> Get()
        {
            return Ok(_mapper.Map<List<ApplicationQuestionDto>>(await _repository.GetList()));
        }
    }
}
