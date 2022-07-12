namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um numero: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            Console.ReadKey();
        }
    }
}