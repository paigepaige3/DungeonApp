using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private int _maxDamage;
        private int _minDamage;
        private WeaponType _weaponName;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private int _randomDamage;

        //props

        public int MaxDamage
        {
            get { return _maxDamage; }
            set
            {
                if (value > 0)
                {
                    _maxDamage = value;
                }
                else
                {
                    _maxDamage = 1;
                }
            }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value >= 0)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public WeaponType WeaponName
        { get; set; }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set
            {
                if (value > 0)
                {
                    _bonusHitChance = value;
                }
                else
                {
                    _bonusHitChance = 1;
                }
            }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        private int RandomDamage
        {
            get { return _randomDamage; }
            set
            {
                if (value > 0)
                {
                    _randomDamage = value;
                }
                else
                {
                    _randomDamage = 1;
                }
            }
        }
        //collect
        public Weapon(int minDamage, int maxDamage, WeaponType weaponName, int bonusHitChance, bool isTwoHanded, int randomDamage)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            WeaponName = weaponName;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            RandomDamage = randomDamage;
        }
        public Weapon()
        {

        }
        public override string ToString()
        {
            return string.Format("" +
                "Min Damage: {0}" +
                "Max Damage: {1}" +
                "Name: {3}" +
                "Bonus Hit Chance: {4}" +
                "Two Handed: {5}" +
                "Total Damage: "
                ,
                MinDamage,
                MaxDamage,
                WeaponName,
                BonusHitChance,
                IsTwoHanded,
                RandomDamage
                );
        }
        public static int testDamage(Weapon damage)
        {
            Random rand = new Random();
            int number = rand.Next(1, 15);
            return damage.RandomDamage = number;

        }
    }
}
