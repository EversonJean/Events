using AutoMapper;
using Events.Application.Dtos;
using Events.Application.Interfaces;
using Events.Domain.Entities;
using Events.Domain.Interfaces.Service;

namespace Events.Application.Services
{
    public class EventAppService : AppService<EventDto, Event, IEventService>, IEventAppService
    {
        public EventAppService(IEventService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}