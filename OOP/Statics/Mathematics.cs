using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics // esse statics aqui é só o nome do projeto obs: é que eu sou burro e esqueço
{
    static class Mathematics // quando a classe é static todos seus membros precisão ser statics
    {
        public static int rate;// rate é taxa em portugueskk

        public static int Add(int value)// Método Adicionar
        {
            return value + rate;
        }
        public static int Decrease(int value)// Método Diminuir
        {
            return value - rate;
        }
    }
}
