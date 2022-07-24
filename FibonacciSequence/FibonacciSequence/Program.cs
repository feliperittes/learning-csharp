namespace FibonacciSequence
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 
            int a = 0, b = 1, c = 0;
            Console.Write("Quantos valores: ");
            int amountValues = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sequência de Fibonacci com {amountValues} valores.");

            for (int i = 0; i < amountValues; i++)
            {
                if (i < amountValues - 1)
                {
                    Console.Write($"{a} ,");
                }
                else
                {
                    Console.Write($"{a}.");
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();  
        }
    }
}
