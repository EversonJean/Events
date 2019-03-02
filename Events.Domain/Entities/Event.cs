using System;
using System.Collections.Generic;

namespace Events.Domain.Entities
{
    public class Event : Entity
    {
        public string Name { get; set; }

        public string ShortDescrition { get; set; }

        public string FullDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool Free { get; set; }

        public decimal Value { get; set; }

        public bool Online { get; set; }

        public string CompanyName { get; set; }


        public Guid CategoryId { get; set; }

        public Guid AddressId { get; set; }

        public Guid? OrganizerId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Category Category { get; set; }

        public virtual Organizer Organizer { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
