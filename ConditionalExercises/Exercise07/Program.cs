namespace Exercise07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite dois valores(mesma linha, usando espaço entre eles)\n" +
                "que devem representar as coordenadas de um ponto em um plano:\n>");
            string[] values = Console.ReadLine().Split(' ');
            double X = double.Parse(values[0]);
            double Y = double.Parse(values[1]);

            if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.ReadKey();
        }
    }
}
