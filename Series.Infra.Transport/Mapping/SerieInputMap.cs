using AutoMapper;
using Series.Domain.Entities;
using Series.Infra.Transport.Input;

namespace Series.Infra.Transport.Mapping
{
    public class SerieInputMap : Profile
    {
        public SerieInputMap()
        {
            CreateMap<SerieInput, Serie>()
                .ForMember(recipient => recipient.Title, 
                    map => map.MapFrom(src => src.Title))
                .ForMember(recipient => recipient.Description, 
                    map => map.MapFrom(src => src.Description))
                .ForMember(recipient => recipient.Year, 
                    map => map.MapFrom(src => src.Year))
                .ReverseMap();
        }
    }
}