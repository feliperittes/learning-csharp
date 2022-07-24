namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o numero casos de teste: ");
            int N =  int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string [] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0]);
                double b = double.Parse(line[1]);
                double c = double.Parse(line[2]);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("N1"));
            }
            Console.ReadKey();
        }
    }
}