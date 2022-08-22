using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Cyclops : Monster
    {
        public int EyeOfDoom { get; set; }
        public string Description { get; set; }

        public Cyclops() { }
        public Cyclops(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, int eyeOfDoom, string description) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            EyeOfDoom = eyeOfDoom;
            Description = description;
        }
        public override int CalcBlock()
        {
            Random random = new Random();
            Block = random.Next(1, 7);
            return Block;
        }
        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Eye of Doom: {EyeOfDoom}\n" +
                $"Description: {Description}\n\n";
        }
    }
}
