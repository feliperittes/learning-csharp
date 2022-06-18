using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract public class Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; } // Altura
        public int Width { get; set; } // Largura
        public int Ray { get; set; } // Raio

        public virtual void Draw() // Desenhar // "virtual" seu comportamento pode ser alterado
        {
            Console.WriteLine("Preparing to draw!"); // Preparando-se para desenhar
        }
        public virtual void Area()
        {
            int area = Height * Width;
        }
    }
    public class Circle : Form // Classe Circulo
    {
        public override void Draw() // Desenhar //virtual seu comportamento pode ser alterado
        {
            base.Draw(); // base = reapoveitar o codigo da classe base 
            Console.WriteLine("Drawing Circle!");
        }
        public override void Area()
        {
            double area = 3.14 * (Ray * Ray);
            Console.WriteLine($"Circle area: {area}");
        }
    }
    public class Rectangle : Form
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle!");
            base.Draw(); // base = reapoveitar o codigo da classe base
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine($"Rectangle area: {Area}");
        }
    }
    public class Triangle : Form
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle!");
            base.Draw(); // base = reapoveitar o codigo da classe base
        }
        public override void Area()
        {
            int area = (Width * Height) / 2;
            Console.WriteLine($"Triangle area: {area}");
        }
    }
}
