using WebAPI.Models;

namespace WebAPI.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static int nextId = 4;

        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
            new Pizza { Id = 1, Name = "Classic Italian", Size="Small"},
            new Pizza { Id = 2, Name = "Veggie", Size="Medium"},
            new Pizza { Id = 3, Name = "Masala", Size="Large"}

            };        
        
        }
        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static List<Pizza>? GetByIdAndSize(int id, string size) => Pizzas.FindAll(p => (p.Id == id && p.Size.Equals(size)));

    }
}
