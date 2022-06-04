using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe bodyArmor;
        private Staff weapon;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 1 && value <= 20)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public Mage()
        {

        }

        public void ArcaneWealth()
        {

        }
        public void Firewall()
        {

        }
        public void Meditation()
        {

        }
    }
}
