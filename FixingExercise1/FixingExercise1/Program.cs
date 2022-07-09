namespace FixingExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: \n>");
            string completeName = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? \n>");
            int roomQuantity = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço do produto: \n>");
            double priceProduct = double.Parse(Console.ReadLine());

            Console.Write("Entre com seu ultimo nome, idade e altura (mesma linha): \n>");
            string[] array = Console.ReadLine().Split(' ');

            string lastName = array[0];
            int age = int.Parse(array[1]);
            double height = double.Parse(array[2]);

            Console.WriteLine("\n" + completeName);
            Console.WriteLine(roomQuantity);
            Console.WriteLine(priceProduct.ToString("c"));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);

            Console.ReadKey();
        }
    }
}