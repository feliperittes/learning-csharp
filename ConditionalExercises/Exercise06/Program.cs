namespace Exercise06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um valor: ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0.0 || number > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (number <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (number <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }

            Console.ReadKey();
        }
    }
}
