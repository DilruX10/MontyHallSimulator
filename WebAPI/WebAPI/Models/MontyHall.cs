using System;

namespace WebAPI.Models
{
    public class MontyHall
    {
        public int Id { get; set; }

        public int choosedDoor {get; set; }

        public Boolean changed { get; set; }

        public int openedDoor { get; set; }

        public int changedDoor { get; set; }

        public int moneyDoor {  get; set; }

        public string result { get; set; }

        public MontyHall(int id, Boolean changed)
        {
            this.Id = id;
            this.changed = changed;
            this.choosedDoor = Random.Shared.Next(0, 3);
            this.moneyDoor = Random.Shared.Next(0, 3);
            MontyHallAlgo(this.choosedDoor, this.changed);
        }

        private void MontyHallAlgo(int choosedDoor, Boolean changed)
        {
            // create a string array representing 3 doors
            string[] doorArray = new string[3] { "G", "G", "G" };

            // assign the choosed door
            doorArray.SetValue("C", this.choosedDoor);

            // assign the money door. openedDoor = (not choosedDoor or moneyDoor)
            for (int i = 0; i < 3; i++)
            {
                if (this.choosedDoor != i && this.moneyDoor != i)
                    this.openedDoor = i;
            }
            doorArray.SetValue("O", this.openedDoor);
            

            // get the result
            if (this.changed)
            {
                // assign the changed door. changedDoor = (not choosedDoor or openedDoor)
                this.changedDoor = Array.IndexOf(doorArray, "G");

                this.result = (this.changedDoor == this.moneyDoor) ? "You Won" : "You Lost";

            }
            else
            {
                this.changedDoor = -1;
                this.result = (this.choosedDoor == this.moneyDoor) ? "You Won" : "You Lost";
            }
        }
    }
}
