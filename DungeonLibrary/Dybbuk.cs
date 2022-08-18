using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Dybbuk : Character
    {
        public int Spooky { get; set; }
        public int MinDamage
        {
            get { return MinDamage; }
            set
            {
                if (value > 0)
                {
                    MinDamage = value;
                }
                else
                {
                    MaxDamage = value;
                }
            }
        }
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public Dybbuk() { }
        public Dybbuk(int life, string name, int hitChance, int block, int maxLife, int lifeNum, int spooky, int minDamage, int maxDamage, string description) : base(life, name, hitChance, block, maxLife, lifeNum)
        {
            Spooky = spooky;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }


        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Number of Heads: {Spooky}\n" +
                $"Min Damage = {MinDamage}" +
                $"Max Damage = {MaxDamage}" +
                $"Description = {Description}";
        }

        public virtual int CalcDamage()
        {
            Random random = new Random();
            int spookiness = random.Next(1, 5);
            int weaponDamage = random.Next(/*eqweapon*/);
            int damage = spookiness + weaponDamage;
            return damage;
        }


    }
}
