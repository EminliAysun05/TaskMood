

namespace TaskMood
{
    public class CartItemList
    {
      
        
        public CartItem[] items;
        public CartItem this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
        public CartItemList()
        {
            
            items = new CartItem[0];
        }

        public void Add(CartItem item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;

        }

        public bool IsExist(int id)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public CartItem FindById(int id)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Id == id)
                {
                    return items[i];
                }
            }
            return null;
        }
    }
}
