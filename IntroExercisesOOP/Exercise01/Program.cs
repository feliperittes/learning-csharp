namespace Exercise01
{
    class Prgram
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var firstPerson = new People();
            var secondPerson = new People();
            System.Console.WriteLine("Insira dos dados da primeira pessoa:");
            firstPerson.Name = Console.ReadLine();
            firstPerson.Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira dos dados da segunda pessoa:");
            secondPerson.Name = Console.ReadLine();
            secondPerson.Age = int.Parse(Console.ReadLine());

            if (firstPerson.Age > secondPerson.Age)
            {
                System.Console.WriteLine($"Pessoa mais velha: {firstPerson.Name}.");
            }
            else
            {
                System.Console.WriteLine($"Pessoa mais velha: {secondPerson.Name}.");
            }
            Console.ReadKey();
        }
    }
}