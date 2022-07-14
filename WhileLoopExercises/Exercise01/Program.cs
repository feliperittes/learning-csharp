namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string password = "2002";
            Console.Write("Insira a senha correta: ");
            string insertPassword = Console.ReadLine();

            while (insertPassword != password)
            {
                Console.Write("\nAcesso Negado\nSenha invalida...");
                Thread.Sleep(3000);
                Console.Clear();

                Console.Write("Insira a senha novamente: ");
                insertPassword = Console.ReadLine();
            }
            Console.WriteLine("\nSenha correta!\nAcesso Permitido!");

            Console.ReadKey();
        }
    }
}