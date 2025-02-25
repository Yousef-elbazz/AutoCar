using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public string? PaymentStatus { get; set; }
        public string? DeliveryStatus { get; set; }

        // Relationships
        public User User { get; set; } = null!;
        public Payment Payment { get; set; } = null!;

        // Many-to-many relationship with Car
        public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
