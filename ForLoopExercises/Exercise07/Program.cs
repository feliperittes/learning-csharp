namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um valor inteiro para quantidade de linhas: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
            Console.ReadKey();
        }
    }
}