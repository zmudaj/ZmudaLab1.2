using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Sword : Item
    {
        public int Damage { get; set; }
        public void Attack()
        {
            Console.WriteLine("Swing " + Name + " deal " + Damage + " damage.");
        }
    }
}
