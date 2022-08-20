using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace DungeonLibrary
{
    public class Character
    {
        //fields
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        private int _lifeNum;

        //props
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= _maxLife)
                {
                    _life = value;
                }
                if (value >= _maxLife)
                {
                    value = _maxLife;
                }
                else
                {
                    _life = 3;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set
            {
                if (value > 0)
                {
                    _hitChance = value;
                }
                else
                {
                    _hitChance = 1;
                }
            }
        }
        public int Block
        {
            get { return _block; }
            set
            {
                if (value > 0)
                {
                    _block = value;
                }
                else
                {
                    _block = 1;
                }
            }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set
            {
                if (value > 0)
                {
                    _maxLife = value;
                }
                else
                {
                    _maxLife = 1;
                }
            }
        }
        public int LifeNum
        {
            get { return _lifeNum; }
            set
            {
                if (value > 0)
                {
                    _lifeNum = value;
                }
                else
                {
                    _lifeNum = 1;
                }
            }
        }
        //Constructors
        public Character(int life, string name, int hitChance, int block, int maxLife, int lifeNum)
        {
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            LifeNum = lifeNum;
        }
        public Character()
        {
        }
        //Methods
        public override string ToString()
        {
            return String.Format("" +
                "Life: {0}" +
                "Name: {1}" +
                "Hit Chance: {2}" +
                "Block: {3}" +
                "Max Life:{4}" +
                "Life:{5}",
                Life,
                Name,
                CalcHitChance,
                Block,
                MaxLife,
                LifeNum);
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
    }

}