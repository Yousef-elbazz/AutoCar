using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCar
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        // Relationships
        public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
