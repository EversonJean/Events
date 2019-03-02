using AutoMapper;
using Events.Application.Dtos;
using Events.Domain.Entities;

namespace Events.Application.AutoMapper
{
    internal class DtoToDomainMapperProfile : Profile
    {
        public DtoToDomainMapperProfile()
        {
            CreateMap<EventDto, Event>();
            CreateMap<AddressDto, Address>();
            CreateMap<CategoryDto, Category>();
            CreateMap<OrganizerDto, Organizer>();
        }
    }
}