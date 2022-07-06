namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            int partCode1 =  int.Parse(Console.ReadLine());
            int valueQuantity1 =  int.Parse(Console.ReadLine());
            double partValue1 =  double.Parse(Console.ReadLine());

            int partCode2 = int.Parse(Console.ReadLine());
            int valueQuantity2 = int.Parse(Console.ReadLine());
            double partValue2 = double.Parse(Console.ReadLine());

            double amountPayable = ((valueQuantity1 * partValue1) + (valueQuantity2 * partValue2));
            Console.WriteLine($"VALOR A PAGAR = {amountPayable.ToString("C")}");

            Console.ReadKey();
        }
    }
}

