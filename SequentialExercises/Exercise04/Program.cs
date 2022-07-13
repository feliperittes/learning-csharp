namespace Exercise04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira o numero do funcionario: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Insira o numero de horas trabalhadas: ");
            double hoursWorked = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor recebido por hora trabalhada: ");
            double valueHoursWorked = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = {(hoursWorked * valueHoursWorked).ToString("C")}");

            Console.ReadKey();
        }
    }
}
