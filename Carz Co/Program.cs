using System;
using System.Collections.Generic;

namespace Carz_Co
{
    class Program
    {
        /* 
        Volvo, XC60
        Toyota, Corolla
        BMW, 3 Series

        Scania, R500
        Volvo, FH16
        Mercedes-Benz, Actros

        Kawasaki, Ninja ZX-6R
        Yamaha, MT-07
        Harley-Davidson, Street Glide
        */
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle> {
                new Car("Volvo", "XC60"),
                new Motorcycle("Kawasaki", "R500"),
                new Truck("Scania", "Ninja ZX-6R")
                };
            bool mainloop = true;
            while (mainloop)
            {
                Console.WriteLine("Välj ett alternativ\n1. Lägg till fordon\n2. Ta bort fordon\n3. Filtrera fordon\n4. Lista fordon\n5. Avsluta");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int userChoice);
                switch (userChoice)
                {
                    case 1:
                        vehicles = Vehicle.AddVehicle(vehicles);
                        break;
                    case 2:
                        vehicles = Vehicle.RemoveVehicle(vehicles);
                        break;
                    case 3:
                        Console.WriteLine("Vilket typ av fordon vill du filtrera genom? (1. Bil, 2. Lastbil, 3. Motorcykel)");
                        string filteredVehicle = Console.ReadLine();
                        if (int.TryParse(filteredVehicle, out int number) && number == 1)
                        {
                            Vehicle.FilterVehicles<Car>(vehicles);
                        }
                        else if (number == 2)
                        {
                            Vehicle.FilterVehicles<Truck>(vehicles);
                        }
                        else if (number == 3)
                        {
                            Vehicle.FilterVehicles<Motorcycle>(vehicles);
                        }
                            break;
                    case 4:
                        Vehicle.PrintVehicleList(vehicles);
                        break;
                    case 5:
                        mainloop = false;
                        break;
                }
            }

            //        PrintVehicleList(vehicles);
            //vehicles = Vehicle.AddVehicle(vehicles);

            //PrintVehicleList(vehicles);
            //vehicles = Vehicle.RemoveVehicle(vehicles);

            //Vehicle.FilterVehicles<Motorcycle>(vehicles);

            //car.Drive();
            //motorcycle.Drive();
            //truck.Drive();

            //Console.WriteLine("Bara bilar:");
            //if(car is Car)
            //{
            //    Console.WriteLine(car.AmountOfWheels);
            //}
            //else
            //{
            //    Console.WriteLine("Not a car.");
            //}

        }
    }
}