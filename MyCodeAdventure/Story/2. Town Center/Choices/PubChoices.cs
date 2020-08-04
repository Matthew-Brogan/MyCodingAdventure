using MyCodeAdventure.Story.Base_Story;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story.Choices
{
    class PubChoices
    {
        public static void PubCase1()
        {

            PubDoor();
            string pubDecision = Console.ReadLine();
            switch (pubDecision)
            {
                case "1":
                    TownBartender();
                    break;
                case "2":
                    Utilities.ExitToTown();
                    break;
                case "3":
                    Utilities.YoureBroke();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;
                default:
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;
            }
        }
        public static void PubDoor()
        {
            Console.WriteLine("The Pub is pretty empty, but bar tender is behind the bar cleaning glasses. Classic. Would you like to speak with the bar tender or leave the pub?");
            string[] pubChoice = { "1: Speak with the Bartender", "2: Leave the pub", "3: Buy a bottle of Gin(You havent made money yet!)", "4: Back to the town square" };
            foreach (string choice in pubChoice)
            {
                Console.WriteLine(choice);

            }
        }
        public static void TownBartender()
        {
            BarTalk();
            Console.WriteLine("Please press enter to exit the pub");
            Console.ReadLine();
            IntroChoices.TownScene();
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
