using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfClasses
{
    class Methods
    {
        //Método Simples
        public void Greet()
        {
            Console.WriteLine("Hello, Welcome!");
        }

        //Métodos com parâmetros
        public void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"\nThe sum is: {result}");
        }

        public void Show(string name, int age)
        {
            Console.WriteLine($"\nMy name's {name} i'm {age} years old. ");
        }

        // Passagem de parâmetro por valor
        public void IncreaseValue(int value)
        {
            value += 10;
            Console.WriteLine($"\nFinal value (per value) is: {value}");
        }

        // Passagem de parâmetros por referência
        public void IncreaseRef(ref int value)
        {
            value += 10;
            Console.WriteLine($"Final value (per reference) is: {value}");
        }

        //Métodos com retorno de valores
        public string AssembleName(string name, string lastName)
        {
            //string completeName = $"{name} {lastName}";
            return $"{name} {lastName}";
        }

        public int CharCode(char character)
        {
            int code = (int)character;
            return character;
        }

        public double ValuePI()
        {
            return 3.1415;
        }

        //Sobrecarga de métodos

        public void Greet(string name)
        {
            Console.WriteLine($"Helo {name}");
        }
        public void Greet(string name, int time)
        {
            string message = time < 12 ? $"Good Morning {name}" : $"Good Afternoon {name}.";
            Console.WriteLine(message);
        }

        public bool Compare(int num1, int num2)
        {
            return num1 == num2;
        }
        public bool Compare(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
