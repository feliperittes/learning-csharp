namespace CalculateBMI
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calcular IMC");
            Console.Write("\nInforme o peso em Kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double height = double.Parse(Console.ReadLine());

            double valueBMI = weight / (height * height);

            Console.WriteLine($"O IMC é {valueBMI}");

            if (valueBMI < 20)
            {
                Console.WriteLine("MAGREZA");
            }
            else if (valueBMI >= 20 && valueBMI <= 24)
            {
                Console.WriteLine("NORMAL");
            }
            else if (valueBMI >= 25 && valueBMI <= 29)
            {
                Console.WriteLine("SOBREPESO");
            }
            else if (valueBMI >= 30 && valueBMI <= 34)
            {
                Console.WriteLine("OBESIDADE");
            }
            else
            {
                Console.WriteLine("OBESIDADE GRAVE");
            }

            Console.ReadKey();
        }
    }
}
