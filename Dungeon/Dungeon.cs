using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Dungeon
    {
        static void Main(string[] args)
        {
            bool outerLoop = true;
            bool innerLoop = true;


            //TODO: Create a Player

            do
            {

                //TODO: Create a Monster

                //TODO: Create a Room


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
    }
}
