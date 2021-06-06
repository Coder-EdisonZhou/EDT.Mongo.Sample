using AutoMapper;

namespace EDT.BookStore.API.Models.Mappings
{
    public class MappingConfigs : Profile
    {
        public MappingConfigs()
        {
            CreateMap<CreateBookDto, Book>().ReverseMap();
            CreateMap<UpdateBookDto, Book>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
