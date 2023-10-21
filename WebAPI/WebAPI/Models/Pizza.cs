namespace WebAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price => Random.Shared.Next(10000, 20000) / 100.00;

        public string Size { get; set; }
    }
}
