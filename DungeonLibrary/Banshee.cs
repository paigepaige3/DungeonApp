using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Banshee : Character
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

        public virtual int Damage()
        {
            Random random = new Random();
            int scary = random.Next(1, 5);
            int damage = scary * 2;
            return damage;
        }
    }
}
