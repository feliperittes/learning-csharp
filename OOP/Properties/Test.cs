using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Test
    {
        //Definição de um campo
        private string _name;
        public string LastName { get; } = "Fernandes";

        private int _age;

        //Definição de uma propriedade
        //não tem () para definir seus parametros diferente de um metedo 
        public string Name
        {
            get
            {
                return _name;
            }

            //set - serve para definir valores para nossos campos
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age cannot be less than 18 years old");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public void Show()
        {
            if (_name != "")
            {
                Console.WriteLine($"Bem vindo {_name}");
            }
        }
    }
}
