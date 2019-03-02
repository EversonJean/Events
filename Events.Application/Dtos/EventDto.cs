using System;

namespace Events.Application.Dtos
{
    public class EventDto
    {
        public Guid Id { get; set; }

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

        public AddressDto Address { get; set; }

        public CategoryDto Category { get; set; }

        public OrganizerDto Organizer { get; set; }
    }
}
