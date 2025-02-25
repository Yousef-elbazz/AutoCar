using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }

        // Relationships
        public Order Order { get; set; } = null!;
    }
}
