using System.Globalization;
namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 21;
            int code = 9856;
            char gender = 'M';

            double price1 = 2100.00;
            double price2 = 650.00;
            double measure = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{product1}, cujo o preço é {price1.ToString("C")}");
            Console.WriteLine($"{product2}, cujo o preço é {price2.ToString("C")}");

            Console.WriteLine($"\n{age} anos de idade, código {code} e gênero: {gender}");

            Console.WriteLine($"\nMedida com oito casas decimais: {measure.ToString("F8", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            Console.WriteLine($"Arredondado (três casas decimais): {measure.ToString("F3", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            Console.WriteLine($"Separador decimal invariant culture: {measure.ToString("F3")}");

            Console.ReadKey();
        }
    }
}