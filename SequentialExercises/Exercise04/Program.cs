namespace Exercise04
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double hoursWorked = double.Parse(Console.ReadLine());
            double valueHoursWorked = double.Parse(Console.ReadLine());

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = {(hoursWorked * valueHoursWorked).ToString("C")}");

            Console.ReadKey();
        }
    }
}
