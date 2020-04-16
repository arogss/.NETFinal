using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Trainers")]
    public class TrainerEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("AddressId")]
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
        public virtual ICollection<ClientEntity> Clients { get; set; }
    }
    
}
