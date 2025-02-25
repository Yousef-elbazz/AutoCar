using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    public class Cart
    {
        public int CartId { get; set; }

        // Relationships
        public User User { get; set; }

        // Many-to-many relationship with Car
        public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
