namespace Exercise02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var firstEmployees = new Employees();
            var secondEmployees = new Employees();

            System.Console.WriteLine("Insira os dados do primeiro funcionario:");
            firstEmployees.Name = Console.ReadLine();
            firstEmployees.Salary = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira os dados do segundo funcionario:");
            secondEmployees.Name = Console.ReadLine();
            secondEmployees.Salary = double.Parse(Console.ReadLine());

            double averageSalary = (firstEmployees.Salary + secondEmployees.Salary) / 2;
            System.Console.WriteLine($"Salário médio = {averageSalary.ToString("C")}");
            Console.ReadKey();
        }
    }
}
