using System.Globalization;
namespace Exercise07
{
    class Program
    {
        public static void Main(string[] args)
        {
            double incomeTax;
            Console.WriteLine("Insira o salário");
            double salary = double.Parse(Console.ReadLine());
            
            if (salary <= 2000.0)
            {
                incomeTax = 0.0;
            }
            else if (salary <= 3000.0)
            {
                incomeTax = (salary - 2000.0) * 0.08;
            }
            else if (salary <= 4500.0)
            {
                incomeTax = (salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                incomeTax = (salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (incomeTax == 0.0)
            {
                Console.WriteLine("ISENTO!");
            }
            else
            {
                Console.WriteLine($"{incomeTax.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            }

            Console.ReadKey();
        }
    }
}

