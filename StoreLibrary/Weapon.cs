using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Weapon : Item
    {
        public string WeaponType;

        public int AttackRolls;
        public int HandsRequiredToWield;
        public int Range;

        public int BonusDamage;
        public bool IsAccurate;
        public bool IsHeavy;

        public int BlockStrength;
    }
}
