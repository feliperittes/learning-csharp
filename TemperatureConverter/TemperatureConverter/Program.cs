namespace TemperatureConverter
{
    class Prgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperaturas");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Insira a temperatura em Celcius: ");
            double C = double.Parse(Console.ReadLine());

            double F = (C * 9 / 5) + 32;
            double K = C + 273.15;

            Console.WriteLine($"{C} graus Celcius = {F} graus Kahrenheit");
            Console.WriteLine($"{C} graus Celcius = {K} graus Kelvin");
            Console.WriteLine("------------------------------------------------");
            Console.ReadKey();
        }
    }
}
