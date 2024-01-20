using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    public class CarLot
    {
        public List<Car> ListOfCars { get; set; }
        public CarLot() 
        {
            ListOfCars = new List<Car>();
        }

        public void AddCar(Car car) {
            this.ListOfCars.Add(car);
        }

        public void ListCars()
        {
            foreach (var car in this.ListOfCars)
            {
                Console.WriteLine($"{car.Make}, {car.Model}");
            }
        }
    }
}
