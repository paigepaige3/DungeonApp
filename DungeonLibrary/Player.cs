using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {

        public Weapon EquippedWeapon { get; set; }
        private Mood _characterMood;
        private Race _characterRace;
        private Mood CharacterMood
        {
            get { return _characterMood; }
            set { _characterMood = value; }
        }
        public Race CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
        }

        public Player() { }

        public Player(string name,Mood characterMood, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon)
            : base(name, hitChance, block, maxLife, life)
        {
            CharacterMood = characterMood;
            EquippedWeapon = equippedWeapon;
            CharacterRace = characterRace;

            switch (CharacterRace)
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
                switch (CharacterMood)
            {
                case Mood.Sad:

                    break;
                case Mood.Angry:
                    HitChance += 10;
                    Block += 5;
                    break;
                case Mood.Happy:
                    Block += 5;
                    HitChance += 5;
                    break;
                case Mood.Energized:
                    MaxLife += 10;
                    Life += 1;
                    break;
                case Mood.Sleepy:
                    MaxLife -= 5;
                    break;
                case Mood.Grumpy:
                    HitChance += 5;
                    Block += 5;
                    break;
            }



        }
        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Gobblin:
                    description = "Orc";
                    break;
                case Race.Leprechaun:
                    description = "Human";
                    break;
                case Race.Gnomes:
                    description = "Elf";
                    break;
                case Race.Dragon:
                    description = "Dwarf";
                    break;
                case Race.Ogre:
                    description = "Dwarf";
                    break;
                case Race.Minotaur:
                    description = "Dwarf";
                    break;
                case Race.Golems:
                    description = "Dwarf";
                    break;
                default:
                    break;
            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" +
                                      description;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
        public override int CalcDamage()
        {
            // return base.CalcDamage();   

            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;


        }

    }
}
