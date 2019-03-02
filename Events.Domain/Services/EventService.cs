using Events.Domain.Entities;
using Events.Domain.Interfaces;
using Events.Domain.Interfaces.Service;

namespace Events.Domain.Services
{
    public class EventService : Service<Event, IEventRepository>, IEventService
    {
        public EventService(IEventRepository repository) : base(repository)
        {
        }

        public override bool IsValid(Event obj)
        {
            //TODO: Implements validations
            return true;
        }
    }
}
