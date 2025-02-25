using AutoCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int BrandId { get; set; }  
        public int Year { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; } 

        // Relationships
        public Category? Category { get; set; }
        public Brand? Brand { get; set; }

        // Many-to-many relationships with Order and Cart
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
    }
}
