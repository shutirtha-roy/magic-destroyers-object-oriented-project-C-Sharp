using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        private string name;
        private int level;
        private int healthPoints;
        private int abilityPoints;
        private string faction;
        private LightLeatherVest bodyArmor;
        private Staff weapon;

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
                if (value >= 0 && value <= 21)
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
                if (value >= 0 && value <= 20)
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
                if (value >= 1 && value <= 30)
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
        public Staff Weapon
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

        public Druid()
            : this("Farhan", 1)
        {

        }
        public Druid(string name, int level)
            : this(name, level, 12)
        {

        }
        public Druid(string name, int level, int healthPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 17;
            this.Faction = "Spellcasters";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Staff();
        }
        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
        {

        }
    }
}
