namespace Exercise04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de divisões: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"\nInsira a {i}ª divisão: ");
                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0]);
                double b = double.Parse(line[1]);
                double result = a / b;
                if (b != 0)
                {
                    Console.WriteLine($"Resultado da {i}ª divisão: {result}");
                }
                else
                {
                    Console.WriteLine("Divisão impossivel");
                }
            }
            Console.ReadKey();
        }
    }
}