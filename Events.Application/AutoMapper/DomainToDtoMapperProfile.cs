using AutoMapper;
using Events.Application.Dtos;
using Events.Domain.Entities;

namespace Events.Application.AutoMapper
{
    internal class DomainToDtoMapperProfile : Profile
    {
        public DomainToDtoMapperProfile()
        {
            CreateMap<Event, EventDto>(); 
            CreateMap<Address, AddressDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Organizer, OrganizerDto>();
        }
    }
}