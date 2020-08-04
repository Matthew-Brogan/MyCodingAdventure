using MyCodeAdventure.Story.Base_Story;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story.Choices
{
    public static class IntroChoices
    {

        public static void TownScene()
        {
            Console.WriteLine("The town square.Behind you is the castle gate.To your left is the pub and " +
                "market; to your right is the church;" +
                          " and in front of you is the road out of town. Where would you like to go next Adventurer?");
        }
        public static void TownPath()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose your path:");
            string[] townPath = { "1: The Pub", "2: The Market", "3: The Church", "4: Leave Town" };
            for (int x = 0; x < townPath.Length; x++)
            {
                Console.WriteLine(townPath[x]);
            }
        }
       
        


    }
}
