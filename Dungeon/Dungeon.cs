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
using System.Numerics;

namespace Dungeon
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            int score = 0;

            #region Weapons
            var weapons = Enum.GetValues(typeof(WeaponType));
            Weapon w1 = new Weapon(1, 2, WeaponType.Sword, 1, true);
            Weapon w2 = new Weapon(2, 3, WeaponType.Lance, 2, true);
            Weapon w3 = new Weapon(3, 4, WeaponType.Crossbow, 3, true);
            Weapon w4 = new Weapon(4, 5, WeaponType.Dagger, 4, false);
            Weapon w6 = new Weapon(5, 6, WeaponType.Axe, 5, true);

            #endregion

            #region Races 
            Console.WriteLine("\n Please select a race Using a number only");
            var races = Enum.GetValues(typeof(Race));
            int index = 1; //Because no one wants to choose from a list that starts with 0
            foreach (var race in races)
            {
                Console.WriteLine($"{index}) {race}");
                index++;
            }
            int userInput = int.Parse(Console.ReadLine());
            Race userRaceChoice = (Race)userInput;
            Console.WriteLine(userRaceChoice);
            #endregion

            #region Player

            Console.Write("Howdy! Please tell us your name for the tombstone: ");
            string user = Console.ReadLine();

            Player p1 = new Player(1, user, 1, 2, 3, 4, w1, userRaceChoice, true);
            Console.Clear();
            Console.WriteLine($"\nWelcome {p1.Name}, your journey begins!");
            #endregion



            bool outerLoop = true;
            do
            {
                Room();
                RandomWeapon();
                Console.WriteLine("Press any key to continue \n");
                Console.ReadKey(true);


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

                } while (innerLoop );//end inner loop 
            } while (outerLoop);//end outer loop

        }

        private static void Room()
        {
            Random rand = new Random();
            string[] rooms = new string[]
            {
                "at the Front Gates of hell and you forgot a welcome gift",
                "at the Dovehouse in Mike Tysons mansion and you just offended his favorite pigeon",
                "in Kim Kardashians Bathroom and you just made fun of her famous sink",
                "at the Pearly Gates and you just brought up the show Lucifer"
            };
            int room = rand.Next(3);
            string choosenRoom = rooms[room];
            Console.WriteLine($"You are: {choosenRoom}");
            Console.WriteLine("Prepare for Battle");
        }


        private static void RandomWeapon()
        {
            Random random = new Random();
            int weaponNumber = random.Next(1, 5);
            WeaponType randomWeapon = (WeaponType)weaponNumber;
            Console.WriteLine($"Your Weapon: {randomWeapon}");

        }



    }
}
