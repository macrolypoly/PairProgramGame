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
                Console.WriteLine("Congratulations on setting up a pizza shop in a new town");
                Console.ReadKey();
                Console.WriteLine("On opening day, the phone rings and you receive your first pizza delivery order");
                Console.ReadKey();
                Console.WriteLine("They hang up before you can get a name or address.");
                Console.ReadKey();
                Console.WriteLine("You have just moved in, and have no friends, no family, and no directions. Yikes!");
                Console.ReadKey();
                Console.WriteLine("In order to succeed you must venture forth and deliver this cheese pizza without fail.");
                Console.ReadKey();
                Console.WriteLine("With cheese pizza in-hand, which direction will you go? (North, South, East, West)");

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
                        else if (command.StartsWith("exit"))
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
                            if (command.Contains("213"))
                            {
                                Console.WriteLine("You knock on door 213.");
                                Console.WriteLine("You wait a couple of minutes. No one answers the door.");
                            }
                            else if (command.Contains("214"))
                            {
                                Console.WriteLine("You knock on door 214.");
                                Console.WriteLine("A man opens the door.\n" + "He says, 'I was getting worried the pizza would get cold! Here's your tip.");
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
                                Console.WriteLine("A man opens the door.\n" + "He says, 'I was getting worried the pizza would get cold! Here's your tip.");
                                // game done
                            }
                            else if (command.Contains("215"))
                            {
                                Console.WriteLine("You knock on door 215.");
                                Console.WriteLine("A woman answers the door. \n" + "She says, 'I think you have the wrong apartment, sorry.'");

                            }
                        }
                    }
                    while (currentRoom == Park)
                    {
                        Console.WriteLine(currentRoom.Splash);
                        Console.WriteLine("What will you do? \n");
                        command = Console.ReadLine().ToLower();
                        if (command.StartsWith("talk"))
                        {
                            Console.WriteLine("You approach the teens. They eye the pizza in your hand and ask you to hand it over.");
                            Console.WriteLine("What will you do?");
                            command = Console.ReadLine();
                            if (command.StartsWith("hand over"))
                            {
                                Console.WriteLine("You hand over the pizza to the teenagers.");
                                warmPizza = false;
                            }
                            if (command.StartsWith("run"))
                            {
                                Console.WriteLine("You run away.");
                            }
                        }
                        if (command.StartsWith("pet"))
                        {
                            Console.WriteLine("You pet the unseen cat.");
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
                            Console.WriteLine("You greet Sharlene " + "She says, 'I used to deliver pizzas. Every other week I'd deliver a cheese pizza to the apartments.");
                        }
                        if (command.StartsWith("exit"))
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
                        if (command.StartsWith("exit"))
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
                    Console.WriteLine("game over");
                    Console.Clear();
                    GameTitle();
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
         "u are at the bank. u see 3 people, a police officer in a hat, a woman with purple lipstick, and the bank teller.\n" +
         "You also see an emergency exit and the entrance you just came from.",

        new List<string> { "exit", "emergency exit" });
        
        public static Room Park = new Room( // option 1) talk to all teenagers at once, they are unhelpful 
                "You walk into a park. You see a group of smoking teenagers who stare at you menacingly",
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
            new List<string> { "exit"}
            );
        public static Room GroceryStore = new Room(
            "You have reached the grocery store. You spot two ladies, Rebecca and Sharlene.",  // option 1) talk to rebecca (not helpful)  option 2) talk to Sharlene (offers a clue) 
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


