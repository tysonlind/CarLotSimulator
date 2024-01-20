using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot myCars = new CarLot();

            Car roadster = new Car(2024, "BMW Z4", "Roadster", "Vroom vroom!", "Neehhhhh!", true);

            Car jaguar = new Car(2024, "Tata Motors", "Jaguar", "Zzzzzzooommm!", "Buhhhhh!", true);

            Car benz = new Car(2024, "Mercedes", "Benz", "Purrrrr", "Beep beep!", true);
            Console.WriteLine("These are the cars in my list:\n");
            myCars.AddCar(benz);
            myCars.AddCar(jaguar);
            myCars.AddCar(roadster);

            myCars.ListCars();

            Console.WriteLine("\nThey make these sounds:\n");

            roadster.MakeEngineNoise(roadster.EngineNoise);
            roadster.MakeHonkNoise(roadster.HonkNoise);
            jaguar.MakeEngineNoise(jaguar.EngineNoise);
            jaguar.MakeHonkNoise(jaguar.HonkNoise);
            benz.MakeEngineNoise(benz.EngineNoise);
            benz.MakeHonkNoise(benz.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            GenericCar stealth = new GenericCar() { Year = 2023, Make = "Secret", Model = "Stealth", EngineNoise = "Ssssooooo!", HonkNoise = "...", IsDriveable = false};
            GenericCar secret = new GenericCar();
            secret.Year = 2023;
            secret.Make = "secret";
            secret.Model = "unknown";
            secret.EngineNoise = "...";
            secret.HonkNoise = "...";
            secret.IsDriveable = false;

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
