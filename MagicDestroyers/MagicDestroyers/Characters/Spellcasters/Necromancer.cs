using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        private string name;
        private int level;
        private int healthPoints;
        private int abilityPoints;
        private string faction;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
                if (value >= 0 && value <= 16)
                {
                    level = value;
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
                if (value >= 0 && value <= 70)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (faction == "Melee" || faction == "SpellCasters")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "The faction should be Melee or SpellCasters");
                }
            }
        }
        public LightLeatherVest BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Necromancer()
            : this("Abrar", 1)
        {

        }
        public Necromancer(string name, int level)
            : this("Sefat", 1, 65)
        {
        }
        public Necromancer(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 5;
            this.Faction = "Spellcasters";
            this.bodyArmor = new LightLeatherVest();
            this.weapon = new Sword();
        }


        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneSheild()
        {

        }
    }
}
