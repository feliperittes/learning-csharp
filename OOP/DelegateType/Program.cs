namespace DelegateType
{
    class Program
    {
        delegate void Operation(int num1, int num2);
        public static void Main(string[] args)
        {
            Mathematics mathematics = new Mathematics();

            Operation operation = null;

            operation += mathematics.Sum;
            operation += mathematics.Subtract;
            operation += mathematics.Multiply;
            operation += mathematics.Divide;
            operation += mathematics.Multiply;

            operation(10,2);

            Console.WriteLine("\n---------------------------\n");

            operation -= mathematics.Divide;
            operation -= mathematics.Subtract;


            operation(15, 3);

           Console.ReadKey();
        }
    }
}