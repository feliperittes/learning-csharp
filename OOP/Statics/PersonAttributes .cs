using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    partial class Person // Apenas os atributos da classe Pessoa // usando partial para separar as classes
    {
        //Membros estaticos nada mais são que membros no formato estatico
        //Dentro de uma classe que não é estatica
        //Quando não temos a classe estatica ela pode conter membros comuns que são instaciados no objeto
        //e membros estaticos que são acessados diretamente na classe e não vão aparecer no objeto dessa classe

        public static int AgeMajority = 18;

        public string name;
        public int age;
    }
}
