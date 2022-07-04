using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {   
        //Atributos
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //Construtor personalizado quando implementado, o construtor padrão que é implicito se perde
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        //Construtor padrão não recebe nada, é implicito que ele vai retornar uma instancia, tipo no qual ele pertence
        public Carro()//construtor padrão tem que ser adcionado de forma explicita, quando adcionamos um construtor personalizado
        {
        }
    }
    class Construtores
    {
        public static void Executar()
        {
                                    //Construtor
            var primeiroCarro = new Carro();
            primeiroCarro.Fabricante = "BMW";
            primeiroCarro.Modelo = "325i";
            primeiroCarro.Ano = 2017;
            Console.WriteLine(
                $"{primeiroCarro.Fabricante} {primeiroCarro.Modelo} {primeiroCarro.Ano}");


            var segundoCarro = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(
                $"{segundoCarro.Fabricante} {segundoCarro.Modelo} {segundoCarro.Ano}");


            var terceiroCarro = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019,
            };
            Console.WriteLine($"{terceiroCarro.Fabricante} {terceiroCarro.Modelo} {terceiroCarro.Ano}");
        }
    }
}
