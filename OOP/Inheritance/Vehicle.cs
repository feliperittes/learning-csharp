using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance //tradução -> Herença
{
    // abstract -> define que essa classe apenas pode ser herdada, não pode ser instanciada
    abstract class Vehicle
    {
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public abstract void Accelerate();
        public abstract void Stop();
    }
}
