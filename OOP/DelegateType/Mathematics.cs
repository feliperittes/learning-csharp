using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateType
{
    class Mathematics
    {
        public void Sum(int n1, int n2)
        {
            Console.WriteLine($"The sum is: {n1 + n2}");
        }
        public void Subtract(int n1, int n2)
        {
            Console.WriteLine($"The subtraction is: {n1 - n2}");
        }
        public void Divide(int n1, int n2)
        {
            Console.WriteLine($"The division is: {n1 / n2}");
        }
        public void Multiply(int n1, int n2)
        {
            Console.WriteLine($"The multiplication is: {n1 * n2}");
        }
    }
}
