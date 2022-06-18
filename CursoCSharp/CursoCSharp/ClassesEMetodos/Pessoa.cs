using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; //Atributo
        public int Idade;   //Atributo

        public string Apresentar()
        {
            //Metodo Format faz mais ou menos a mesmo coisa que o WriteLine
            //Só que ao inves de imprimir no console ele retorna um string formatada
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos ");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
