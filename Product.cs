



namespace TaskMood
{
    public class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Stock { get; set; }

        public double Price { get; set; }

        public Product(string name, double price, int stock)
        {
            Id = ++_id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
