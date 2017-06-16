using System;
//using System.Collections;
using System.Collections.Generic;

namespace ScaryGame
{
    class Room
    {
        static Room() {
            Contents = new List<string>();
            GoodVerbs = new List<string>();
            }
        public static List<string> Contents { get; set; }
        public static List<string> GoodVerbs { get; set; }
    }
    class Kitchen : Room
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            //var contents = new List<string>();

            Kitchen.Contents.Add("Luger-Manufactured in 1898, loaded with silver colored bullets on a shelf");
            Kitchen.Contents.Add("chair");
            Kitchen.Contents.Add("cracked bowl on a table");
            Kitchen.Contents.Add("window that's locked");
            Kitchen.Contents.Add("pot of boiling Caldillo de congrio (popular in Chile) on a stove");
            Kitchen.GoodVerbs.Add("exit");
            Kitchen.GoodVerbs.Add("eat");
            Kitchen.GoodVerbs.Add("take");
            Kitchen.GoodVerbs.Add("jump");
            Kitchen.GoodVerbs.Add("look");
            Kitchen.GoodVerbs.Add("defenestrate");
            Hallway.Contents.Add("1 = kitchen");
            Hallway.Contents.Add("2 = first room on the left");
            Hallway.Contents.Add("3 = first room on the right");
            Hallway.Contents.Add("4 = second room on the left");
            Hallway.Contents.Add("5 = second room on the right");
            Hallway.GoodVerbs.Add("enter");
            Hallway.Start();
        }
    }
    class Hallway : Room
        {
            public static void Start ()
            {
                Console.WriteLine("You find yourself in a hallway in an old castle.  You got separated from the tour.  You're hungry and ");
                Console.WriteLine("tired from trying to find the exit.  You didn't even want to go on the stupid tour, but your wife ");
                Console.WriteLine("said 'Oh, it'll be fun.  You're thinking 'fun Ha, I'll be lucky if I don't die of old age before I get ");
                Console.WriteLine("out of here.  You look around.  There's a kitchen behind you, and two doors on either side of the ");
                Console.WriteLine("hallway up ahead.  The only thing to do is enter a room.  Pick a room:");
            foreach (var item in Hallway.Contents)
                {
                    Console.WriteLine(item);
                }
                int input = Console.Read();
                switch (input)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }





               //        Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
               //Console.WriteLine("");
            }
        }

    class Contents
    {
    }
}
