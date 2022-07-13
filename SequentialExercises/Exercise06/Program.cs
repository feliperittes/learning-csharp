namespace Exercise06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o valor de A,B e C (na mesma linha, separando com espaço): ");
            string[] array = Console.ReadLine().Split(' ');
            double A = double.Parse(array[0]);
            double B = double.Parse(array[1]);
            double C = double.Parse(array[2]);

            double triangle = A * C / 2;
            double circle = Math.PI * Math.Pow(C, 2);
            double trapeze = (A + B) / C * 2;
            double square = Math.Pow(B, 2);
            double rectangle = A * B;

            Console.WriteLine($"TRIANGULO = {triangle.ToString("F3")}");
            Console.WriteLine($"CIRCULO = {circle.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO = {trapeze.ToString("F3")}");
            Console.WriteLine($"QUADRADO = {square.ToString("F3")}");
            Console.WriteLine($"RETANGULO = {rectangle.ToString("F3")}");
        
            Console.ReadKey();
        }
    }
}


