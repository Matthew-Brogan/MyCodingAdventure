using MyCodeAdventure.Story.Base_Story;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story.Choices
{
    public static class MarketChoices
    {

        public static void MarketCase2()
        {
            MarketScene();
            MarketTruthOrDare();

            var marketDecision = Console.ReadLine();
            switch (marketDecision)
            {
                case "1":
                    MarketMistake();
                    break;
                case "2":
                    MarketWin();
                    break;


            }

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
        public static void MarketWin()
        {
            Console.WriteLine("Our prayers are with you Adventurer. The princess was so kind to us. She would purchase four fish from us a few times a " +
                    "week before she would head out of town on one of her many 'walks.' She said the fish were for any hungry animals she came across. " +
                    "She was our best customer. Would you like any fish today Adventurer?");
            Pescatarian();
            CantAffordThis();
        }
        public static void MarketMistake()
        {
            Console.WriteLine("Guards with joyous looks on their faces approach, while you see others run back to the " +
                "castle announcing the good news. " +
                "The church bells are rung as the crowd swells around you. Do you want to:");
            StayOrRun();

            MarketSwitch();



        }
        public static void MarketTruthOrDare()
        {
            Console.WriteLine();
            Console.WriteLine("Please select answer 1 or 2");

            string[] marketChoice = { "1: Yes, I have found her, she is safe and sound.", "2: No, I have yet to find her." };
            foreach (string answer in marketChoice)
            {
                Console.WriteLine(answer);
            }
        }
        public static void Pescatarian()
        {
            string[] buyOrLeave = { "1: Buy some fish.", "2: Leave the market" };
            foreach (string option in buyOrLeave)
            {
                Console.WriteLine(option);
            }
        }
        public static void CantAffordThis()
        {
            string yOrN = Console.ReadLine();
            switch (yOrN)
            {
                case "1":
                    YoureBroke();
                    break;
                case "2":
                    Utilities.ExitToTown();
                    break;
            }

        }
        public static void StayOrRun()
        {
            string[] mistakeChoice = { "1: Stay and wait for the king.", "2: Run away down the road out of town." };
            foreach (string choice in mistakeChoice)
            {
                Console.WriteLine(choice);
            }
        }
        public static void MarketSwitch()
        {
            var marketDecision = Console.ReadLine();
            switch (marketDecision)
            {
                case "1":
                    Console.WriteLine("The king and queen arrive, surrounded by a large group of well - " +
                    "armed soldiers.He is crying out, \"My Daughter, my daughter! Where is she, my little my" +
                    " life? My daughter, my daughter, my love!?\" There is no escape now, Adventurer.The king," +
                    " heartbroken of course, and tired by so many nights of worry, has you arrested and puts you" +
                    " to death on the spot.So is the fate of all who would lie to the king on " +
                    "such an intimate matter.GAME OVER");
                    break;
                case "2":
                    Utilities.ExitTown();
                    break;


            }

        }
        public static void FirstFight()
        {

            Console.WriteLine($"Press enter to continue: ");
            Console.ReadLine();
            Console.WriteLine("You exit the town center and wonder into the surrounding forest," +
                " \nAs you go deeper in you grow tired and decide to have a quick rest under an ancient tree." +
                "\n You are rudely awakened by the sound of two familiar voices approaching....");
            Console.WriteLine("Bandits, and henchman of an old ally since turned enemy," +
                "\n the men approach, you have the element of suprise! Attack now!");
            Console.WriteLine();
           // foreach (string attack in sAttack)
            {
           //     Console.WriteLine(attack);
            }
            Console.WriteLine();
            Console.WriteLine("Select your attack!");
            // heavy attack is slower and may be easier to block but does have knockback chance:**suprise first att success, next att blocked
            // light fast but weak more difficult to block ** incresed crit chance, if pick light crit for first, and roll random to block following
            // special unleash hell**must have selected sword alethia allow special otherwise no** slay 2 enemies at once but enrage all others

            var usedAttack = Console.ReadLine();
        }
    }
}
