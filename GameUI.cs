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
        bool catReturned = false;
        bool catFound = false;
        bool posterSeen = false;
        public void Run()
        {
            Room currentRoom = Pizza;
            string command = "";

            Console.WriteLine(currentRoom.Splash);

            Console.Clear(); // beginning text of the game, prompting you to enter a direction you wish to go 
            Console.WriteLine("Congratulations on your new pizza delivery job in a new town!");
            Console.ReadKey();
            Console.WriteLine("You've just received your first pizza delivery order.");
            Console.ReadKey();
            Console.WriteLine("Uh oh, they hung up before you got a name or address.");
            Console.ReadKey();
            Console.WriteLine("Even worse, your boss blames you for this. You can't mess up on your first day!");
            Console.ReadKey();
            Console.WriteLine("In order to succeed you must venture into the unkown and deliver this cheese pizza without fail.");
            Console.ReadKey();
            Console.WriteLine("With cheese pizza in-hand, which direction will you go? (North, South, East, West)");
            command = Console.ReadLine().ToLower();
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
                    currentRoom = EdgeOfTownSouth;
                }
                else if (currentRoom == Bank)
                {
                    currentRoom = Pizza;
                }
                else if (currentRoom == Apartments)
                {
                    currentRoom = Bank;
                }
                else if (currentRoom == GroceryStore)
                {
                    currentRoom = Park;
                }
                else if (currentRoom == Pizza)
                {
                    currentRoom = Park;
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
                    currentRoom = EdgeOfTownNorth;
                }
                else if (currentRoom == Park)
                {
                    currentRoom = Pizza;
                }
                else if (currentRoom == DoctorsOffice)
                {
                    currentRoom = Park;
                }
                else if (currentRoom == Suburbs)
                {
                    currentRoom = Bank;
                }
                else if (currentRoom == Pizza)
                {
                    currentRoom = Bank;
                }
                else if (currentRoom == EdgeOfTownNorth)
                {
                    Console.WriteLine("what are you doing?");
                    currentRoom = Apartments;
                }
            }


            else if (command.Contains("east"))
            {
                Console.WriteLine("You head east");
                if (currentRoom == GroceryStore)
                {
                    currentRoom = EdgeOfTownEast;
                }
                else if (currentRoom == Suburbs)
                {
                    currentRoom = Pizza;
                }
                else if (currentRoom == Pizza)
                {
                    currentRoom = GroceryStore;
                }
                else if (currentRoom == Park)
                {
                    currentRoom = GroceryStore;
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
                    currentRoom = EdgeOfTownWest;
                }
                else if (currentRoom == GroceryStore)
                {
                    currentRoom = Pizza;
                }
                else if (currentRoom == Pizza)
                {
                    currentRoom = Suburbs;
                }
                else if (currentRoom == Park)
                {
                    currentRoom = Suburbs;
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
            bool warmPizza = true;
            int strikes = 0;
            if (strikes == 3)
            {
                warmPizza = false;

            }
            else
            {
                warmPizza = true;
            }

            while (warmPizza)
            {
                while (currentRoom == Bank && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();

                    if (command.Contains("police") || command.Contains("officer") || command.Contains("cop"))
                    {
                        Console.WriteLine("You talk to the police officer. " + "He yells, 'Cutting in line is against the law' and then turns to ignore you");
                    }
                    if (command.Contains("teller"))
                    {
                        Console.WriteLine("You talk to the bank teller " + "She asks, 'Are you here to withdrawal or deposit?'");
                        command = Console.ReadLine().ToLower();
                        if (command.Contains("deposit"))
                        {
                            Console.WriteLine("'You cannot deposit Pizza. Trust me, I've tried. Please leave if you have no business here.'\n");
                        }
                        if (command.Contains("withdrawal"))
                        {
                            Console.WriteLine("'You do not have an account here.  Please come back later to set one up.'\n");
                        }
                        if (command.Contains("ask") || command.Contains("pizza") || command.Contains("neither"))
                        {
                            Console.WriteLine("She says, 'I'm afraid I can't help.'\n");
                        }


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
                        if (currentRoom == Bank && command.Contains("south"))
                        {
                            currentRoom = Pizza;
                        }
                        if (currentRoom == Bank && command.Contains("east"))
                        {
                            currentRoom = GroceryStore;
                        }
                        if (currentRoom == Bank && command.Contains("west"))
                        {
                            currentRoom = Suburbs;
                        }
                    }
                    else if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("You exit the bank.");

                    }
                }

                while (currentRoom == Apartments && warmPizza == true)
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
                            catReturned = true;
                        }
                        else if (command.Contains("214"))
                        {
                            Console.WriteLine("You knock on door 214.");
                            Console.WriteLine("A man opens the door.\n" +
                                "He says, 'I was getting worried the pizza would get cold! Here's your tip.\n \n" +
                                "Congratulations.  You have solved the mystery of the cheese pizza!\n \n" +
                                "game over");
                            if (catReturned == true)
                            {
                                Console.WriteLine("Congratulations, you returned the missing cat!");
                            }
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
                        command = Console.ReadLine().ToLower();
                        if (command.Contains("exit") || command.Contains("leave"))
                        {
                            Console.WriteLine("which direction do you go?");
                            command = Console.ReadLine();
                            if (currentRoom == Apartments && command.Contains("north"))
                            {
                                currentRoom = EdgeOfTownNorth;
                            }
                            else if (currentRoom == Apartments && command.Contains("south"))
                            {
                                currentRoom = Bank;
                            }
                            else if (currentRoom == Apartments && command.Contains("west"))
                            {
                                Console.WriteLine("There's nothing there.");
                            }
                            else if (currentRoom == Apartments && command.Contains("east"))
                            {
                                Console.WriteLine("There's nothing there.");
                            }
                        }
                        if (command.Contains("213") && catFound == true && catReturned == true)
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
                            if (catReturned == true)
                            {
                                Console.WriteLine("Congratulations, you returned the missing cat!");
                            }
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
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("which direction do you go?");
                        command = Console.ReadLine();
                        if (currentRoom == Apartments && command.Contains("north"))
                        {
                            currentRoom = EdgeOfTownNorth;
                        }
                        else if (currentRoom == Apartments && command.Contains("south"))
                        {
                            currentRoom = Bank;
                        }
                        else if (currentRoom == Apartments && command.Contains("west"))
                        {
                            Console.WriteLine("There's nothing there.");
                        }
                        else if (currentRoom == Apartments && command.Contains("east"))
                        {
                            Console.WriteLine("There's nothing there.");
                        }
                    }

                }

                while (currentRoom == GroceryStore && warmPizza == true)
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
                        Console.WriteLine("You greet Sharlene " + "She sniffs the pizza and reminisces, 'My granddaughter used to deliver pizzas.\n" +
                            "Every other week she'd deliver a cheese pizza to her friend in the apartments.\n");
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
                            currentRoom = EdgeOfTownEast;
                        }
                        else if (currentRoom == GroceryStore && command.Contains("west"))
                        {
                            currentRoom = Pizza;
                        }
                        else if (currentRoom == GroceryStore && command.Contains("north"))
                        {
                            currentRoom = Bank;
                        }
                        else if (currentRoom == GroceryStore && command.Contains("south"))
                        {
                            currentRoom = Park;
                        }

                    }
                }

                while (currentRoom == Park && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    if (posterSeen == true && catFound == false)
                    {
                        Console.WriteLine("You notice an orange tabby cat.");
                        Console.WriteLine("What will you do? \n");
                        command = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine("What will you do? \n");
                        command = Console.ReadLine().ToLower();
                    }
                    if (command.Contains("talk") || command.Contains("approach") || command.Contains("ask"))
                    {
                        Console.WriteLine("You approach the smoking youths. They eye the pizza in your hand and ask you to hand it over.");
                        Console.WriteLine("What will you do?");
                        command = Console.ReadLine();
                        if (command.Contains("pay") || command.Contains("pizza"))
                        {
                            Console.WriteLine("'Ewwwww! Cheese pizza sucks, go away!' is yelled in your face.");
                        }
                        if (command.Contains("hand") || command.Contains("give"))
                        {
                            Console.WriteLine("With shaking hands, you hand over the pizza to the youths. You have failed");
                            Console.WriteLine("GAME OVER");
                            Console.ReadLine();
                            Console.Clear();
                            GameTitle();
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
                while (currentRoom == Pizza && warmPizza == true)
                {
                    Console.WriteLine("You are back at the pizza shop. Your boss is looking at you angrily. Stacy is wiping down a desk, pointedly avoiding eavesdropping.");
                    Console.WriteLine("He yells, 'What are you doing here? Go deliver that pizza!'");
                    Console.WriteLine("What will you do? \n");

                    command = Console.ReadLine().ToLower();
                    if (command.Contains("Stacy"))
                    {
                        Console.WriteLine("Stacy recommends you get back out there and find whoever ordered that pizza.\n" +
                            "The boss won't be happy to see that you're here");
                    }
                    else if (command.Contains("boss"))
                    {
                        Console.WriteLine("Your boss looks red in the face as he starts tapping his watch.");
                    }
                    if (command.Contains("exit") || command.Contains("back") || command.Contains("leave"))
                    {
                        Console.WriteLine("You exit the pizza place.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine().ToLower();
                        if (currentRoom == Pizza && command.Contains("west"))
                        {
                            currentRoom = Suburbs;
                        }
                        else if (currentRoom == Pizza && command.Contains("east"))
                        {
                            currentRoom = GroceryStore;
                        }
                        else if (currentRoom == Pizza && command.Contains("north"))
                        {
                            currentRoom = Bank;
                        }
                        else if (currentRoom == Pizza && command.Contains("south"))
                        {
                            currentRoom = Park;
                        }
                    }
                }
                while (currentRoom == EdgeOfTownNorth && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    strikes += 1;
                    Console.WriteLine("Which direction will you go?");
                    command = Console.ReadLine().ToLower();

                    if (currentRoom == EdgeOfTownNorth && command.Contains("north"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }
                    if (currentRoom == EdgeOfTownNorth && command.Contains("south"))
                    {
                        currentRoom = Apartments;
                    }
                    if (currentRoom == EdgeOfTownNorth && command.Contains("east"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }
                    if (currentRoom == EdgeOfTownNorth && command.Contains("west"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }

                }
                while (currentRoom == EdgeOfTownSouth && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    strikes += 1;
                    Console.WriteLine("Which direction will you go?");
                    command = Console.ReadLine().ToLower();

                    if (currentRoom == EdgeOfTownSouth && command.Contains("north"))
                    {
                        currentRoom = DoctorsOffice;
                    }
                    if (currentRoom == EdgeOfTownSouth && command.Contains("south"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }
                    if (currentRoom == EdgeOfTownSouth && command.Contains("east"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }
                    if (currentRoom == EdgeOfTownSouth && command.Contains("west"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }

                }
                while (currentRoom == EdgeOfTownEast && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    strikes += 1;
                    Console.WriteLine("Which direction will you go?");
                    command = Console.ReadLine().ToLower();

                    if (currentRoom == EdgeOfTownEast && command.Contains("north"))
                    {
                        currentRoom = Bank;
                    }
                    if (currentRoom == EdgeOfTownEast && command.Contains("south"))
                    {
                        currentRoom = Park;
                    }
                    if (currentRoom == EdgeOfTownEast && command.Contains("east"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }
                    if (currentRoom == EdgeOfTownEast && command.Contains("west"))
                    {
                        currentRoom = GroceryStore;
                    }
                }
                while (currentRoom == EdgeOfTownWest && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    strikes += 1;
                    Console.WriteLine("Which direction will you go?");
                    command = Console.ReadLine().ToLower();

                    if (currentRoom == EdgeOfTownWest && command.Contains("north"))
                    {
                        currentRoom = Bank;
                    }
                    if (currentRoom == EdgeOfTownWest && command.Contains("south"))
                    {
                        currentRoom = Park;
                    }
                    if (currentRoom == EdgeOfTownWest && command.Contains("east"))
                    {
                        currentRoom = Suburbs;
                    }
                    if (currentRoom == EdgeOfTownWest && command.Contains("west"))
                    {
                        Console.WriteLine("this leads to nowhere, try a different direction.");
                    }

                }
                while (currentRoom == DoctorsOffice && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("purple") || command.Contains("lipstick"))
                    {
                        Console.WriteLine("You talk to the woman with purple lipstick.\n" +
                            "She remarks, 'Smells like cheese pizza, my friend up north loves cheese pizza!'\n" +
                            "If I knew you better, I'd tell you who it is. But, I don't, so goodbye!");
                    }

                    if (command.Contains("front desk") || command.Contains("admin"))
                    {
                        Console.WriteLine("Administrator says, 'Yum, pizza is my favorite. I'd take that off your hands but I've already had lunch today'.\n");
                    }
                    if (command.Contains("front desk") && command.Contains("cat"))
                    {
                        Console.WriteLine("Oh you're looking for the missing cat? I heard it was last seen at the park.");
                    }
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("you exit the doctor's office.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine().ToLower();
                        if (currentRoom == DoctorsOffice && command.Contains("south"))
                        {
                            currentRoom = EdgeOfTownSouth;
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
                        else
                        {
                            Console.WriteLine("Try a different command.");
                        }
                    }
                
                }
                while (currentRoom == Suburbs && warmPizza == true)
                {
                    Console.WriteLine(currentRoom.Splash);
                    Console.WriteLine("What will you do? \n");
                    command = Console.ReadLine().ToLower();
                    if (command.Contains("talk") || command.Contains("ask") || command.Contains("approach"))
                    {
                        Console.WriteLine("A concerned parent stares you down and scoffs, 'Hey you don't live on this street.\n" +
                            "Also, pizza is bad for you. Please leave'.\n");
                    }
                    if (command.Contains("exit") || command.Contains("leave"))
                    {
                        Console.WriteLine("you exit the suburbs.");
                        Console.WriteLine("Which direction will you go?");
                        command = Console.ReadLine().ToLower();
                        if (currentRoom == Suburbs && command.Contains("west"))
                        {
                            currentRoom = EdgeOfTownWest;
                        }
                        else if (currentRoom == Suburbs && command.Contains("east"))
                        {
                            currentRoom = Pizza;
                        }
                        else if (currentRoom == Suburbs && command.Contains("north"))
                        {
                            currentRoom = Bank;
                        }
                        else if (currentRoom == Suburbs && command.Contains("south"))
                        {
                            currentRoom = Park;
                        }
                    }
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
        public static Room Bank = new Room(
        "You are at the bank. You see a police officer about to greet the bank teller.\n" +
        "You also see an emergency exit and the entrance you just came from.\n",

       new List<string> { "exit", "emergency exit" });

        public static Room Park = new Room(
                "You walk into a park. You see a group of smoking youths who stare at you menacingly \n",
                new List<string> { "exit" }
                );
        public static Room Apartments = new Room( // 213 - no answer, unhelpful / 214 ordered the pizza! / 215 - someone opens the door, helpful 
                "You are at the apartments." + "You see 3 doors, room 213, 214, and 215. You can also see stairs.",
                new List<string> { "stairs", "emergency exit" }
                );
        public static Room Pizza = new Room( // if re-entering the pizz place only one prompt, boss asks "what are you doing back here? go deliver  the pizza" 
                "You are at the pizza parlor you work at. You see your angry boss, and your coworker, Stacy. You also see the entrance you just came from",
                new List<string> { "exit" }
                );
        public static Room EdgeOfTownNorth = new Room(
            "You have reached the edge of town.  That's not good! Better try a different direction.",
            new List<string> { "exit" }
            );

        public static Room EdgeOfTownSouth = new Room(
            "You have reached the edge of town.  That's not good! Better try a different direction.",
            new List<string> { "exit" }
            );

        public static Room EdgeOfTownEast = new Room(
            "You have reached the edge of town.  That's not good! Better try a different direction.",
            new List<string> { "exit" }
            );

        public static Room EdgeOfTownWest = new Room(
            "You have reached the edge of town.  That's not good! Better try a different direction.",
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
            "You enter the doctors office south of the park. A front desk administrator smiles at you.\n" +
            "A lady in purple lipstick sits in the waiting section.  You also see the entrance/exit behind you.\n",
            new List<string> { "exit" }
            );
    }
    }




