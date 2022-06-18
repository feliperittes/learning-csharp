using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar variavel 'a' dentro do Metodo Executar!
            DesafioAtributo mostrar =  new DesafioAtributo();
            Console.WriteLine(mostrar.a);
        }
    }
}
