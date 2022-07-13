namespace Exercise05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o codigo da peça 1, o numero de peças 1, o valor unitário de cada peça 1:\n>");
            string[] array = Console.ReadLine().Split(' ');
            int partCode1 =  int.Parse(array[0]);
            int valueQuantity1 =  int.Parse(array[1]);
            double partValue1 =  double.Parse(array[2]);

            Console.Write("\nInsira o codigo da peça 2, o numero de peças 2, o valor unitário de cada peça 2:\n>");
            string[] array1 = Console.ReadLine().Split(' ');
            int partCode2 = int.Parse(array1[0]);
            int valueQuantity2 = int.Parse(array1[1]);
            double partValue2 = double.Parse(array1[2]);

            double amountPayable = ((valueQuantity1 * partValue1) + (valueQuantity2 * partValue2));
            Console.WriteLine($"\nVALOR A PAGAR = {amountPayable.ToString("C")}");

            Console.ReadKey();
        }
    }
}

