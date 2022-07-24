namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira a quantidade casos de teste: ");
            int N =  int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"\nInsira a {i}ª teste: ");
                string [] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0]);
                double b = double.Parse(line[1]);
                double c = double.Parse(line[2]);

                double result = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine($"Resultado do {i}º teste {result.ToString("N1")}");
            }
            Console.ReadKey();
        }
    }
}