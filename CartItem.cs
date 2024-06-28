

namespace TaskMood
{
    public class CartItem
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }
        public CartItem(string name, int quantity, double price)
        {
            Id = ++_id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
