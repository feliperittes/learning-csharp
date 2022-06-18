using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car : Vehicle
    {
        public int MaximumSpeed { get; set; }
       
        public void StartEngine()
        {
            Console.WriteLine("Car Started Engine!");
        }
        public override void Accelerate()
        {
            Console.WriteLine("Accelerated The Car!");
        }
        public override void Stop()
        {
            Console.WriteLine("Stopped The Car");
        }
    }
}
