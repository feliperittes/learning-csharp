namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numeros inteiros de [1,{x}]");
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}