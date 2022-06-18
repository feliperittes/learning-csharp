using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //1 casa decimal
            Console.WriteLine(valor.ToString("C")); //valor monetario
            Console.WriteLine(valor.ToString("P")); //porcentagem
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine("Valor em dolar: " + valor.ToString("C3 ", cultura));
            
            CultureInfo cultura2 = new CultureInfo("pt-BR");
            Console.WriteLine("Valor em reias: " + valor.ToString("C3", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // vai adicionar zeros a esquerda até que tenha 10 numeros
        }
    }
}
