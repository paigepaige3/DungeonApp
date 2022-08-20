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

        public Weapon EquippedWeapon { get; set; }
        public Race Race { get; set; }
        public bool Mood { get; set; }

        public Player() { }

        public Player(int life, string name, int hitChance, int block, int maxLife, int lifeNum, Weapon equippedWeapon, Race race, bool mood) : base(life, name, hitChance, block, maxLife, lifeNum)
        {
            EquippedWeapon = equippedWeapon;
            Race = race;
            Mood = mood;
            switch (Race)
            {
                //Warning: Numbers DO NOT FOLLOW LORE
                case Race.Gobblin:
                    Life += 10;
                    Block += 2;
                    break;
                case Race.Leprechaun:
                    Block += 3;
                    HitChance += 5;
                    break;
                case Race.Gnomes:
                    MaxLife += 5;
                    Life += 5;
                    Block += 5;
                    break;
                case Race.Dragon:
                    HitChance += 5;
                    Block += 2;
                    Life += 7;
                    break;
                case Race.Ogre:
                    HitChance += 5;
                    break;
                    MaxLife += 10;
                case Race.Minotaur:
                    HitChance += 5;
                    break;
                case Race.Golems:
                    break;
            }
            switch (mood)
            {
                default:
                    break;
            }

        }
        public override string ToString()
        {
            return base.ToString() + $"" +
                $"Weapon: {EquippedWeapon}\n" +
                $"Race = {Race}" +
                $"Mood = {Mood}";
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}
