using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Banshee : Character
    {

        public int Scary { get; set; }
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
        public Banshee() { }
        public Banshee(int life, string name, int hitChance, int block, int maxLife, int lifeNum, int scary, int minDamage, int maxDamage, string description) : base(life, name, hitChance, block, maxLife, lifeNum)
        {
            Scary = scary;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }


        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Number of Heads: {Scary}\n" +
                $"Min Damage = {MinDamage}" +
                $"Max Damage = {MaxDamage}" +
                $"Description = {Description}";
        }

        public virtual int CalcDamage()
        {
            Random random = new Random();
            int scary = random.Next(1, 5);
            int weaponDamage = random.Next(/*eqweapon*/);
            int damage = scary + weaponDamage;
            return damage;
        }

    }
}
