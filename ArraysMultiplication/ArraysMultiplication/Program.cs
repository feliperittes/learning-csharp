namespace ArraysMultiplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] firstArray = new int[2, 3];
            int[,] secondArray = new int[3, 2];
            int[,] result = new int[2, 2];

            Console.WriteLine("Preencher a matriz #1 ");

            for (int line = 0; line < 2; line++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"#1. Posição [{line}] [{column}]: ");
                    firstArray[line, column] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPreencher a matriz #2: ");

            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 2; column++)
                {
                    Console.Write($"#1. Posição [{line}] [{column}]: ");
                    secondArray[line, column] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da matriz #1 x #2");
            result[0, 0] = (firstArray[0, 0] * secondArray[0, 0]) + (firstArray[0, 1] * secondArray[1, 0]) + (firstArray[0, 2] * secondArray[2, 0]);
            result[1, 0] = (firstArray[1, 0] * secondArray[0, 0]) + (firstArray[1, 1] * secondArray[1, 0]) + (firstArray[1, 2] * secondArray[2, 0]);
            result[0, 1] = (firstArray[0, 0] * secondArray[0, 1]) + (firstArray[0, 1] * secondArray[1, 1]) + (firstArray[0, 2] * secondArray[2, 1]);
            result[1, 1] = (firstArray[1, 0] * secondArray[0, 1]) + (firstArray[1, 1] * secondArray[1, 1]) + (firstArray[1, 2] * secondArray[2, 1]);

            Console.WriteLine($"[{result[0, 0]}] [{result[0, 1]}]");
            Console.WriteLine($"[{result[0, 0]}] [{result[1, 0]}]");

            Console.ReadKey();

        }
    }
}