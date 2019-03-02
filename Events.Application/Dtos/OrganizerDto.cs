using System;

namespace Events.Application.Dtos
{
    public class OrganizerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}