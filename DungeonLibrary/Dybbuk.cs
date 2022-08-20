using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Dybbuk : Monster
    {
        public int Spooky { get; set; }
        public string Description { get; set; }

        public Dybbuk() { }
        public Dybbuk(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, int spooky, string description) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Spooky = spooky;
            Description = description;
        }


        public override int CalcBlock()
        {
            Random random = new Random();
            Block = random.Next(2, 9);
            return Block;
        }

        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Eye of Doom: {Spooky}\n" +
                $"Description: {Description}\n\n";
        }

    }
}
