using System;
//using System.Collections;
using System.Collections.Generic;

namespace ScaryGame
{
    class Room
    {
    }
    class Kitchen 
    {
        public static string input;
        //public static List<string> contents { get; set; }
        public static List<string> contents = new List<string>
        {
        "Luger-Manufactured in 1898, loaded with silver colored bullets on a shelf",
        "chair",
        "cracked bowl on a table",
        "window that's locked",
        "pot of boiling Caldillo de congrio (popular in Chile) on a stove",
        "a window letting in the light - it's getting dark out"
        };
        public static void Start()
        {
            Console.WriteLine("You enter the kitchen and look around.  You see:");
            foreach (var item in contents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("There is a strong smell of garlic coming from the pot of soup on the stove");
            Console.WriteLine("You look in the pot and see eel heads bouncing around.  How hungry are you?");
            var acceptableValues = new List<string>()
            {
                "exit",
                "eat",
                "take",
                "defenestrate",
                "quit"
            };
            do
            {
                Console.WriteLine("Pick a verb");
                input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        Console.WriteLine("Now you're back in the hallway where you started");
                        Hallway.Start();
                        break;
                    case "eat":
                        Console.WriteLine("You dip the bowl into the soup.  As you're blowing on the soup to cool it the crack opens up.");
                        Console.WriteLine("The entire contents of the bowl spill on your chest.  Now you got third degree burns, your shirt is soaked and reeks of garlic.");
                        Console.WriteLine("Good going, this just isn't your day is it?");
                        Program.soupOn = true;
                        input = "";
                        break;
                    case "take":
                        Console.WriteLine("Take what?");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "luger":
                                Program.carry.Add("Luger");
                                Console.WriteLine("Got it");
                                break;
                            case "bowl":
                                Console.WriteLine("The cracks in the bowl spread.  It breaks into tiny pieces and falls to the floor");
                                break;
                            default:
                                Console.WriteLine("Can't do that");
                                break;
                        }
                        break;
                    case "defenestrate":
                        Console.WriteLine("Defenestrate what?");
                        input = Console.ReadLine();
                        if (input == "chair")
                        {
                            Console.WriteLine("The window is shattered.  Now What?");
                            input = Console.ReadLine();
                            if (input == "jump")
                            {
                                Console.WriteLine("You jumped to safety.  You live.");
                                Console.ReadLine();
                                System.Environment.Exit(0);
                                input = "quit";
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Can't do that");
                        }
                        break;
                    default:
                        Console.WriteLine("Can't do that");
                        break;
                }
            } while (!acceptableValues.Contains(input));
        }
    }
    class WwRoom
    {
        public static string input;
        public static void Start ()
        {
            Console.WriteLine("The only thing in room is a werewolf secured to the wall by a long chain.");
            Console.WriteLine("The werewolf lunges at you but the chain stops him an arms length away.");
            Console.WriteLine("He takes a swipe at you with his powerful arm.  Your shirt is completely torn off and now you have four deep lacerations across your chest");
            Program.shirtOn = false;
            if (Program.soupOn)
	        {
            Console.WriteLine("in addition to the third degree burns");
	        }
            Console.WriteLine("The chain holding the werewolf is starting to come loose from the wall.");
            Console.WriteLine("You have one second to react.  What are you going to do?");
            var acceptableValues = new List<string>()
            {
                "exit",
                "shoot",
            };
            do
            {
                Console.WriteLine("Pick a verb");
                input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        Console.WriteLine("Now you're back in the hallway where you started");
                        Hallway.Start();
                        break;
                    case "shoot":
                        Console.WriteLine("The chain breaks free from the wall.");
                        if (Program.carry.Contains("Luger"))
                        {
                            Console.WriteLine("All your shots hit the wereworf in the center of his chest");
                            Console.WriteLine("The werewolf starts laughing as he is tearing you apart.  'You idiot' he says. ");
                            Console.WriteLine("Those are ordinary bullet painted with chromium not silver bullets.");
                        }
                        else
                        {
                            Console.WriteLine("You don't have a gun.");
                        }
                        Console.WriteLine("You barely understand what he is saying because he is laughing so hard and has a mouth full of your flesh.");
                        Console.WriteLine("The last thing you see as your life fades is your blood dripping from his jaws.");
                        Console.WriteLine("Better luck in the next life.");
                        Console.WriteLine("Look on the bright side.  You were worried about dying of old age before you got out of here.  That didn't happen.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Can't do that");
                        break;
                }
            } while (!acceptableValues.Contains(input));

        }
    }
    class VampRoom
    {
        public static string input;
        public static void Start()
        {
            Console.WriteLine("The only thing in room is a coffin, a fully lit candelabra, and a sign that read 'Don't open the coffin before sundown'.");
            Console.WriteLine("What are you going to do?");
            var acceptableValues = new List<string>()
            {
                "exit",
                "open",
                "take"
            };
            do
            {
                Console.WriteLine("Pick a verb");
                input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        Console.WriteLine("Now you're back in the hallway where you started");
                        Hallway.Start();
                        break;
                    case "open":
                        Console.WriteLine("You open the coffin.  The vampire gets out.  He doesn't look happy.");
                        if (Program.soupOn & Program.shirtOn)
                        {
                            Console.WriteLine("The vampire says 'You reek of garlic.  I hate garlic and flys away");
                            input = null;
                        } else
                        {
                            Console.WriteLine("The vampire bites your neck, sucks all your blood, and you die.");
                            Console.WriteLine("It's a shame you didn't have the essence of garlic about you, you might have survived.");
                            Console.WriteLine("Better luck in the next life.");
                            Console.WriteLine("Look on the bright side.  You were worried about dying of old age before you got out of here.  That didn't happen.");
                            Console.ReadLine();
                        }
                        break;
                    case "take":
                        Console.WriteLine("Take what?");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "candelabra":
                                Program.carry.Add("candelabra");
                                Console.WriteLine("Got it");
                                break;
                            default:
                                Console.WriteLine("Can't do that");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Can't do that");
                        break;
                }
            } while (!acceptableValues.Contains(input));

        }
    }
    class MumRoom
    {
        public static string input;
        public static void Start()
        {
            Console.WriteLine("The only thing in room is a mummy.");
            Console.WriteLine("He rushes toward you and locks his hands around your throat.");
            Console.WriteLine("You have one second to react.  What are you going to do?");
            var acceptableValues = new List<string>()
            {
                "exit",
                "shoot",
                "inflame"
            };
            do
            {
                Console.WriteLine("Pick a verb");
                input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        Console.WriteLine("Too late for that he's already got his hands around your throat.");
                        Console.WriteLine("The last thing you see as your life fades is the mummy and he is ugly.");
                        Console.WriteLine("Better luck in the next life.  To bad you weren't able to set him on fire.  It might have given you a chance to escape.");
                        Console.WriteLine("Look on the bright side.  You were worried about dying of old age before you got out of here.  That didn't happen.");
                        Console.ReadLine();
                        break;
                    case "inflame":
                        if (Program.carry.Contains("candelabra"))
                        {
                            Console.WriteLine("You set the mummy on fire.  He is distracted as you exit the room.");
                            Hallway.Start();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You don't have fire.");
                        }
                        Console.WriteLine("The last thing you see as your life fades is the mummy and he is ugly.");
                        Console.WriteLine("Better luck in the next life.  To bad you weren't able to set him on fire.  It might have given you a chance to escape.");
                        Console.ReadLine();
                        break;
                    case "shoot":
                        if (Program.carry.Contains("Luger"))
                        {
                            Console.WriteLine("All your shots hit the mummy in the center of his chest");
                            Console.WriteLine("The bullets have no effect.");
                        }
                        else
                        {
                            Console.WriteLine("You don't have a gun.");
                        }
                        Console.WriteLine("The last thing you see as your life fades is the mummy and he is ugly.");
                        Console.WriteLine("Better luck in the next life.  To bad you weren't able to set him on fire.  It might have given you a chance to escape.");
                        Console.WriteLine("Look on the bright side.  You were worried about dying of old age before you got out of here.  That didn't happen.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Can't do that");
                        break;
                }
            } while (!acceptableValues.Contains(input));
            Console.WriteLine("You can't get a breath.  The edges of your vision start to turn black.");
            Console.WriteLine("The blackness races towards the center.  You die.");
        }
    }
    class MimRoom
    {
        //public static string input;
        public static void Start()
        {
            Console.WriteLine("The only thing in room is a mime pulling on an invisible rope.");
            Console.WriteLine("The mime is smiling as he pulls on the invisible rope.  You feel a tightness around your throat.");
            Console.WriteLine("The mime keeps pulling on the invisible rope.  It gets tighter around your neck.");
            Console.WriteLine("You can't get a breath.  The edges of your vision start to turn black.");
            Console.WriteLine("The mime looks so happy as you slump to the floor.  The blackness races towards the center.  You die.");
            Console.WriteLine("I guess no one ever warned you about mimes. Better luck in the next life.");
            Console.WriteLine("Look on the bright side.  You were worried about dying of old age before you got out of here.  That didn't happen.");
            Console.ReadLine();
        }
    }
    class Program
    {
        public static bool shirtOn = true;
        public static bool soupOn = false;
        //public static List<string> GoodVerbs { get; set; }
        public static List<string> carry = new List<string>();
        static void Main(string[] args)
        {
        
            List<string> goodVerbs = new List<string>()
            {
                "exit",
                "eat",
                "take",
                "jump",
                "look",
                "shoot",
                "open",
                "defenestrate",
                "enter",
                "inflame"
             };
            Console.WriteLine("When you want to take action you can use one of these verbs: ");
            Console.Write(goodVerbs[0]);
            for (int i = 1; i < goodVerbs.Count - 1; i++)
            {
                Console.Write(", " + goodVerbs[i]);
            };
            Console.Write("\n\n");
            Hallway.Begin();
            Hallway.Start();
            if (Kitchen.input == "quit")
            {
                System.Environment.Exit(1);
            } 
        }
    }
    class Hallway
        {
        private static string input;

        public static void Begin ()
        {
            Console.WriteLine("You find yourself in a hallway in an old castle.  You got separated from the tour.  You're hungry and ");
            Console.WriteLine("tired from trying to find the exit.  You didn't even want to go on the stupid tour, but your wife ");
            Console.WriteLine("said 'Oh, it'll be fun.  You're thinking 'fun Ha, I'll be lucky if I don't die of old age before I get ");
            Console.WriteLine("out of here.");  
        }
        public static void Start()
        {
            //public static List<string> Contents { get; set; }
            List<string> Contents = new List<string>();
                Console.WriteLine("You look around.  There's a kitchen behind you, and two doors on either side of the ");
                Console.WriteLine("hallway up ahead.  The only thing to do is enter a room.  \nPick a room:");
                Contents.Add("1 = kitchen");
                Contents.Add("2 = first room on the left");
                Contents.Add("3 = first room on the right");
                Contents.Add("4 = second room on the left");
                Contents.Add("5 = second room on the right");
            var acceptableValues = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
            };
            do
            {
                string input;
                foreach (var item in Contents)
                {
                    Console.WriteLine(item);
                };
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    Console.WriteLine(input);
                    Kitchen.Start();
                        break;
                    case "2":
                    WwRoom.Start();
                        break;
                    case "3":
                    VampRoom.Start();
                    break;
                    case "4":
                    MumRoom.Start();
                        break;
                    case "5":
                    MimRoom.Start();
                    break;
                }
            } while (acceptableValues.Contains(input));
        }
    }

    class Contents
    {
        internal class Add
        {
        }
    }
}
