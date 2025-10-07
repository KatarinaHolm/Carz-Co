using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    public class Motorcycle : Vehicle, IDriveable
    {
        public Motorcycle(string brand, string model) : base(brand, model, 2) 
        {
            Brand = brand;
            Model = model;
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving with {AmountOfWheels} wheels.");
        }
    }
}