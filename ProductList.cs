



namespace TaskMood
{
    public class ProductList
    {
        private static int _id;
        public int Id { get; set; }
        public Product[] products;
        public Product this[int index]
        {
            get
            {
                return products[index];
            }
            set
            {
                products[index] = value;
            }
        }
        public ProductList()
        {
            products = new Product[0];
            Id = ++_id;
        }
        public void Add(Product product)
        {

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }
        public void Remove(int id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id == id)
                {
                    for (int j = i; j < products.Length; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    Array.Resize(ref products, products.Length - 1);
                    break;
                }

            }
            Console.WriteLine("Product not found...");
        }

        public Product FindById(int id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Id == id)
                {
                    return products[i];
                }
            }
            return null;
        }
    }
}
