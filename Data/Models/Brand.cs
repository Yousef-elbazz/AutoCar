namespace AutoCar.Data.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string name { get; set; }
        public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
