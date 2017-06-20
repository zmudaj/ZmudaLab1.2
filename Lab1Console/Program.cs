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

            Store willysEmporium = new Store("Willy's Emporium");
            Item pick = new Item("Old Rusty", "A well worn pick it doesn't look like this would last long", 20);
            Item shield = new Item("Knight's Shield", "A nice looking shield with an unknown emblem", 200);

            willysEmporium.AddItemToStore(pick);
            willysEmporium.AddItemToStore(shield);

            // To instantiate the sword...
            var magicSword = new Sword
            {
                Name = "Magic Sword",
                Description = "Master using it and you can have it.",
                Price = 30,
                Damage = 70
            };

            magicSword.Attack();

            var basicShield = new Shield
            {
                ShieldStrength = 6,
                Description = "Provides 10% Extra Defense",
                Name = "Basic Shield",
                Price = 10,
            };

            basicShield.Block(100);

            bool running = true;

            while (running)
            {
                willysEmporium.ViewItems();
                var item = willysEmporium.GetItemByName("Old Rusty");
                willysEmporium.AddItemToCart(item);
                willysEmporium.ViewCart();
                willysEmporium.CalculateCartTotal();
                //Console.ReadLine();
                running = false;

            }
            // Start of my game portion
            Console.Clear();
            Console.WriteLine();
            var Zombie1 = new Enemy()
            {
                HitPoints = 2,
                Attacks = 1,
                AttackSkill = 2,
                Damage = 0,
                Actions = 1
            };
            var Zombie2 = new Enemy()
            {
                HitPoints = 2,
                Attacks = 1,
                AttackSkill = 2,
                Damage = 0,
                Actions = 1
            };

            List<Item> ItemsInRoom = new List<Item>();

            Weapon Handgun = new Weapon()
            {
                Name = "Handgun",
                WeaponType = "ranged",
                AttackRolls = 2,
                HandsRequiredToWield = 1,
                BonusDamage = 0
            };
            ItemsInRoom.Add(Handgun);

            Weapon SledgeHammer = new Weapon()
            {
                Name = "Sledge Hammer",
                WeaponType = "melee",
                AttackRolls = 2,
                HandsRequiredToWield = 2,
                BonusDamage = 1
            };
            ItemsInRoom.Add(SledgeHammer);

            Armor ThickCoat = new Armor()
            {
                Name = "Thick Coat",
                DamageModifier = 1
            };
            ItemsInRoom.Add(ThickCoat);

            var StartingText = new Narrative();
            Console.WriteLine(StartingText.Intro);
            Console.WriteLine();
            Console.WriteLine("The room contains: ");
            foreach(var item in ItemsInRoom)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("You only have time to grab one thing.");

            Console.ReadLine();
            //var choices = 2;
            //Console.Clear();
                Console.WriteLine("What do you grab?");
                for(int j = 1; j < ItemsInRoom.Count + 1; j++)
                {
                    Console.WriteLine(j + " " + ItemsInRoom[j - 1].Name);
                }
                string ItemChose = Console.ReadLine();

                //Console.WriteLine(ItemChose);
                Console.ReadLine();
            
        }

    }
}
