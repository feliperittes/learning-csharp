namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int A =  int.Parse(Console.ReadLine());
            int B =  int.Parse(Console.ReadLine());
            int C =  int.Parse(Console.ReadLine());
            int D =  int.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENÇA = {(A * B) - (C * D)}");

            Console.ReadKey();
        }
    }
}
