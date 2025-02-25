using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> modelBuilder)
        {
            // Order - Car relationship (many-to-many)
            modelBuilder
                .HasMany(o => o.Cars)
                .WithMany(c => c.Orders)
                .UsingEntity(j => j.ToTable("OrderCars"));

            // Order - Payment relationship (one-to-one)
            modelBuilder
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderId);
        }
    }
}
