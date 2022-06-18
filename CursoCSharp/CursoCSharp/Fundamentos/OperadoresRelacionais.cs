using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //OperadoresRelacionais
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;


            Console.WriteLine($"Nota inválida? {nota > 10.0}");//maior que 
            Console.WriteLine($"Nota inválida? {nota < 0.0}");//menor que
            Console.WriteLine($"Perfeito? {nota == 10.0}");// é igual 
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");//diferente
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");//maior igual
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");//menor que
            Console.WriteLine($"Reprovado?{nota<=30.0}");//menor igual
        }
    }
}
