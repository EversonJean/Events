using Events.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Events.Domain.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        IEnumerable<Event> GetEventByOrganizer(Guid organizerId);


    }
}
