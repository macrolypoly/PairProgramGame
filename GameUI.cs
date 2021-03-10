using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace PairProgrammingGame
{
    public class GameUI
    {
        public void GameTitle()
        {
            Console.WriteLine("CHEESE PIZZA MYSTERY");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            Run();
        }
        public void Run()
        {
            Room currentRoom = Pizza;

            Console.WriteLine(currentRoom.Splash);

            Console.Clear(); // beginning text of the game, prompting you to enter a direction you wish to go 
            Console.WriteLine("Congratulations on your new pizza delivery job!");
            Console.ReadKey();
            Console.WriteLine("You've just received your first pizza delivery order.");
            Console.ReadKey();
            Console.WriteLine("Uh Oh, they hung up before you can get a name or address and your boss blames you for this.");
            Console.ReadKey();
            Console.WriteLine("You have just moved into town, and have no friends, no family, and no directions. Yikes!");
            Console.ReadKey();
            Console.WriteLine("In order to succeed you must venture into the unkown and deliver this cheese pizza without fail.");
            Console.ReadKey();
            Console.WriteLine("With cheese pizza in-hand, which direction will you go? (North, South, East, West)");

            bool catFound = false;
            bool posterSeen = false;
            bool warmPizza = true;
            int strikes = 0;
            while (warmPizza)
            {
                string command = Console.ReadLine().ToLower();
                Console.Clear();
                if (command.Contains("south"))
                {
                    Console.WriteLine("You head south");
                    if (currentRoom == Park)
                    {
                        currentRoom = DoctorsOffice;
                    }
                    else if (currentRoom == DoctorsOffice)
                    {
                        currentRoom = EdgeOfTown;
                    }
                    else
                    {
                        currentRoom = Park;
                    }
                }


                else if (command.Contains("north"))
                {
                    Console.WriteLine("You head north");
                    if (currentRoom == Bank)
                    {
                        currentRoom = Apartments;
                    }
                    else if (currentRoom == Apartments)
                    {
                        currentRoom = EdgeOfTown;
                    }
                    else
                    {
                        currentRoom = Bank;
                    }
                }


                else if (command.Contains("east"))
                {
                    Console.WriteLine("You head east");
                    if (currentRoom == GroceryStore)
                    {
                        currentRoom = EdgeOfTown;
                    }
                    else
                    {
                        currentRoom = GroceryStore;
                    }
                }

                else if (command.Contains("west"))
                {
                    Console.WriteLine("You head west");
                    if (currentRoom == Suburbs)
                    {
                        currentRoom = EdgeOfTown;
                    }
                    else
                    {
                        currentRoom = Suburbs;
                    }
                }

                else
                {
                    Console.WriteLine("That's not a direction. Try again");
                }
                // currentrooms
                while (currentRoom == Bank)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("purple lipstick") || command.Contains("lady") || command.Contains("woman"))
                    {
                        Console.WriteLine("You talk to the woman with purple lipstick. " + "She says, 'Smells like cheese pizza, my friend up north loves cheese pizza!'");
                    }
                    if (command.Contains("police") || command.Contains("officer"))
                    {
                        Console.WriteLine("You talk to the police officer. " + "He yells, 'Cutting in line is against the law' and then turns to ignore you");
                    }
                    if (command.Contains("teller"))
                    {
                        Console.WriteLine("You talk to the bank teller " + "She says, 'You can't deposit pizza, trust me I've tried. Please leave.'");
                    }
                    else if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("You exit the bank.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine();
                        if (currentRoom == Bank && command.Contains("north"))
                        {
                            currentRoom = Apartments;
                        }
                    }
                }
                while (currentRoom == Apartments)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("knock"))
                    {
                        if (command.Contains("213") && catFound == false)
                        {
                            Console.WriteLine("You knock on door 213.");
                            Console.WriteLine("You wait a couple of minutes. No one answers the door.");
                        }
                        else if (command.Contains("213") && catFound == true)
                        {
                            Console.WriteLine("You knock on door 213.");
                            Console.WriteLine("You wait a couple of minutes. No one answers the door.");
                            Console.WriteLine("The cat meows. The door swings open.");
                            Console.WriteLine("You found my cat! Thanks so much.\n(side quest completed)");
                        }
                        else if (command.Contains("214"))
                        {
                            Console.WriteLine("You knock on door 214.");
                            Console.WriteLine("A man opens the door.\n" +
                                "He says, 'I was getting worried the pizza would get cold! Here's your tip.\n \n" +
                                "Congratulations.  You have solved the mystery of the cheese pizza!\n \n" +
                                "game over");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();


                            // game done
                        }
                        else if (command.Contains("215"))
                        {
                            Console.WriteLine("You knock on door 215.");
                            Console.WriteLine("A woman answers the door. \n" + "She says, 'I think you have the wrong apartment, sorry.'");
                        }
                        Console.WriteLine("which door will you knock on?");
                        command = Console.ReadLine();
                        if (command.Contains("213"))
                        {
                            Console.WriteLine("You knock on door 213.");
                            Console.WriteLine("You wait a couple of minutes. No one answers the door.");

                        }
                        else if (command.Contains("214"))
                        {
                            Console.WriteLine("You knock on door 214.");
                            Console.WriteLine("A man opens the door.\n" +
                                 "He says, 'I was getting worried the pizza would get cold! Here's your tip.\n \n" +
                                 "Congratulations.  You have solved the mystery of the cheese pizza!\n \n" +
                                 "game over");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();

                            // game done
                        }
                        else if (command.Contains("215"))
                        {
                            Console.WriteLine("You knock on door 215.");
                            Console.WriteLine("A woman answers the door. \n" + "She says, 'I think you have the wrong apartment, sorry.'");

                        }
                    }
                }
                while (currentRoom == Pizza)
                {
                    Console.WriteLine("You are back at the pizza shop. Your boss is looking at you angrily.");
                    Console.WriteLine("He yells, 'What are you doing here? Go deliver that pizza!'");
                    Console.WriteLine("What will you do? \n");
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("which direction do you go?");
                        command = Console.ReadLine();
                        if (currentRoom == Pizza && command.Contains("north"))
                        {
                            currentRoom = Bank;
                        }
                        else if (currentRoom == Pizza && command.Contains("south"))
                        {
                            currentRoom = Park;
                        }
                        else if (currentRoom == Pizza && command.Contains("west"))
                        {
                            currentRoom = Suburbs;
                        }
                        else if (currentRoom == Pizza && command.Contains("east"))
                        {
                            currentRoom = GroceryStore;
                        }
                    }

                }
                while (currentRoom == Park)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("talk"))
                    {
                        Console.WriteLine("You approach the smoking youths. They eye the pizza in your hand and ask you to hand it over.");
                        Console.WriteLine("What will you do?");
                        command = Console.ReadLine();
                        if (command.StartsWith("hand over"))
                        {
                            Console.WriteLine("With shaking hands, you hand over the pizza to the youths.");
                            warmPizza = false;
                        }
                        if (command.Contains("run") || command.Contains("keep") || command.Contains("no"))
                        {
                            Console.WriteLine("You run away.");
                        }
                    }
                    if (command.StartsWith("pet"))
                    {
                        Console.WriteLine("You pet the cat.");
                    }
                    if (command.StartsWith("get"))
                    {
                        Console.WriteLine("you get the cat.");
                        catFound = true;
                        Console.WriteLine("You remember the poster saying, 'If found, return to owner at Apartment 213.'");
                    }
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("which direction do you go?");
                        command = Console.ReadLine();
                        if (currentRoom == Park && command.Contains("north"))
                        {
                            currentRoom = Pizza;
                        }
                        else if (currentRoom == Park && command.Contains("south"))
                        {
                            currentRoom = DoctorsOffice;
                        }
                        else if (currentRoom == Park && command.Contains("west"))
                        {
                            Console.WriteLine("There's nothing there.");
                        }
                        else if (currentRoom == Park && command.Contains("east"))
                        {
                            Console.WriteLine("There's nothing there.");
                        }
                    }
                }
                while (currentRoom == GroceryStore)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("rebecca"))
                    {
                        Console.WriteLine("You greet Rebecca. " + "She says, 'Who brings pizza INTO the grocery store?! Please leave!'");
                    }
                    if (command.Contains("sharlene"))
                    {
                        Console.WriteLine("You greet Sharlene " + "She says, 'My granddaughter used to deliver pizzas. Every other week she'd deliver a cheese pizza to her friend in the apartments.");
                    }
                    if (command.Contains("poster"))
                    {
                        Console.WriteLine("You look at the attached poster: 'Missing cat, last seen at Doctors Office.");
                        posterSeen = true;
                    }
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("you exit the grocery store.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine();
                        if (currentRoom == GroceryStore && command.Contains("east"))
                        {
                            currentRoom = EdgeOfTown;
                        }
                        else if (currentRoom == GroceryStore && command.Contains("west"))
                        {
                            currentRoom = Pizza;
                        }
                        else if (currentRoom == GroceryStore && command.Contains("north"))
                        {
                            Console.WriteLine("this leads to nowhere, try a different direction.");
                        }
                        else if (currentRoom == GroceryStore && command.Contains("south"))
                        {
                            Console.WriteLine("this leads to nowhere, try a different direction.");
                        }
                        
                    }
                }
                while (currentRoom == EdgeOfTown)
                {
                    Console.WriteLine(currentRoom.Splash);
                    strikes += 1;
                    command = Console.ReadLine().ToLower();
                }
                while (currentRoom == DoctorsOffice)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("front desk"))
                    {
                        Console.WriteLine("Administrator says, 'Yum, pizza is my favorite. But, I've already had lunch today'.");
                    }
                    if (command.Contains("cat"))
                    {
                        Console.WriteLine("Administrator says, 'I heard that the teenagers were bullying the cat.' Why don't you take a look?");
                    }
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("you exit the doctor's office.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine();
                        if (currentRoom == DoctorsOffice && command.Contains("south"))
                        {
                            currentRoom = EdgeOfTown;
                        }
                        else if (currentRoom == DoctorsOffice && command.Contains("north"))
                        {
                            currentRoom = Park;
                        }
                        else if (currentRoom == DoctorsOffice && command.Contains("east"))
                        {
                            Console.WriteLine("this leads to nowhere, try a different direction.");
                        }
                        else if (currentRoom == DoctorsOffice && command.Contains("west"))
                        {
                            Console.WriteLine("this leads to nowhere, try a different direction.");
                        }
                    }
                    while (currentRoom == Suburbs)
                    {
                        Console.WriteLine(currentRoom.Splash);
                        Console.WriteLine("What will you do? \n");
                        command = Console.ReadLine().ToLower();
                        if (command.Contains("talk"))
                        {
                            Console.WriteLine("A concerned parent scoffs, 'You don't live in this neighborhood and pizza is bad for you. Please leave'.");
                        }
                        if (command.Contains("exit") || command.Contains("leave"))
                        {
                            Console.WriteLine("you exit the suburbs.");
                            Console.WriteLine("Which direction will you go?");
                            command = Console.ReadLine();
                            if (currentRoom == Suburbs && command.Contains("west"))
                            {
                                currentRoom = EdgeOfTown;
                            }
                            else if (currentRoom == Suburbs && command.Contains("east"))
                            {
                                currentRoom = Pizza;
                            }
                            else if (currentRoom == Suburbs && command.Contains("north"))
                            {
                                Console.WriteLine("this leads to nowhere, try a different direction.");
                            }
                            else if (currentRoom == Suburbs && command.Contains("south"))
                            {
                                Console.WriteLine("this leads to nowhere, try a different direction.");
                            }
                        }

                    }
                    if (strikes == 3)
                    {
                        warmPizza = false;

                    }
                    else
                    {
                        warmPizza = true;
                    }
                    if (warmPizza == false)
                    {
                        Console.WriteLine("Pizza is no longer warm, you have failed");
                        Console.WriteLine("game over");
                        if (catFound)
                        {
                            Console.WriteLine("you found the missing cat!");
                        }
                        Console.Clear();
                        GameTitle();
                    }


                }
            }
        }


        // north - bank 
        // - teller 
        // north again - apartments 
        // 4 potential tenents - 2 helpful, 2 unhelpful 
        // north again - edge of town 
        // east - grocery store 
        // nosey old ladies 
        // east again - edge of town 
        // south - park 
        // mean teenagers
        // south again - doctors office
        // front desk 
        // south again - edge of town 
        // west - suburbs
        // concerned parents
        // west again edge of town 

        public static Room Bank = new Room( // option 1) man in hat - not helpful, option 2) purple lipstick - is helpful, option 3) bank teller - is helpful
         "You are at the bank. You see 3 people, a police officer, a woman with purple lipstick, and a bank teller.\n" +
         "You also see an emergency exit and the entrance you just came from.",

        new List<string> { "exit", "emergency exit" });

        public static Room Park = new Room( // option 1) talk to all teenagers at once, they are unhelpful 
                "You walk into a park. You see a group of smoking youths who stare at you menacingly",
                new List<string> { "exit" }
                );
        public static Room Apartments = new Room( // 213 - no answer, unhelpful / 214 ordered the pizza! / 215 - someone opens the door, helpful 
                "You are at the apartments." + "You see 3 doors, room 213, 214, and 215. You can also see stairs.",
                new List<string> { "stairs", "emergency exit" }
                );
        public static Room Pizza = new Room( // if re-entering the pizz place only one prompt, boss asks "what are you doing back here? go deliver  the pizza" 
                "You are at the pizza parlor you work at. You see your boss, and your coworker, Stacy. You also see the entrance you just came from",
                new List<string> { "exit" }
                );
        public static Room EdgeOfTown = new Room(  // if you hit the edge of town 3 times the pizza is cold / game over
            "You have reached the edge of town",
            new List<string> { "exit" }
            );
        public static Room GroceryStore = new Room(
            "You are inside a grocery store. You spot two ladies, Rebecca and Sharlene. You also notice a missing cat poster.",  // option 1) talk to rebecca (not helpful)  option 2) talk to Sharlene (offers a clue) option 3) inspect poster
            new List<string> { "exit" }
            );
        public static Room Suburbs = new Room(
            "You enter the suburbs west of town. Concerned parents stare at you from their front patios.",  // option 1) approach any parent  option 2) exit 
            new List<string> { "exit" }
            );
        public static Room DoctorsOffice = new Room(
            "You enter the doctors off south of the park. A front desk administrator smiles at you.",  // option 1) approach any parent  option 2) exit 
            new List<string> { "exit" }
            );
    }
}


