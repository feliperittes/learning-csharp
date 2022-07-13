namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o valor de A: ");
            int A =  int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            int B =  int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de C: ");
            int C =  int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de D: ");
            int D =  int.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENÇA = {(A * B) - (C * D)}");

            Console.ReadKey();
        }
    }
}
