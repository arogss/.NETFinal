using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    class AddressDTO
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
    }
}
