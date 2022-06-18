using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class CashMachine : IAccount // Caixa Eletronico
    {
        public string User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Balance()
        {
        }

        public void Deposit()
        {
        }

        public void Withdraw()
        {
            
        }
    }

    // interface é um especie de classe completamente abstrata
    interface IAccount
    {
        string User { get; set; }
        void Deposit(); // depositar
        void Withdraw(); // sacar
        void Balance(); // saldo
    }
}
