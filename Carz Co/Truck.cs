using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    public class Truck : Vehicle, IDriveable
    {
        public Truck(string brand, string model) : base(brand, model, 6)
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
