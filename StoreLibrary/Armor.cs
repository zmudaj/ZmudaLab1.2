using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Armor : Item
    {
        public int DamageModifier { get; set; }

        public int Resist(int baseDamage)
        {
            var blockedDamage = DamageModifier;

            Console.WriteLine("Use " + Name + " To black " + blockedDamage + " damage.");
            return baseDamage - blockedDamage;
        }
    }
}
