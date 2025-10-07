using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Carz_Co
{
    public class Car : Vehicle, IDriveable
    {
        public Car(string brand, string model) : base(brand, model, 4)
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
