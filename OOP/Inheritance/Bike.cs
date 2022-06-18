using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class sealed é uma classe selada e não pode ser herdada apenas para instanciar objetos
    sealed class Bike : Vehicle
    {
        public void Pedaling()
        {

        }
        public override void Accelerate() // metodo abstrato sobreescrito na classe bike
        {
            Console.WriteLine("Accelerated The Bike!");
        }
        public override void Stop()
        {
            Console.WriteLine("Stopped The Bike");
        }
    }
}
