﻿using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //fields
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //props
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                
                _life = value <= MaxLife ? value : MaxLife;
            }
        }


        public Character()
        {

        }

        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }

        public override string ToString()
        {
            return string.Format($"-=-=-=-=-=-=-=-=-\n" +
                $"" +
                $"{Name}\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {CalcHitChance}%\n " +
                $"Block: {Block}\n" +
                $"-=-=-=-=-=-=-=-=-");
        }
        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
    }

}