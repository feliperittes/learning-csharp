namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            int A, B;

            Console.Write("Insira o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {A + B}");

            Console.ReadKey();
        }
    }
}