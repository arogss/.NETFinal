using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class TrainerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=FinalTestNETClass;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<AddressEntity> Customers { get; set; }
        public DbSet<ClientEntity> Addresses { get; set; }
        public DbSet<TrainerEntity> OrderDetails { get; set; }
    }
}