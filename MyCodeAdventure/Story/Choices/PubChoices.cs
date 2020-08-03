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
            ConsoleLogging.BarTalk();
            Console.WriteLine("Please press enter to exit the pub");
            Console.ReadLine();
            IntroChoices.TownScene();
        }
    }
}
