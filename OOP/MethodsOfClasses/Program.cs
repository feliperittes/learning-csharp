namespace MethodsOfClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            Methods method = new Methods();
            #region Métodos Simples
            //method.Greet();
            #endregion

            #region Métodos com parâmetros
            //method.Sum(5, 6);
            //method.Show("Felipe", 21);
            #endregion

            #region Passagem de parâmetros por valor e por referêcia
            //int value1 = 100;
            //int value2 = 100;

            //method.IncreaseValue(value1);
            //method.IncreaseRef(ref value2);

            //Console.WriteLine($"value 1: {value1}");
            //Console.WriteLine($"value 1: {value2}");
            #endregion

            #region Métodos com retorno de valores
            //string completeName = method.AssembleName("Felipe", "Fernades");
            //int charCode = method.CharCode('a');
            //double pi = method.ValuePI();

            //Console.WriteLine(completeName);
            //Console.WriteLine(charCode);
            //Console.WriteLine(pi);
            #endregion

            method.Greet();
            method.Greet("Felipe");
            method.Greet("Felipe", 21);

            var res1 = method.Compare(100, 50 * 2);
            var res2 = method.Compare("Felipe", "felipe");

            Console.WriteLine(res1);
            Console.WriteLine(res2);


            Console.ReadKey();
        }
    }
}