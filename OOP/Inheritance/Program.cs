namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Part 1
            //Car car = new Car();
            //Bike bike = new Bike();
            //PickupTruck truck = new PickupTruck();

            //car.Accelerate();
            //bike.Stop();
            //truck.Stop();
            #endregion

            Human human = new Human();    
            Person person = new Person();   
            Man man = new Man();
            Console.WriteLine("\nHuman:");
            human.Eyes();
            human.Hairs();
            Console.WriteLine("\nHuman:");
            person.Eyes();
            person.Hairs();
            Console.WriteLine("\nMan:");
            man.Eyes();
            man.Hairs();

            Console.ReadKey();
        }
    }
}
