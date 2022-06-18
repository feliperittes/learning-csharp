using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é: " + area);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45; // byte só aceita valores positivos
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // sbyte aceita valores negativos e positivos de -128 até 128
            Console.WriteLine("Saldo de Gols: " +  saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario.ToString("C"));

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor inteiro: " + menorValorInt );

            uint populacaoBrasileira = 207_600_300; // uint apenas positivos
            Console.WriteLine("População brasileira: " + populacaoBrasileira);
            
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador =  2500.99f;
            Console.WriteLine("Preço do computador: " + precoComputador.ToString("C"));

            double valorDeMercadoApple = 1_000_000_000_000.00; // Mais usado dos reais
            Console.WriteLine("Valor da Apple: " + valorDeMercadoApple);

            decimal DistanciaEntreEstrelas = decimal.MaxValue; // decimal valores extremos/astronimicos
            Console.WriteLine("Distancia entre estrelas: " + DistanciaEntreEstrelas);

            char Letra = 'c';
            Console.WriteLine("Letra: " + Letra);

        }
    }
}
