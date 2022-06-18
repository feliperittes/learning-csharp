namespace ConstructorMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.name);
            Console.WriteLine(person.lastName);
            Console.WriteLine(person.birthYear);
            Console.WriteLine(person.age);

            Console.WriteLine("\n-----------------------------\n");

            Person person1 = new Person("Felipe", "Fernandes", 2001);

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.lastName);
            Console.WriteLine(person1.birthYear);
            Console.WriteLine(person1.age);

            Console.WriteLine("\n-----------------------------\n");

            Person person2 = new Person("Isaac", "Gerboni");
            Console.WriteLine(person2.name);
            Console.WriteLine(person2.lastName);
            Console.WriteLine(person2.birthYear);
            Console.WriteLine(person2.age);

            Console.ReadKey();
        }
    }
}
