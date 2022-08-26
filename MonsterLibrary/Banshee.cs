using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public sealed class Banshee : Monster
    {

        public int Scary { get; set; }
        public string Description { get; set; }
        public Banshee() { }

        public Banshee(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, int scary, string description) : base(name, life, maxLife,hitChance,block,maxDamage,minDamage,description)
        {
            Scary = scary;
            Description = description;
        }


        public override int CalcBlock()
        {
            Random random = new Random();
            Block = random.Next(1, 5);
            return Block;
        }

        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Scary Factor: {Scary}\n" +
                $"Description: {Description} \n\n";

        }

       
    }
}
