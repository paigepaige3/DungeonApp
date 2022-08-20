using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Banshee : Monster
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

        public string Drawing()
        {
           
            return $@"

         ___--=--------___
        /. \___\____   _, \_      /-\
       /. .  _______     __/=====@
       \----/  |  / \______/      \-/
   _/         _/ o \
  / |    o   /  ___ \
 / /    o\\ |  / O \ /|      __-_
|o|     o\\\   |  \ \ /__--o/o___-_
| |      \\\-_  \____  ----  o___-
|o|       \_ \     /\______-o\_-
| \       _\ \  _/ / |
\o \_   _/      __/ /
 \   \-/   _       /|_
  \_      / |   - \  |\
    \____/  \ | /  \   |\
            | o |   | \ |
            | | |    \ | \
           / | /      \ \ \
         /|  \o|\--\  /  o |\--\
         \----------' \---------'

";
        }
    }
}
