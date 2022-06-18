namespace Polymorphism
{
    //Polimorfismo todo são do mesmo tipo, mas cada um vai se comportar de uma forma diferente, conforme a sua instancia
    class Program
    {
        public static void Main(string[] args)
        {
            //Form a = new Form();
            Form b = new Triangle();
            Form c = new Circle();
            Form d = new Rectangle();

            //Console.WriteLine("Form");
            //a.Draw();

            Console.WriteLine("\nTriangle");
            b.Draw();
            Console.WriteLine("\nCircle");
            c.Draw();
            Console.WriteLine("\nRectangle");
            d.Draw();

            Console.ReadKey();
        }
    }
}