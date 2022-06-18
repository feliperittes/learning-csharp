using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers // Modificadores
{
    class Test
    {
        private string name; // "private" é particular das classes, não pode usar na herança
        public string lastName; // "public" é public para todo mundo, tanto para quem herda tanto para os objetos

        private void Method1()
        {

        }
        public void Perform() // Executar()
        {

        }
    }
    class Human
    {
        protected string name; // "protected" fica disponivel para herença, mas não para os objetos instanciados
        private string lastName; // é particular da desta classe "private"

        internal int age; // quer dizer que esse membro vai ser restrito a esta aplicação, quer dizer caso for criada
                          // uma DLL(uma biblioteca) dessa classe esse internal não pode ser utilizado em outras aplicações
    }
    class Man : Human
    {
        public void Method()
        {
            name = "";
            age = 0;
        }
    }
}
