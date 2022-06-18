namespace Encapsulate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account();
            Account account1 = new Account();

            account1.Client = "Logan";

            account.Client = "Felipe";

            //account.Balance = 100;

            //========= OPERAÇÃO DEPÓSITO =========//
            double value = 100;
            account.Deposit(value);

            //========= OPERAÇÃO SAQUE =========//
            double value1 = 50;
            account.Withdraw(value1);


            //========= OPERAÇÃO SALDO ATUAL =========//
            Console.WriteLine($"Client: {account.Client}");
            Console.WriteLine($"Balance: {account.Balance}");

            Console.ReadKey();
        }
    }
}
