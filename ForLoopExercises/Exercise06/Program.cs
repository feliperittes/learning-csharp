namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um valor para calculaR todos seus divisores: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = N; i >= 1; i--)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}