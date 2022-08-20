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
            Random random = new Random();
            int weaponNumber = random.Next(1, 5);
            WeaponType randomWeapon = (WeaponType)weaponNumber;
            Weapon w1 = new Weapon(1,2,$"{randomWeapon}", 3,true, randomWeapon);
           //  Weapon w2 = new Weapon(1,1,"Lance", 1,true,WeaponType.Lance);
           //  Weapon w3 = new Weapon(2, 3,"Crossbow", 4, true,WeaponType.Crossbow);
           //  Weapon w4 = new Weapon(4, 5, "Dagger", 4, false, WeaponType.Crossbow);
           //  Weapon w6 = new Weapon(5, 6, "Axe", 5, true, randomWeapon);

            #endregion

            #region Races 
            var races = Enum.GetValues(typeof(Race));
            Random rand = new Random();
            int randomRaceNumber = rand.Next(1, 6);
            Race race = (Race)randomRaceNumber;

;
            #endregion

            #region Player
            Console.WriteLine("Please Select a Mood using only numbers: ");
            var moods = Enum.GetValues(typeof(Mood));
            int index = 1; //Because no one wants to choose from a list that starts with 0
            foreach (var mood in moods)
            {
                Console.WriteLine($"{index}) {mood}");
                index++;
            }
            int userInput = int.Parse(Console.ReadLine());
            Mood userMoodChoice = (Mood)userInput;

            Console.WriteLine(userMoodChoice);
            Console.WriteLine($"\nYou are a {userMoodChoice} {race} and your only weapon is a {randomWeapon}\n");



            Console.Write("Howdy! Please tell us your name for the tombstone: ");
            string user = Console.ReadLine();

            Player p1 = new Player(user,userMoodChoice, 45,25,55,55, race, w1);
            Console.Clear();
            #endregion



            bool outerLoop = true;
            do
            {
                Room();
                Console.WriteLine("Press any key to continue \n");
                Console.ReadKey(true);
                Monster monster = Monster.GetMonster();
                Console.WriteLine("the Nightmare in your personal space: " + monster.Name);

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
                            Combat.DoBattle(p1, monster);
                            if (monster.Life <= 0)
                            {
                                score++;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.Beep(800, 500);
                                innerLoop = false;
                            }
                            if (p1.Life <= 0)
                            {
                                Console.WriteLine("you are as dead as a doonail!\a");
                                innerLoop = false;
                            }

                            break;
                        case "b":
                            Console.WriteLine("Leave inner loop");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, p1);
                            innerLoop = false;
                            break;
                        case "c":
                            Console.WriteLine("character info");
                            Console.WriteLine(p1);
                            Console.WriteLine("Monsters Defeated: " + score);
                            break;
                        case "d":
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
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
                "at the Pearly Gates and you just brought up the show Lucifer in small talk",
            };
            int room = rand.Next(3);
            string choosenRoom = rooms[room];
            Console.WriteLine($"You are: {choosenRoom}");
            Console.WriteLine("Prepare for Battle");
        }


        private static void RandomWeapon()
        {

        }



    }
}
