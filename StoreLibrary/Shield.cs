using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    // Update shield to roll a D6, ignoring the attack if roll =< Shieldstrength
    public class Shield : Item
    {
        public int ShieldStrength { get; set; }

        public int Block(int baseDamage)
        {
            var blockedDamage = ShieldStrength;
            // Roll D6 here. If result is =< ShieldStrength, take no damage
            var d6Roll = new DSix();
            var shieldRoll = d6Roll.DiceRoll();
            // ConsoleLog shieldRoll for debugging
            Console.WriteLine("You roll a " + shieldRoll + " with your shield!");
            if (shieldRoll <= ShieldStrength)
            {
                baseDamage = 0;
                Console.WriteLine("Use " + Name + " to block the attack!");
            }
            return baseDamage;
        }
    }
}
