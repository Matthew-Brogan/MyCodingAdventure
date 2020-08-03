using MyCodeAdventure.Story.Base_Story;
using MyCodeAdventure.Story.Choices;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace MyCodeAdventure
{
    internal static class ConsoleLogging
    {
        private readonly static string[] sAttack = { "1 : Light", "A light attack 4-6hp", "2: Heavy", "A Heavy attack 5-8hp", "3 : Special", "Special attack, powerful but limited use: Charge at the enemy with a furious howl swinging wildly for 10hp to all nearby enemies" };//striker attacks

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
            List<string> allclass = new List<string>() { "1: Striker", "2: Rouge", "3: Wizard", "4: Monk" };
            for (int i = 0; i < allclass.Count; i++)
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
            Utilities.EnterIfYouDare();

            IntroChoices.TownScene();
            IntroChoices.TownPath();

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
    }
}
       
        