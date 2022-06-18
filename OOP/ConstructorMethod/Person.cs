using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
    class Person
    {
        public string name;
        public string lastName;
        public int birthYear;
        public int age;

        //Método Construtor - não tem qualquer retorno
        //sempre public e o mesmo nome da classe
        public Person()
        {
            name = "Unknowno";
            lastName = "None";
            birthYear = 0;
            age = 0;
        }
        public Person(string name, string lastName, int birthYear)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthYear = birthYear;
            age = Age();
        }
        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthYear = 2000;
            age = Age();
        }

        private int Age()
        {
            return 2022 - birthYear;
        }
    }
}
