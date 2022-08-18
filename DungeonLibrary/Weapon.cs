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
        private int _bonusHitChance;
        private bool _isTwoHanded;


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


        //collect
        public Weapon(int minDamage, int maxDamage, WeaponType weaponName, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            WeaponName = weaponName;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
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
                "Two Handed: {5}" 
             
                ,
                MinDamage,
                MaxDamage,
                WeaponName,
                BonusHitChance,
                IsTwoHanded

                );
        }

    }
}
