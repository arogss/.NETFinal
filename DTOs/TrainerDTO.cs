using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTOs
{
    class TrainerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("AddressId")]
        public Guid AddressId { get; set; }
        public AddressDTO Address { get; set; }
        public List<ClientDTO> Clients { get; set; }
    }
}
