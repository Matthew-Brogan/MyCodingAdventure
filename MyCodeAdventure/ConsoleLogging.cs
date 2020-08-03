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

        public static void MarketWin()
        {
            Console.WriteLine("Our prayers are with you Adventurer. The princess was so kind to us. She would purchase four fish from us a few times a " +
                    "week before she would head out of town on one of her many 'walks.' She said the fish were for any hungry animals she came across. " +
                    "She was our best customer. Would you like any fish today Adventurer?");
            string[] buyOrLeave = { "1: Buy some fish.", "2: Leave the market" };
            foreach (string option in buyOrLeave)
            {
                Console.WriteLine(option);
            }
            buyOrLeave[0] = "1";
            buyOrLeave[1] = "2";
            string yOrN = Console.ReadLine();
            if (yOrN == buyOrLeave[0])
            {
                YoureBroke();
            }
            else
            {
                Console.WriteLine("You are now exiting The Market");
            }
        }
        public static void ChurchScene()
        {
            Console.WriteLine("The Church, which is dim inside, is lit by colorful sunlight coming through stained - glass windows and small candles in the front of the church.A priest is praying near the front of the church.");
            Console.WriteLine();
            Console.WriteLine("What would you do?");
            string[] churchMainChoice = { "1: Pray", "2: Ask the priest about the princess", "3: Steal the money from the poor box", "4: Leave the Church" };
            foreach (string option in churchMainChoice)
            {
                Console.WriteLine(option);
            }
            churchMainChoice[0] = "1";
            churchMainChoice[1] = "2";
            churchMainChoice[2] = "3";
            churchMainChoice[3] = "4";
            var churchDecision = Console.ReadLine();
            if (churchDecision == churchMainChoice[0])
            {
                Console.WriteLine("Pray. You kneel down to pray when suddenly in front of you a heavenly being appears and says, \"Dear Adventurer, you are the answer to many prayers.Heaven is ready to supply you with your needs for such a noble person on such a noble quest.");
                string[] prayerRewards = { "1: The Sword of Aleitheia + 3 Damage", "2: Elixir of Vitas  - Restores health to 100", "3: Boots of  Guidance – helps you know which way to go – use 3 times? \"Know, Adventurer, that the Divine Presence will always be watching over you.\" With that the vision is ended." };
                foreach (string prayerBuff in prayerRewards)
                {
                    Console.WriteLine(prayerBuff);
                }
                prayerRewards[0] = "1";
                prayerRewards[1] = "2";
                prayerRewards[2] = "3";
                Console.WriteLine("Please select your reward");
                var buffSelect = Console.ReadLine();
                if (buffSelect == prayerRewards[0])
                {
                    Console.WriteLine("You have chosen The Sword of Aleitheia, Your damage base has increased!");
                    Console.WriteLine();
                    ChurchBuffScene();
                }
                else if (buffSelect == prayerRewards[1])
                {
                    Console.WriteLine("You have chosen The Elixir of Vitas! This is a powerful healing potion!");
                    Console.WriteLine();
                    ChurchBuffScene();
                }
                else
                {
                    Console.WriteLine("You have chosen The Boots of Guidance! These can guide your way anytime you feel lost!");
                    Console.WriteLine();
                    ChurchBuffScene();
                }
            }
            else if (churchDecision == churchMainChoice[1])
            {
                Console.WriteLine("You ask about the princess.He says, \"We have been praying for her for so long. She would come in a few times a week to pray and then purchase some candles we make here at church. I was always curious why she would buy so many, but I don't know. Adventurer, I see that you are without any supplies for such a journey, may I assist you with some supplies, we have them from the funeral from the last adventurer");
                string[] askThePriest = { "1: Sword of Fallen Soldier: +1 Damage", "2: Small Vile of Healing : +25hp", "3: Minor Boots of the Tracker: Single use boots to guide your way." };
                foreach (string option in askThePriest)
                {
                    Console.WriteLine(option);
                }
                askThePriest[0] = "1";
                askThePriest[1] = "2";
                askThePriest[2] = "3";
                Console.WriteLine("Please select your reward");
                var lowerBuff = Console.ReadLine();
                if (lowerBuff == askThePriest[0])
                {
                    Console.WriteLine("You\'ve chosen The Sword of Fallen Soldier! Your attack has increased!");
                    Console.WriteLine();
                    Console.WriteLine("Please press enter to exit the church:");
                    TownScene();

                }
            }
        }
        public static void ChurchBuffScene()
        {
            Console.WriteLine("The priest sees that you have had a vision and says, \"Adventurer, you are certainly the answer to many prayers.Please let me assist you on you quest with some money.\" The priest goes to the poor box and gets the money out of it and puts it in a moneybag be pulls from his belt.\" It is only 100 coins but it should be a good start.");
            Console.WriteLine("You\'ve recieved 100 coin");
        }
        public static void MarketMistake()
        {
            Console.WriteLine("Guards with joyous looks on their faces approach, while you see others run back to the " +
                "castle announcing the good news. " +
                "The church bells are rung as the crowd swells around you. Do you want to:");
            string[] mistakeChoice = { "1: Stay and wait for the king.", "2: Run away down the road out of town." };
            foreach (string choice in mistakeChoice)
            {
                Console.WriteLine(choice);
            }
            mistakeChoice[0] = "1";
            mistakeChoice[1] = "2";
            var marketDecision = Console.ReadLine();
            if (marketDecision == mistakeChoice[0])
            {
                Console.WriteLine("The king and queen arrive, surrounded by a large group of well - " +
                    "armed soldiers.He is crying out, \"My Daughter, my daughter! Where is she, my little my" +
                    " life? My daughter, my daughter, my love!?\" There is no escape now, Adventurer.The king," +
                    " heartbroken of course, and tired by so many nights of worry, has you arrested and puts you" +
                    " to death on the spot.So is the fate of all who would lie to the king on " +
                    "such an intimate matter.GAME OVER");

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
            foreach (string attack in sAttack)
            {
                Console.WriteLine(attack);
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
