using System.Collections.Generic;
using System.Linq;

namespace PizzaProject.Models
{
    public class Cart
    {
        public List<Item> Items { get; set; }

        public Cart()
        {
            Items = new List<Item>();
        }

        public void AddItem(Pizza newPizza)
        {
            var item = Items.FirstOrDefault(t => t.Pizza.Id == newPizza.Id);

            if (item is null)
            {
                item = new Item()
                {
                    Pizza = newPizza,
                    Count = 1
                };

                Items.Add(item);
            }
            else
            {
                item.Count++;
            }
        }

        public void RemoveItem(Pizza remPizza)
        {
            var pizza = Items.FirstOrDefault(t => t.Pizza.Id == remPizza.Id);

            if (pizza != null)
            {
                pizza.Count--;

                if (pizza.Count <= 0)
                {
                    Items.Remove(pizza);
                }
            }
        }

        public void ClearCart()
        {
            Items.Clear();
        }

        public class Item
        {
            public Pizza Pizza { get; set; }
            public int Count { get; set; }
        }
    }
}
