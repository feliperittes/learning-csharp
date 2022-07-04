using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        //Metodo de classe ou Metodo estatico!!!
        public int Somar(int a, int b)// só é acessivel a partir da instancia
        {
            return a + b;
        }

        //Metodo Estatico!!!
        public static int Multiplicar(int a, int b)// acessivel a partir da classe // membro estatico pertence a classe
        {
            return a * b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(1, 2);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(1, 8)); //Membro de instacia
            Console.WriteLine(CalculadoraEstatica.Multiplicar(1, 8)); //Membro de Classe ou estatico
        }
    }
}
