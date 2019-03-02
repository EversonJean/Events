﻿using System;

namespace Events.Domain.Entities
{
    public class Address : Entity
    {
        public string Street { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string District { get; set; }

        public string CEP { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public Guid EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}