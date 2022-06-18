using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Human
    {
        public virtual void Eyes()
        {
            Console.WriteLine("Human.Eyes");
        }
        public virtual void Hairs()
        {
            Console.WriteLine("Human.Hairs");
        }
    }
    class Person : Human
    {
        public sealed override void Eyes()
        {
            Console.WriteLine("Person.Eyes");
        }
        public override void Hairs()
        {
            Console.WriteLine("Person.Hairs");
        }
    }
    class Man : Person
    {
        //public override void Eyes()
        //{
        //    Console.WriteLine("Man.Eyes");
        //}
        public override void Hairs()
        {
            Console.WriteLine("Man.Hairs");
        }
    }
}
