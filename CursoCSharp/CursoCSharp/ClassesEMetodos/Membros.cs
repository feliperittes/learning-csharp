using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
         //Tipo|Classe           //Construtor
            Pessoa sicrano = new Pessoa(); // criando objeto do tipo Pessoa
            sicrano.Nome = "Felipe";
            sicrano.Idade = 21;
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Isaac";
            fulano.Idade = 21;
            var aprensentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(aprensentacaoDoFulano.Length);
            Console.WriteLine(aprensentacaoDoFulano);
        }
    }
}
