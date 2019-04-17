using Events.Application.Dtos;
using Events.Domain.Entities;
using System.Collections.Generic;

namespace Events.Application.Interfaces
{
    public interface IEventAppService : IAppService<Event>
    {
        IEnumerable<dynamic> GetEventList();
    }
}
