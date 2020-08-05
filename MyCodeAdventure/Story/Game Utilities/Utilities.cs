using MyCodeAdventure.Story.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story.Base_Story
{
    internal static class Utilities
    {
        public static void ExitToTown()
        {
            Console.WriteLine("You are entering the Town Square!");
            Console.WriteLine();
            IntroChoices.TownScene();
            IntroChoices.TownPath();
        }
        public static void YoureBroke()
        {
            Console.WriteLine("Sorry, you dont have the coin for that!");
        }
        public static void EnterIfYouDare()
        {
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
        }
        public static void ExitTown()
        {
            Console.WriteLine($"Press enter to continue: ");
            Console.ReadLine();
            Console.WriteLine("You exit the town center and wonder into the surrounding forest," +
                " \nAs you go deeper in you grow tired and decide to have a quick rest under an ancient tree." +
                "\n You are rudely awakened by the sound of two familiar voices approaching....");
        }
        
    }
}
