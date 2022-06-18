using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int num = 49;
            if ( num % 2 == 0){
                Console.WriteLine("Numero Par");
            }
            else
            {
                Console.WriteLine("Numero Impar");
            }
            
            int intervalo = 50;
            Console.WriteLine("\nNumeros pares entre 1 e {0}", intervalo);

            for(int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
                Console.ReadKey();
            }
        }
    }
}
