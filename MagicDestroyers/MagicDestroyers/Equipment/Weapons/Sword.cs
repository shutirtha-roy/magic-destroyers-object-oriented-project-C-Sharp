using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Bloogthrist()
        {

        }
    }
}
