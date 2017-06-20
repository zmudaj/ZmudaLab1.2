using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Enemy
    {
        public int HitPoints;
        public int Attacks;
        public int AttackSkill;
        public int Damage; // This will be 0 or 1 to indicate normal or strong attack
        public int Actions;

        public int Attack()
        {
            int damage = 0;
            var d6Roll = new DSix();
            for (int i = 0; i < Attacks; i++)
            {
                if (d6Roll.DiceRoll() <= AttackSkill)
                {
                    damage += 1 + Damage; 
                }
            }
            return damage;
        }

    }
}
