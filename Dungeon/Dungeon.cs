using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace Dungeon
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            var weapons = Enum.GetValues(typeof(WeaponType));
            Weapon w1 = new Weapon(1,2,WeaponType.Sword,1,true);
            Weapon w2 = new Weapon(2, 3, WeaponType.Lance, 2, true);
            Weapon w3 = new Weapon(3, 4, WeaponType.Crossbow, 3, true);
            Weapon w4 = new Weapon(4, 5, WeaponType.Dagger, 4, false);
            Weapon w6 = new Weapon(5, 6, WeaponType.Axe, 5, true);


            Console.WriteLine("Welcome");
            Room();
            Character();

            RandomWeapon();
            Console.WriteLine("Press any key to continue \n");
            Console.ReadKey(true);


            //TODO: Create a Player

            bool outerLoop = true;
            do
            {

                //TODO: Create a Monster

                //TODO: Create a Room

                bool innerLoop = true;
                do
                {

                    Console.WriteLine("" +
                        "Do you choose to: \n" +
                        "A) Attack\n" +
                        "B) Run Away\n" +
                        "C) Charecter Info\n" +
                        "D) Monster Info\n" +
                        "E) Exit\n" +
                        "-=-=-=-=-=-=-=-");


                    string choice = Console.ReadKey(true).Key.ToString().ToLower();

                    switch (choice)
                    {
                        case "a":
                            Console.WriteLine("Attack");
                            Console.WriteLine($"");
                            innerLoop = false;
                            Console.WriteLine($"");
                            break;
                        case "b":
                            Console.WriteLine("Leave inner loop");
                            innerLoop = false;
                            break;
                        case "c":
                            Console.WriteLine("character info");
                            break;
                        case "d":
                            Console.WriteLine("Monster Info");
                            break;
                        case "e":
                            Console.WriteLine("Break out of both loops");
                            innerLoop = false;
                            outerLoop = false;
                            break;
                        default:
                            Console.WriteLine("invalid input, Try again");
                            break;
                    }

                } while (innerLoop);//end inner loop 
            } while (outerLoop);//end outer loop

        }

        private static void Room()
        {
            Random rand = new Random();
            string[] rooms = new string[]
            {
                "Hall",
                "Bathroom",
                "Kitchen"
            };
            int room = rand.Next(3);
            string choosenRoom = rooms[room];
            Console.WriteLine($"You ar in Room: {choosenRoom}");
        }

        private static void Character()
        {
            Random rand = new Random();
            string[] characters = new string[]
            {
                "Cloud Jumper",
                "Cloud Hopper",
                "Cloud Skipper"
            };
            int character = rand.Next(3);
            string choosenCharacter = characters[character];
            Console.WriteLine($"You are Character:{choosenCharacter}");


        }

        private static void RandomWeapon()
        {
            Random random = new Random();
            int weaponNumber = random.Next(1, 5);
            int randomWeapon = (int)(WeaponType)weaponNumber;
            Console.WriteLine($"Your Weapon: {randomWeapon}");

        }
        private static void GetYourWeapon()
        { 
        }
        public virtual int Damage()
        {
            Random rand = new Random();
            int damage = rand.Next(1, 15);
            return damage;
        }
        public virtual int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(1,5);
            return 0;
        }

    }
}
