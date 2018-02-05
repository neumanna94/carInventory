using System.Collections.Generic;
namespace CarInventory.Models
{
    public class Car
    {
        private string _make;
        private string _date;
        private int _cost;
        private static List<Car> _allCars = new List<Car>{};

        public Car()
        {
            _make = "";
            _date = "";
            _cost = 0;
        }

        public Car(string makeIn, string dateIn, int costIn)
        {
            _make = makeIn;
            _date = dateIn;
            _cost = costIn;
        }

        public void SetMake(string inputMake)
        {
            _make = inputMake;
        }

        public void SetDate(string inputDate)
        {
            _date = inputDate;
        }

        public void SetCost(string inputCost)
        {
            _cost = int.Parse(inputCost);
        }

        public string GetCost()
        {
            return _cost.ToString();
        }

        public string ReturnCarInformation()
        {
            return "Make: " + _make + " Year: " + _date + " Cost: " + this.GetCost();
        }

        public void PushToList(Car pushThisCar)
        {
            _allCars.Add(pushThisCar);
        }
    }
}
