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
    internal class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> modelBuilder)
        {
            // Cart - Car relationship (many-to-many)
            modelBuilder
                .HasMany(c => c.Cars)
                .WithMany(c => c.Carts)
                .UsingEntity(j => j.ToTable("CartCars"));

        }
    }
}
