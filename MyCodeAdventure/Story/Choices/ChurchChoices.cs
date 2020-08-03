using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story.Choices
{
    internal static class ChurchChoices
    {
        public static void ChurchScene()
        {
            ChurchDoor();
            ChurchOption();
            ChurchInterax();

        }
        public static void ChurchBuffScene()
        {
            Console.WriteLine("The priest sees that you have had a vision and says," +
                " \"Adventurer, you are certainly the answer to many prayers. " +
                "Please let me assist you on you quest with some money.\" The priest goes to the poor box and gets" +
                " the money out of it and puts it in a moneybag be pulls from his belt.\" It is only 100 coins but it should be a good start.");
            Console.WriteLine("You\'ve recieved 100 coin");
        }
        public static void ChurchDoor()
        {
            Console.WriteLine("The Church, which is dim inside, is lit by colorful sunlight coming through stained - " +
               "glass windows and small candles in the front of the church.A priest is praying near the front of the church.");
            Console.WriteLine();
            Console.WriteLine("What would you do?");
        }
        public static void ChurchOption()
        {
            string[] churchMainChoice = { "1: Pray", "2: Ask the priest about the princess", "3: Steal the money from the poor box", "4: Leave the Church" };
            foreach (string option in churchMainChoice)
            {
                Console.WriteLine(option);
            }
        }
        public static void ChurchInterax()
        {
            var churchDecision = Console.ReadLine();
            switch (churchDecision)
            {
                case "1":

                    Prayer();

                    PrayerRewards();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;

                case "2":
                    AskThePriest();
                    LowerReward();
                    break;
                    
                
            }
        }
        public static void Prayer()
        {
            Console.WriteLine("Pray. You kneel down to pray when suddenly in front of you a heavenly being appears and says," +
                    " \"Dear Adventurer, you are the answer to many prayers.Heaven is ready to supply you with your needs for such a noble person on such a noble quest.");
            string[] prayerRewards = { "1: The Sword of Aleitheia + 3 Damage", "2: Elixir of Vitas  - Restores health to 100",
                "3: Boots of  Guidance – helps you know which way to go – use 3 times? \"Know, Adventurer, that the Divine Presence" +
                " will always be watching over you.\" With that the vision is ended." };
            foreach (string prayerBuff in prayerRewards)
            {
                Console.WriteLine(prayerBuff);
            }
        }
        public static void PrayerRewards()
        {
            Console.WriteLine("Please select your reward");
            var buffSelect = Console.ReadLine();
            switch(buffSelect)
            {
                case "1":
                    TakenSword();
                    ChurchBuffScene();
                    break;
                case "2":
                    TakenElixir();
                    ChurchBuffScene();
                    break;
                case "3":
                    TakenBoots();
                    ChurchBuffScene();
                    break;
            }
        }
        public static void TakenSword()
        {
            Console.WriteLine("You have chosen The Sword of Aleitheia, Your damage base has increased!");
            Console.WriteLine();
        }
        public static void TakenElixir()
        {
            Console.WriteLine("You have chosen The Elixir of Vitas! This is a powerful healing potion!");
            Console.WriteLine();
        }
        public static void TakenBoots()
        {
            Console.WriteLine("You have chosen The Boots of Guidance! These can guide your way anytime you feel lost!");
            Console.WriteLine();
        }
        public static void AskThePriest()
        {
            Console.WriteLine("You ask about the princess.He says, \"We have been praying for her for so long. She would come in a few times a week to pray and then purchase some candles we make here at church. I was always curious why she would buy so many, but I don't know. Adventurer, I see that you are without any supplies for such a journey, may I assist you with some supplies, we have them from the funeral from the last adventurer");
            string[] askThePriest = { "1: Sword of Fallen Soldier: +1 Damage", "2: Small Vile of Healing : +25hp", "3: Minor Boots of the Tracker: Single use boots to guide your way." };
            foreach (string option in askThePriest)
            {
                Console.WriteLine(option);
            }
        }
        public static void LowerReward()
        {
            Console.WriteLine("Please select your reward");
            var lowerBuff = Console.ReadLine();
            switch(lowerBuff)
            {
                case "1":
                    LowerSword();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;
                case "2":
                    SmallPotion();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;
                case "3":
                    TrackerBoots();
                    IntroChoices.TownScene();
                    IntroChoices.TownPath();
                    break;

            }
        }
        public static void LowerSword()
        {
            Console.WriteLine("You\'ve chosen The Sword of Fallen Soldier! Your attack has increased!");
            Console.WriteLine();
            Console.WriteLine("Please press enter to exit the church:");
        }
        public static void SmallPotion()
        {
            Console.WriteLine("You\'ve selected the Small Vile of Healing! This potion heals for 25 points!");
            Console.WriteLine();
            Console.WriteLine("Please press enter to exit the church:");
        }
        public static void TrackerBoots()
        {
            Console.WriteLine("You\'ve chosen the Boots of The Tracker! These boots charge once per level to guide your path!");
            Console.WriteLine();
            Console.WriteLine("Please press enter to exit the church:");
        }
    }     
}
