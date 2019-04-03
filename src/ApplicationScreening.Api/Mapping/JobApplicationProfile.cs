using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.JobApplicationAggregate;
using AutoMapper;
using System;

namespace ApplicationScreening.Api.Mapping
{
    public class JobApplicationProfile : Profile
    {
        public JobApplicationProfile()
        {
            CreateMap<JobApplication, JobApplicationDto>()
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name))
                .ForMember(dest => dest.Questions, opts => opts.MapFrom(src => src.Responses))
                .ForAllOtherMembers(x => x.Ignore());

            CreateMap<Response, ResponseDto>()
                .ForMember(dest => dest.Question, opts => opts.MapFrom(src => src.Question.Question))
                .ForMember(dest => dest.Answer, opts => opts.MapFrom(src => src.Answer.Value))
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
