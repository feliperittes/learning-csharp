using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool BomComportamento = false;
            string entrada;
            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui um bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S"||entrada == "s") BomComportamento = true;
            //BomComportamento = entrada == "S" || entrada == "s";
            BomComportamento = entrada.ToLower() == "s";

            if (nota>=9.0 && BomComportamento)
            {
                Console.WriteLine("Quandro de honra!");
            }

        }
    }
}
