namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira um valor para calcular sua faltorial: ");
            int fatorial = int.Parse(Console.ReadLine());
            int resultFatorial = 1;
            for (int i = 1; i <= fatorial; i++)
            {
                resultFatorial *= i;
            }
            Console.WriteLine($"Fatorial escolhido {fatorial}! = {resultFatorial}.");
            Console.ReadKey();
        }
    }
}