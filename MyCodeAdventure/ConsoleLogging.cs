using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    internal static class ConsoleLogging
    {
        public static void OpenAdventure()
        {
            Console.WriteLine("WELCOME TO CODE ADVENTURES!");
            Console.WriteLine();
            Console.WriteLine("You, a great adventurer, come home after a long journey to find the " +
                    "princess has been missing for weeks. Being as famous as you are," +
                     "the king employs your help after all his resources seemingly have been exhausted. " +
                      "The only clues that you have are a bag of uncut gems that were found hidden in her" +
                      " closet and her last known location - the town square.");
            Console.WriteLine();
        }
        public static void ChooseCharacter()
        {
           
            Console.WriteLine("Choose Your Class:");
            string[] allclass = { "1: Striker", "2: Rouge", "3: Wizard", "4: Monk" };
            for (int i = 0; i < allclass.Length; i++)
            {
                var selectable = allclass[i];
                Console.WriteLine(selectable);
            }

        }
        public static void CharacterSelected()
        {
            string[] stats = { "Strength:10 Stamina:8 Dexterity:6 Intelligence:4", "Strength:6 Stamina:9 Dexterity:10 Intelligence:7",
                "Strength:4 Stamina:7 Dexterity:7 Intelligence:10", "Strength:6 Stamina:9 Dexterity:9 Intelligence:7" };
            string chosen = Console.ReadLine();
            switch (chosen)
            {
                case "1":
                    Console.WriteLine($"You have chosen the Striker class! The strongest and " +
                   $"bravest of all!");
                    Console.WriteLine();
                    Console.WriteLine($"Your stats are currently:");
                    Console.WriteLine();
                    Console.WriteLine($"{stats[0]}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Farewell brave warrior!");
                    break;
                case "2":
                    Console.WriteLine($"You have chosen the Rouge class! The quick and cunning!");
                    Console.WriteLine();
                    Console.WriteLine($"Your stats are as follows:");
                    Console.WriteLine();
                    Console.WriteLine($"{stats[1]}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Farewell cunning rouge!");
                    break;
                case "3":
                    Console.WriteLine("You have chosen the Wizard class! The wise and fearless!");
                    Console.WriteLine();
                    Console.WriteLine($"Your stats are as follows:\n\n{stats[2]}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Farewell wise wizard!");
                    break;
                case "4":
                    Console.WriteLine($"You have chosen the Monk class! The enlightend and " +
                    $"powerfull!");
                    Console.WriteLine();
                    Console.WriteLine($"Your stats are as follows:\n\n{stats[3]}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Farewell monk, may your spirit guide you!");
                    break;
            }

        }
        public static void BeginJourney()
        {
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();

            TownScene();
            Console.WriteLine();
            Console.WriteLine("Please choose your path:");
            string[] townPath = { "1: The Pub", "2: The Market", "3: The Church", "4: Leave Town" };
            for (int x = 0; x < townPath.Length; x++)
            {
                Console.WriteLine(townPath[x]);
            }
            string decision1 = Console.ReadLine();
            switch (decision1)
            {
                case "1":
                    Console.WriteLine("The Pub is pretty empty, but bar tender is behind the bar cleaning glasses. Classic. Would you like to speak with the bar tender or leave the pub?");
                    string[] pubChoice = { "1: Speak with the Bartender", "2: Leave the pub", "3: Buy a bottle of Gin(You havent made money yet!)", "4: Back to the town square" };
                    foreach (string choice in pubChoice)
                    {
                        Console.WriteLine(choice);

                    }
                    string pubDecision = Console.ReadLine();
                    switch (pubDecision)
                    {
                        case "1":
                            BarTalk();
                            Console.WriteLine("Please press enter to exit the pub");
                            Console.ReadLine();
                            TownScene();
                            break;
                        case "2":
                            Console.WriteLine("You are entering the Town Square!");
                            Console.WriteLine();
                            TownScene();
                            break;
                        case "3":
                            YoureBroke();
                            break;
                        default:
                            TownScene();
                            break;
                    }
                    break;
                case "2":
                    MarketScene();
                    Console.WriteLine();
                    Console.WriteLine("Please select answer 1 or 2");

                    string[] marketChoice = { "1: Yes, I have found her, she is safe and sound.", "2: No, I have yet to find her." };
                    foreach (string answer in marketChoice)
                    {
                        Console.WriteLine(answer);
                    }
                    string something = "Something";
                    something.Substring(0, -1);

                    var marketDecision = Console.ReadLine();
                    switch (marketDecision)
                    {
                        case "1":

                    }
                    break;

                   

            }
           
        }
        public static void TownScene()
        {
          Console.WriteLine("The town square.Behind you is the castle gate.To your left is the pub and " +
              "market; to your right is the church;" +
                        " and in front of you is the road out of town. Where would you like to go next Adventurer?");
        }

        public static void BarTalk()
        {
            Console.WriteLine("Hello, stranger what can i do for you?");
            string barChoice1 = "Can I ask what you know about the princess?";
            Console.WriteLine($"{barChoice1} Please press enter to find out more!");
            var answer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You speak with the bar tender and ask what he knows about the princess. He says: All that I know is that a few nights a week, she would come in here and buy a bottle of gin " +
                "which she wouldnt drink. No, she would pour it over her hands to get tree sap off. The king doesnt allow alcohol in his castle but what was she doing with all of that sap in her hands ? ");
        }
        public static void YoureBroke()
        {
            Console.WriteLine("Sorry, you dont have the coin for that!");
        }
        public static void MarketScene()
        {
            var marketgreet = "Adventurer! Adventurer! Have you found the princess yet? We are so worried for her safety?";
            Console.WriteLine($"The market is not busy at this time of day as most people are working in the fields, but there are those who are getting their wares read to be sold. A little girl, and her mother selling fresh fish, greet you and say, {marketgreet}");
        }




    }   

}
