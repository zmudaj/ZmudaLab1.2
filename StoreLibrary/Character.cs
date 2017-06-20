using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Character
    {
        public int Strength;
        public int Dexterity;
        public int Will;

        public int HP;
        public int Focus;
        public int Actions;

        public Weapon PrimaryWeapon;
        public Weapon SecondaryWeapon;
        public Item EquipedArmor;
        public Item ItemHeld;

        public int hands = 2;

        public int Attack(Weapon weapon)
        {
            int relevantWeaponSkill;
            if(weapon.WeaponType == "melee")
                relevantWeaponSkill = Strength;
            else if(weapon.WeaponType == "ranged")
                relevantWeaponSkill = Dexterity;
            else
                relevantWeaponSkill = Will;
            int damage = 0;
            var d6Roll = new DSix();
            for (int i = 0; i < weapon.AttackRolls; i++)
            {
                if(d6Roll.DiceRoll() <= relevantWeaponSkill)
                {
                    damage++;
                }
            }
            return damage;
        }

    }
}
