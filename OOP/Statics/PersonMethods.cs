using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    partial class Person // apenas os metodos da classe Pessoa //utilizando partial para separar as classes
    {
        public void Show()
        {
            Console.WriteLine($"Hi i'm {name}");
        }

        public static int CalculateAge(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}
