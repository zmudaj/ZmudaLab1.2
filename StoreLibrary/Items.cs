using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Item
    {
        public string Name;
        public string Description;
        public decimal Price;

        public Item(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public static void ShowProperties(Item item)
        {
            Console.WriteLine("{0}: {1} Price: {2}", item.Name, item.Description, item.Price);
        }
    }

    public class Store
    {
        public List<Item> Items;
        public List<Item> Cart;
        public string Name;

        public Store(string name)
        {
            Name = name;
            Items = new List<Item>();
            Cart = new List<Item>();
        }

        // This method will allow you to add an item to the List of Items
        public void AddItemToStore(Item item)
        {
            Items.Add(item);
        }

        // This method should remove an item from the list of Items
        public void RemoveItemFromStore(Item item)
        {
            Items.Remove(item);
        }

        // This method will allow you to add an item from the Items list to the Cart
        public void AddItemToCart(Item item)
        {
            Cart.Add(item);
        }

        // This method should remove an item from the Cart
        public void RemoveItemFromCart(Item item)
        {
            Cart.Remove(item);
        }

        // This method should calculate the total price of the items in the cart
        public decimal CalculateCartTotal()
        {
            decimal total = 0;

            foreach(Item thing in Cart)
            {
                total += thing.Price;
            }
            return total;
        }

        public void ViewItems()
        {
            // This method should log All of the items in the store to the screen
            foreach (Item thing in Items)
            {
                Item.ShowProperties(thing);
            }
        }
        public void ViewCart()
        {
            // This method will log all the items in the cart and show the total price of the items in the cart
            foreach (Item thing in Cart)
            {
                Item.ShowProperties(thing);
            }
        }

        public Item GetItemByName(string name)
        {
            // This method should search the given list of items for an item by its name
            // If the item is found return the Item
            // You could handle case sensitivity here
            return Items.FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }
    }
}
    
       
