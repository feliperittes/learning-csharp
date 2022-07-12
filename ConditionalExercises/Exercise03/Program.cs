namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira dois numeros(mesma linha separe com a tecla espaço): ");
            string[] array = Console.ReadLine().Split(' ');
            int A = int.Parse(array[0]);
            int B = int.Parse(array[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("SÂO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÂO SÂO MULTIPLOS");
            }

            Console.ReadKey();
        }
    }
}
