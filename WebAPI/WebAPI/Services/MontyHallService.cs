using WebAPI.Models;

namespace WebAPI.Services
{

    public static class MontyHallService
    {
        public static List<MontyHall> MontyHallSims { get; set;}

        static MontyHallService()
        {
            // initialize MontyHallSims in the static constructor
            // This will create a new instance of List<MontyHall> that you can add items to.
            MontyHallSims = new List<MontyHall>();
        }

        public static List<MontyHall> GetSims(int numOfSims, Boolean changed)
        {
            MontyHallSims.Clear();

            for (int i = 0; i < numOfSims; i++)
            {
                MontyHall game = new MontyHall(i, changed);
                MontyHallSims.Add(game);
            }

            return MontyHallSims;
        }

    }
}