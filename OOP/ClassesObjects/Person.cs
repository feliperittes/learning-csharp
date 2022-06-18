using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Person
    {
        // Atributos / Campos
        public string name;
        public string lastName;
        public int BirthYear;

        //Metodos são os comportamentos que aquele Objeto deverivado da classe poderá ter, ou as funcionalidades que ele poderá desempenhar
        //Metodos Simples -  nada mas é um metodo que realiza uma função, mas que não tem retorno de qualquer valor e não recebe parametros
        public void Greet()//Metodo Cumprimentar
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Hi i'm {name} {lastName}");
            Console.ResetColor();
        }
    }

}
