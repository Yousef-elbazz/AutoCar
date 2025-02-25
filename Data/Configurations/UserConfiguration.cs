using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            // User - Order relationship (one-to-many)
            modelBuilder
                .HasMany(u => u.Orders)
                .WithOne(o => o.User);

            // User - Cart relationship (one-to-one)
            modelBuilder
                .HasMany(u => u.Carts)            
                .WithOne(c => c.User);
        }
    }
}
