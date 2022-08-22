using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Hydra : Monster
    {
        public int NumberOfHeads { get; set; }
        public string Description { get; set; }
        public Hydra() { }
        public Hydra(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, int numberOfHeads, string description) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            NumberOfHeads = numberOfHeads;
            Description = description;
        }
        public override int CalcBlock()
        {
            Random random = new Random();
            Block = random.Next(2, 5);
            return Block;
        }
        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Number of Heads: {NumberOfHeads}\n" +
                $"Description: {Description} \n\n";


        }
    }
}
