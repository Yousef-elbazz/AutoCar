
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
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> modelBuilder)
        {
            // Car - Category relationship (many-to-one)
            modelBuilder
                .HasOne(c => c.Category)
                .WithMany(c => c.Cars);

        }
    }
}
