using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Account
    {
        private string _client; // cliente
        private double _balance; // saldo
        private double _fee = 10; //taxa


        public string Client
        {
            get
            {
                return _client;
            }
            set
            {
                if (value != "Felipe" && _client != "Isaac")
                {
                    _client = "Visitor";
                    Balance = 0;
                }
                else
                {
                    _client = value;
                    Balance = 100;
                }
            }
        }
        public double Balance // saldo
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
            }
        }

        public void Withdraw(double value) // Saque / Retirada
        {
            value += _fee; //taxa
            _balance -= value;
        }

        public void Deposit(double value) // Deposito
        {
            _balance += value;
        }
    }
}
