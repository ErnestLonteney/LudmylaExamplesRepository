using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRevision
{
    internal class Address
    {
        public required string City { get; init; }

        public required string Street { get; init; }

        public required string Number { get; init; }

        public string? PostCode { get; set; } 

    }
}
