namespace ClassesObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Classes and Objects

            //MyClass myClass = new MyClass();
            //MyClass myClass1 = new MyClass();

            //OtherClass otherClass = new OtherClass();
            //OtherClass myOtherClass = otherClass; // vai receber a referencia do objeto "otherClass", não recebe o valor mas sim a referencia
            #endregion

            Person firstPerson = new Person();
            firstPerson.name = "Marcurinha";
            firstPerson.lastName = "Diegues";
            firstPerson.BirthYear = 2004;

            Person secondPerson = new Person()
            {
                name = "Isaac",
                lastName = "Gerboni",
                BirthYear = 2000
            };

            Console.WriteLine($"First person name: {firstPerson.name}");
            Console.WriteLine($"First person's last name: {firstPerson.lastName}");
            Console.WriteLine($"First person birth year: {firstPerson.BirthYear}");
            firstPerson.Greet();


            Console.WriteLine($"\nSecond person name: {secondPerson.name}");
            Console.WriteLine($"Second person's last name: {secondPerson.lastName}");
            Console.WriteLine($"Second person birth year: {secondPerson.BirthYear}");
            secondPerson.Greet();


            Console.ReadKey();
        }
    }

    class MyClass
    {

    }
}