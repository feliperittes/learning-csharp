namespace Statics
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Classe Estática
            //Mathematics.rate = 10;

            //int value1 = Mathematics.Add(200);
            //int value2 = Mathematics.Decrease(155);

            //Console.WriteLine($"Value 1: {value1}");
            //Console.WriteLine($"Value 2: {value2}");
            #endregion

            Person.AgeMajority = 20;

            Person person = new Person();

            person.name = "Felipe";
            person.age = Person.CalculateAge(2001);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(Person.AgeMajority);
            
            Console.ReadKey();
        }
    }
}