using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            //PREÇO/DESCONTO
            var preco = 100.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto.ToString("C")}");

            //IMC
            double peso = 65.8;
            double altura = 1.68;
            double imc = peso / Math.Pow(altura,2);
            Console.WriteLine($"O IMC é {imc}.");

            //NÚMEOR PAR/IMPAR
            int par = 24;
            int impar = 55;
            //jeito do professor
            Console.WriteLine("{0}/2 tem resto {1}.", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}.", par, par % 2);
            //meu jeito
            Console.WriteLine($"{par}/2 tem resto {par % 2}.");
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}.");
        }
    }
}
