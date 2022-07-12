namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"NUMERO:{number} é PAR");
            }
            else
            {
                Console.WriteLine($"NUMERO:{number} é IMPAR");
            }
                Console.ReadKey();
        }
    }
}