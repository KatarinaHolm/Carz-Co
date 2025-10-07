using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int AmountOfWheels { get; set; }

        public Vehicle(string brand, string model, int amountOfWheels)
        {
            Brand = brand;
            Model = model;
            AmountOfWheels = amountOfWheels;
        }

        // En beskriv metod?
        // "
        public static List<Vehicle> AddVehicle(List<Vehicle> vehicles)
        {
            //List<Type> vehicleTypes = new List<Type>
            //{
            //    typeof(Car),
            //    typeof(Truck),
            //    typeof(Motorcycle)
            //};

            //var type = vehicleTypes[0];
            //Vehicle name = new type();
            // Vilket fordon är det
            Console.WriteLine("Välj vilket fordon vill du lägga till? (1. Bil, 2. Lastbil, 3. Motorcykel):");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number == 1)
            {
                // gör två strängar
                Console.WriteLine("Vad är märket på bilen.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Vad är modellen på bilen.");
                string input2 = Console.ReadLine();
                // spara två user input i dem
                // Applya när vi skapar det nya vehicle objectet
                vehicles.Add(new Car(input1, input2));
                return vehicles;

            }
            else if (number == 2)
            {
                Console.WriteLine("Vad är märket på lastbil.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Vad är modellen på lastbil.");
                string input2 = Console.ReadLine();

                vehicles.Add(new Truck(input1, input2));
                return vehicles;
            }
            else if (number == 3)
            {
                Console.WriteLine("Vad är märket på motorcykeln.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Vad är modellen på motorcykeln.");
                string input2 = Console.ReadLine();
                
                vehicles.Add(new Motorcycle(input1, input2));
                return vehicles;
            }
            else
            {
                return vehicles;
            }

            // Fråga märke
            // Fråga modell

            //Console.Write("")
            //Console.Write("Skriv in model:");
            //string model = Console.ReadLine();

            //Console.Write("Skriv in varumärke:");
            //string brand = Console.ReadLine();

            //Console.Write("Skriv in hur många hjul har fordonet:");
            //string wheels = Console.ReadLine();
        }

       

        public static void FilterVehicles<T>(List<Vehicle> vehicles)
        {
            Console.WriteLine("\nFiltrera fordon:");
            foreach (Vehicle vehicle in vehicles)
            {
                // vehicles.OfType<T>()
                if (vehicle is T)
                {
                    Console.WriteLine(vehicle.Brand);
                }
            }
        }

        public static void PrintVehicleList(List<Vehicle> vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Brand}, {vehicle.Model}");
            }
        }

        public static List<Vehicle> RemoveVehicle(List<Vehicle> vehicles)
        {
            // Vilket fordon är det
            Console.Write("Skriv märke på bilen du vill ta bort: ");
            string input = Console.ReadLine().ToLower().Trim();
                        
            var vehicleToRemove = vehicles.Find(v => v.Brand.ToLower() == input);

            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
            }
            else
            {
                Console.WriteLine("Kan inte hitta märket du vill ta bort.");
            }
            
            return vehicles;
        }
    } 
}
