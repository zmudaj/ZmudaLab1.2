using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    class DSix
    {
        public int DiceRoll()
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            return result;
        }
    }
}
