namespace Modifiers //Modificadores
{   
    class Program
    {
        public static void Main(string[] args)
        {
            Test test = new Test();
            //test.name = "";
            test.lastName = "";
            //test.Method1();
            test.Perform(); // perfgorm == executar

            Man man = new Man();
            man.age = 21;
        }
    }
}
