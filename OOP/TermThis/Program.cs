namespace TermThis
{
    class Program
    {
        public static void Main(string[] args)
        {
            Access access = new Access();

            if (access.Login("123"))
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
            Console.ReadKey();
        }
    }
}