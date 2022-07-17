namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {



            int alcohol = 0;
            int petrol = 0;
            int diesel = 0;
            Console.WriteLine("-----------------------");
            Console.WriteLine(" 1 - Alcool");
            Console.WriteLine(" 2 - Gasolina");
            Console.WriteLine(" 3 - Diesel");
            Console.WriteLine(" 4 - Fim");
            Console.WriteLine("-----------------------");
            Console.Write("\nSelecione o tipo de combustivel desejado: ");
            int type = int.Parse(Console.ReadLine());

            while (type != 4)
            {
                if (type == 1)
                {
                    alcohol = alcohol + 1;
                }
                else if (type == 2)
                {
                    petrol = petrol + 1;
                }
                else if (type == 3)
                {
                    diesel = diesel + 1;
                }
                Console.Write("\nSelecione novamente o tipo de combustivel desejado: ");
                type = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcohol);
            Console.WriteLine("Gasolina: " + petrol);
            Console.WriteLine("Diesel: " + diesel);

            Console.ReadKey();
        }
    }
}