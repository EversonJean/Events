using System.Collections.Generic;

namespace Events.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}