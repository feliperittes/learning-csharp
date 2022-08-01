namespace Exercise03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Product product = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();
            Console.Write("Preço: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {product}");

            Console.Write("\nDigite o numero de produtos a ser adcionados: ");
            int qty = int.Parse(Console.ReadLine());
            product.AddProducts(qty);

            Console.WriteLine($"\nDados atualizados {product}");

            Console.Write("\nDigite o numero de produtos a ser removidos: ");
            int qty1 = int.Parse(Console.ReadLine());
            product.RemoveProducts(qty1);

            Console.WriteLine($"\nDados atualizados {product}");
        }
    }
}
