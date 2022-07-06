namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            int A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {A + B}");

            Console.ReadKey();
        }
    }
}