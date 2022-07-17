namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira uma coordenada de um planocartesiano(com espaço entre os valores):\n> ");
            string[] values = Console.ReadLine().Split(' ');
            int X = int.Parse(values[0]);
            int Y = int.Parse(values[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("PRIMEIRO!");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("SEGUNDO");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("TERCEIRO");
                }
                else
                {
                    Console.WriteLine("QUARTO");
                }
                Console.Write("\nInsira novamente uma coordenada de um plano cartesiano:\n>");
                values = Console.ReadLine().Split(' ');
                X = int.Parse(values[0]);
                Y = int.Parse(values[1]);
            }
            Console.ReadKey();
        }
    }
}