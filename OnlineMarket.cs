

namespace TaskMood
{
    internal class OnlineMarket
    {
        public class Employee
        {
            //    public string Name { get; set; }
            //    public int Age { get; set; }

            //    public string ShowInfo()
            //    {
            //        return $"Name: {Name}, Age: {Age}";
            //    }
            //}


            //public string Name { get; set; }
            //public int EmployeeLimit { get; set; }

            //public Employee[] Employees;

            //public Employee this[int index]
            //{
            //    get { return Employees[index]; }
            //    set { Employees[index] = value; }
            //}

            //public OnlineMarket()
            //{
            //    Employees = new Employee[EmployeeLimit]; // Burada limitləyə bilərsiniz

            public string Name { get; set; }
            public int Id { get; set; }
            public Employee(string name)
            {
               Name = name;
            }
            public void AddToCart(int id, double price)
            {

            }
            public CartItemList[] Cart;
            public ProductList[] Products;
            public void AddToCart(int productId, int quantity)
            {
                Product product = Products.FindById(productId);
                if (product != null && product.Stock >= quantity)
                {
                    Cart.Add(product, quantity);
                    product.Stock -= quantity;
                }
                else
                {
                    Console.WriteLine("Product not available or insufficient stock.");
                }
            }
        }
    }
}
