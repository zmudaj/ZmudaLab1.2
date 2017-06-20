using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    class Player
    {
        public string Name;
        public int Health;
        List<Item> Inventory; // You will need to add the inventory onto the player.
        Sword EquipedSword; // The sword that the player has equiped.
        Shield EquipedShield; // The Shield that the player has equiped.

        public void Attack(Player player)
        {
            if(player.EquipedSword != null)
            {
                player.EquipedSword.Attack();
            }
            else
            {
                Console.WriteLine("Player Has no Sword... Throws punch instead. Deal: 1 damage.");
            }
        }

        public void OnAttacked(Player player)
        {
            if (player.EquipedShield != null)
            {
                player.Health -= player.EquipedShield.Block(10);
            }
            else
            {
                player.Health -= 10;
            }
        }

        public void EquipSword(Player player, Sword sword)
        {
            player.EquipedSword = sword;
        }

        public void EquipShield(Player player, Shield shield)
        {
            player.EquipedShield = shield;
        }
    }
}
