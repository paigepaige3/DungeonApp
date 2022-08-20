﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonLibrary
{
    public class Monster : Character 
    {
        public int MaxDamage { get; set; }

        public string Description { get; set; }

        private int _minDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (true)
                {
                    _minDamage = 1;
                }
                else if (value < 1)
                {
                    _minDamage = 1;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster()
        {
            
        }
        public override string ToString()
        {
            return $"\n{ Name} \n" +
                $"Life: { Life} of { MaxLife} \n" +
                $"Damage: { MinDamage} - { MaxDamage} \n" +
                $"Block: { Block} ";
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {   
                                            //name      L   ML HC  B  MD        
            Cyclops cyclops = new Cyclops   ("Cyclops" , 5, 5, 40, 5,  50, 5, 5, "Cyclops with eye of doom");
            Dybbuk dybbuk = new Dybbuk      ("Dybbuk"  , 5, 5, 50, 7,  50, 6, 4, "Dybbuk is Spooky");
            Hydra hydra = new Hydra         ("Hydra"   , 5, 5, 45, 5,  40, 7, 3, "Hyras have multiple heads");
            Banshee banshee = new Banshee   ("Banshee" , 5, 5, 55, 10, 35, 8, 2, "Banshee are very scary");

            List<Monster> monsters = new () { cyclops , dybbuk, hydra, banshee };

            return monsters[new Random().Next(monsters.Count)];
        }
    }

}
