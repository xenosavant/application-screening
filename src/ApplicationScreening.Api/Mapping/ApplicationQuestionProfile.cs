using ApplicationScreening.Api.Dtos;
using ApplicationScreening.Domain.Entities.ApplicationQuestionAggregate;
using AutoMapper;

namespace ApplicationScreening.Api.Mapping
{
    public class ApplicationQuestionProfile : Profile
    {
        public ApplicationQuestionProfile()
        {
            CreateMap<ApplicationQuestion, ApplicationQuestionDto>()
                .ForMember(dest => dest.Question, opts => opts.MapFrom(src => src.Question))
                .ForMember(dest => dest.Answer, opts => opts.MapFrom(src => src.Answer.Value))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
