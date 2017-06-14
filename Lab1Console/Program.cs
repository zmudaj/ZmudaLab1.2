using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Lab1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20);
            //var shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200);

            //Item.ShowProperties(pick);
            //Item.ShowProperties(shield);

            //var NewStore = new Store();
            //NewStore.AddItemToStore(pick);
            //NewStore.AddItemToStore(shield);

            //foreach(Item thing in NewStore.Items)
            //{
            //    Item.ShowProperties(thing);
            //}

            //NewStore.RemoveItemFromStore(pick);

            //foreach (Item thing in NewStore.Items)
            //{
            //    Item.ShowProperties(thing);
            //}

            //Console.ReadLine();

            Store willysEmporium = new Store("Willy's Emporium");
            Item pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20);
            Item shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200);

            willysEmporium.AddItemToStore(pick);
            willysEmporium.AddItemToStore(shield);

            bool running = true;

            while (running)
            {
                willysEmporium.ViewItems();
                var item = willysEmporium.GetItemByName("Old Rusty");
                willysEmporium.AddItemToCart(item);
                willysEmporium.ViewCart();
                willysEmporium.CalculateCartTotal();
                Console.ReadLine();
                running = false;

            }
        }
    }
}
