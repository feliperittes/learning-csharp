using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7; //substituiu o valor de num1
            num1 += 10; //num1 = num1  + 10;
            num1 -= 10; //num1 = num1  - 10;
            num1 *= 10; //num1 = num1  * 10;
            num1 /= 10; //num1 = num1  / 10;

            int a = 1;
            int b = 2;

            a++; //b = b + 1
            b--; //b = b - 1

            Console.WriteLine($"{a} {b}");

            //Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Felipe";

            dynamic d = c;
            d.nome = "Isaac";

            Console.WriteLine(c.nome);
        }
    }
}
