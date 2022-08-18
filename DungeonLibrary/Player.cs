using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {

        public WeaponType EquippedWeapon { get; set; }
        public Race Race { get; set; }
        public bool Mood { get; set; }

        public Player() {}

        public Player(int life, string name, int hitChance, int block, int maxLife, int lifeNum, WeaponType equippedWeapon, Race race, bool mood) : base(life,name,hitChance,block,maxLife,lifeNum)
        {
            EquippedWeapon = equippedWeapon;
            Race = race;
            Mood = mood;

        }
        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Weapon: {EquippedWeapon}\n" +
                $"Race = {Race}" +
                $"Mood = {Mood}";
        }

    }
}
