using System.Linq;
using AutoMapper;
using Events.Application.Dtos;
using Events.Application.Interfaces;
using Events.Domain.Entities;
using Events.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace Events.Application.Services
{
    public class EventAppService : AppService<EventDto, Event, IEventService>, IEventAppService
    {
        public EventAppService(IEventService service, IMapper mapper) : base(service, mapper)
        {
        }

        public IEnumerable<dynamic> GetEventList()
        {
            var result = _service.GetElementsByExpression(x => new { x.Id, x.Name, x.CompanyName }).ToList();
            return result;
        }
    }
}