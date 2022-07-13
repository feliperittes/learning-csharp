namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite digite o codigo do produto e a quantidade desejada(mesma linha separe com a tecla espaço):\n> ");
            string[] array = Console.ReadLine().Split(' ');
            int code = int.Parse(array[0]);
            int quantity = int.Parse(array[1]);

            double hotDog = 4.00;
            double xSalad = 4.50;
            double xBacon = 5.00;
            double simpleToast = 2.00;
            double softDrink = 1.50;


            if (code == 1)
            {
                Console.WriteLine($"Total a pagar: {(hotDog * quantity).ToString("C")}");
            }
            else if (code == 2)
            {
                Console.WriteLine($"Total a pagar: {(xSalad * quantity).ToString("C")}");
            }
            else if (code == 3)
            {
                Console.WriteLine($"Total a pagar: {(xBacon * quantity).ToString("C")}");
            }
            else if (code == 4)
            {
                Console.WriteLine($"Total a pagar: {(simpleToast * quantity).ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Total a pagar: {(softDrink * quantity).ToString("C")}");
            }

            Console.ReadKey();
        }
    }
}
