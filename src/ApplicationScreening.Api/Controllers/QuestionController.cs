using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationScreening.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly IApplicationQuestionRepository _repository;

        public QuestionController(IApplicationQuestionRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post([FromBody] ApplicationQuestionDto questionDto)
        {
            var question = new ApplicationQuestion(questionDto.Question);
            question.SetAnswer(questionDto.Answer);
            _repository.Create(question);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}
