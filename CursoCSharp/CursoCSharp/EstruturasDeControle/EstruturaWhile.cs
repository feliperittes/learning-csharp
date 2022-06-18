using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) // se numero secreto for igual
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas.");

                    Console.ForegroundColor = corAnterior;
                }
                else if(palpite > numeroSecreto)// se numero secreto for menor
                {
                    Console.WriteLine("Insira um Palpite Menor.... Tente Novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
                else // se numero secreto for maior
                {
                    Console.WriteLine("Insira um Palpite Maior.... Tente novamente!");
                    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                }
            }
        }
    }
}
