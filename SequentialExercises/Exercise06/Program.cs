namespace Exercise06
{
    class Program
    {
        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double triangle = A * C / 2;
            double circle = Math.PI * Math.Pow(C, 2);
            double trapeze = (A + B) / C * 2;
            double square = Math.Pow(B, 2);
            double rectangle = A * B;

            Console.WriteLine($"TRIANGULO = {triangle.ToString("F2")}");
            Console.WriteLine($"CIRCULO = {circle.ToString("F2")}");
            Console.WriteLine($"TRAPEZIO = {trapeze.ToString("F2")}");
            Console.WriteLine($"QUADRADO = {square.ToString("F2")}");
            Console.WriteLine($"RETANGULO = {rectangle.ToString("F2")}");
        
            Console.ReadKey();
        }
    }
}


