using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Cyclops : Character
    {

        public int EyeOfDoom { get; set; }
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
        public Cyclops() { }
        public Cyclops(int life, string name, int hitChance, int block, int maxLife, int lifeNum, int eyeOfDoom, int minDamage, int maxDamage, string description) : base(life, name, hitChance, block, maxLife, lifeNum)
        {
            EyeOfDoom = eyeOfDoom;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
        }


        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Number of Heads: {EyeOfDoom}\n" +
                $"Min Damage = {MinDamage}" +
                $"Max Damage = {MaxDamage}" +
                $"Description = {Description}";
        }

        public virtual int CalcDamage()
        {
            Random random = new Random();
            int eyeScare = random.Next(1, 9);
            int weaponDamage = random.Next(/*eqweapon*/);
            int damage = eyeScare + weaponDamage;
            return damage;
        }


    }
}
