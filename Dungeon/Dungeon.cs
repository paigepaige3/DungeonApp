using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Main");
            Room();
            Character();
            Console.WriteLine("Monster and Room Created");
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
                        "-=-=-=Menu=-=-=-\n" +
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
                            Console.WriteLine("win - break out of innerloop");
                            innerLoop = false;
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
            Console.WriteLine($"Room: {choosenRoom}");
        }

        private static void Character()
        {
            Random rand = new Random();

            Character c1 = new Character
            {
                Life = 5,
                Name = "Cloud Jumper",
                HitChance = 3,
                Block = 2,
                MaxLife = 3,
                LifeNum = 4,
            };
            string[] characters = new string[]
            {
                
            };
            int character = rand.Next(3);
            string choosenCharacter = characters[character];
            Console.WriteLine($"Character:{choosenCharacter}");
        }



    }
}
