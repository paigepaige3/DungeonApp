using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Hydra : Character
    {
        public int NumberOfHeads { get; set; }
        public int MinDamage
        { 
            get { return MinDamage; }
            set 
            {
                if (value > 0 )
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

        public Hydra(int life, string name, int hitChance, int block, int maxLife, int lifeNum, int numberOfHeads, int minDamage, int maxDamage, string description) : base(life,name, hitChance,block,maxLife,lifeNum)
        {
            NumberOfHeads = numberOfHeads;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }


        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Number of Heads: {NumberOfHeads}\n" +
                $"Min Damage = {MinDamage}" +
                $"Max Damage = {MaxDamage}" +
                $"Description = {Description}";
        }

        public virtual int Damage()
        {
            Random random = new Random();
            int numberOfHeads = random.Next(1, 6);
            int damage = numberOfHeads * 2;
            return damage;
        }


    }
}
