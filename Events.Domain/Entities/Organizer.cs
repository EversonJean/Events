using System.Collections.Generic;

namespace Events.Domain.Entities
{
    public class Organizer : Entity
    {
        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}