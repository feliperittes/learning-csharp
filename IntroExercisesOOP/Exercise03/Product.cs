namespace Exercise03
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double TotalStockValue()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("C")}, {Quantity} unidades, Total: {TotalStockValue().ToString("C")}";
        }
    }
}