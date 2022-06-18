namespace Properties 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            test.Name = "Felipe";
            test.Age = 25;

            Console.WriteLine($"{test.Name} {test.LastName}");
            Console.WriteLine($"{test.Age}");

            Console.ReadKey();
        }
    }
}
