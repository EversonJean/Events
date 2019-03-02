using Events.Domain.Entities;
using Events.Domain.Interfaces;
using Events.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Events.Infra.Data.Repository
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(EventContext context) : base(context)
        {
        }

        public override Event GetById(Guid id)
        {
            return DbSet.Include(x => x.Address).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Event> GetEventByOrganizer(Guid organizerId)
        {
            return DbSet.Where(x => x.OrganizerId == organizerId);
        }
    }
}
