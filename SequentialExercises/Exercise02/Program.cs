namespace Exercise02
{
    class Program
    {
        public static void Main(string[] args)
        {
            double ray =  double.Parse(Console.ReadLine());

            const double pi = Math.PI;
            double area = pi * (Math.Pow(ray, 2));

            Console.WriteLine($"A = {area.ToString("N4")}");
            Console.ReadKey();
        }
    }
}
