using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace MyCodeAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO 
             *Story
                    /*Basic story line: Starts with the king hiring you, 
                    a great adventurer, to find the lost princess. 
                        *here we can have choices with the king, 
                        *encounters with the people in the square, 
                        *a fight with a drunkerd at the pub*
                    this take you to the time square. through clues discoved 
                    there you are led to the dark enchanted forest of dumblewood. 
                           *here we can have an encpunter with low 
                           *level badies, gain some stats, and loot.*
                    while in the woods you come upon a well know gem cave
                    (tied to the gems the princess had), you now begone your 
                    journey into the cave.
                         *here we can have more choices and battles with low-med enemies*
                    buried deep in the cave is a secret dungeon held by 
                    a group of heritic cult members.
                            *here we can have more battles. here is where the
                            *choices of good and bad can really pick up.*
                    You find the princess in the dungeon and take her out of the 
                    jail cell and return to the king.
                            *here we can have the choice to take her to the king, 
                            *sacrafice her to the dark lord dagon"probably need a dif name to not rip of Skyrim"*

         
                    *same story line (come up iwht a story line)
                    *Dan E. Idea:"You, a great adventurer, come home after a long journey to find the 
                    *princess has been missing for weeks. Being as famous as you are, 
                    *the king employs your help after all his resources seemingly have been exhausted. 
                    *The only clues that you have are a bag of uncut gems that were found hidden in her 
                    *closet and her last known location - the town square. - 
                    *Just an idea for an opener - working on the town square scene."
                        *town
                        *dungeon
                        *quest
                    *class has effects on the story(class effect npc interactions and quest choice)
                    *stats effects on the story line
                            *you have to have certian stats to do sertian things
                            *if your stats are too low you cant do some options
                    *choiced
                           *effects of the choices (see effects)
                    *Objects
                           *weapons (up damage)
                           *potions (heal and boost mana)
                           *Armor (take less damage/ some lowers dex./incumerance?/stamina)
                           *trophies (Helps honor & Charisma)
             *classes
                    *different classes ( honor system effects class. 3 classes per class)
                            (3 honor levels : Knight(good) - citizen(middle 5%) - Heretic(bad))
             
                            *striker
                            *Rouge
                            *Wizard
                            *Monk
                    *different stats
                            *health
                                *effected by damage and potions
                            *strength 
                                *effected by damage and potions
                            *dexterity
                                *effected by specific damage(leg injury) 
                            *intelegence
                                *effected by choices(read book...)
                            *honor
                                *effected by choices
                            *charisma
                                *effected by honor level
                            *mana
                                *effected by intellegence and stamina
                            *stamina
                                *effected by health
                            *virtue 
                                *effected by honor
             *effects
                    *hit/strength points(buffs and boons)
                    *health points
                    *honor points
                    *charisma points
                    *mana points
                    *dexterity points
                    *intellegence points
                    *
               *develop ideas for the enemy and classes(minions and adds vs boss/elite)
             */
            Console.WriteLine("WELCOME TO CODE ADVENTURES!");
            Console.WriteLine();
            Console.WriteLine("You, a great adventurer, come home after a long journey to find the " +
                    "princess has been missing for weeks.Being as famous as you are," +
                     "the king employs your help after all his resources seemingly have been exhausted. " +
                      "The only clues that you have are a bag of uncut gems that were found hidden in her" +
                      " closet and her last known location - the town square.");
                     //Just an idea for an opener -working on the town square scene.

            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Choose Your Class:");
            string[] allclass = { "1: Striker", "2: Rouge", "3: Wizard", "4: Monk" };
            string[] stats = { "Strength:10 Stamina:8 Dexterity:6 Intelligence:4", "Strength:6 Stamina:9 Dexterity:10 Intelligence:7", "Strength:4 Stamina:7 Dexterity:7 Intelligence:10", "Strength:6 Stamina:9 Dexterity:9 Intelligence:7" };
            string[] yesOrNo = { "yes", "no" };
            string[] sAttack = { "Light", "A light attack 4-6hp", "Heavy", "A Heavy attack 5-8hp", "Special", "Special attack, powerful but limited use: Charge at the enemy with a furious howl swinging wildly for 10hp to all nearby enemies" };//striker attacks
            string[] rAttack = { "Light: 3-5", "Heavy: 4-7hp", "Special: Dance around with furious grace and speed, slicing and dicing all for 10 hp" };//rouge attacks


            for (int i = 0; i < allclass.Length; i++)
            {
                var selectable = allclass[i];
                Console.WriteLine(selectable);
            }
            string chosen = Console.ReadLine();
            allclass[0] = "1";
            allclass[1] = "2";
            allclass[2] = "3";
            allclass[3] = "4";
            if (chosen == allclass[0])
            {
                Console.WriteLine($"{name}, You have chosen the Striker class! The strongest and " +
                    $"bravest of all!");
                Console.WriteLine();
                Console.WriteLine($"Your stats are as follows:");
                Console.WriteLine($"{stats[0]}");
                Console.WriteLine();
                Console.WriteLine("Farewell brave warrior!");
            }
            if (chosen == allclass[1])
            {
                Console.WriteLine($"{name}, You have chosen the Rouge class! The quick and cunning!");
                Console.WriteLine($"Your stats are as follows:");
                Console.WriteLine($"{stats[1]}");
                Console.WriteLine("Farewell cunning rouge!");
            }
            if (chosen == allclass[2])
            {
                Console.WriteLine($"{name}, You have chosen the Wizard class! The wise and fearless!");
                Console.WriteLine($"Your stats are as follows:{stats[2]}");
                Console.WriteLine("Farewell wise wizard!");
            }
            if (chosen == allclass[3])
            {
                Console.WriteLine($"{name}, You have chosen the Monk class! The enlightend and " +
                    $"powerfull!");
                Console.WriteLine($"Your stats are as follows:{stats[3]}");
                Console.WriteLine("Farewell monk, may your spirit guide you!");
            }
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            if (chosen == allclass[0] || chosen == allclass[1] || chosen == allclass[2] || chosen == allclass[3])
            {
                TownScene();
                Console.WriteLine();
                Console.WriteLine("Please choose your path:");
                string[] townPath = { "1: The Pub", "2: The Market", "3: The Church", "4: Leave Town" };
                for (int x = 0; x < townPath.Length; x++)
                {
                    Console.WriteLine(townPath[x]);
                }
                townPath[0] = "1";
                townPath[1] = "2";
                townPath[2] = "3";
                townPath[3] = "4";
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
                        pubChoice[0] = "1";
                        pubChoice[1] = "2";
                        pubChoice[2] = "3";
                        pubChoice[3] = "4";
                        string pubDecision = Console.ReadLine();
                        if(pubDecision == pubChoice[0])
                        {
                            BarTalk();
                            Console.WriteLine("Please press enter to exit the pub");
                            Console.ReadLine();
                            TownScene();
                        }
                        else if (pubDecision == pubChoice[1])
                        {
                            Console.WriteLine("You are entering the Town Square!");
                            Console.WriteLine();
                            TownScene();
                        }
                        else if(pubDecision == pubChoice[2])
                        {
                            YoureBroke();
                        }
                        else
                        {
                            TownScene();
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
                        marketChoice[0] = "1";
                        marketChoice[1] = "2";

                        var marketDecision = Console.ReadLine();
                        if(marketDecision == marketChoice[0])
                        {
                            Console.WriteLine($"Praise God one and all, our prayers have been heard!\" the girl announces.\"Alert the king and the king\'s men that the princess is safe. Certainly, Adventurer the king will reward you handsomely for your bravery and skill!");
                            MarketMistake();
                        }
                        else
                        {
                            MarketWin();
                        }
                        break;
                    case "3":
                        ChurchScene();
                        break;


                }
            }
            
            
            {

            }
            //if (decision1 == )
            //{
            //    Console.WriteLine("Which attack would you like to use?");

            //    for (int j = 0; j < sAttack.Length; j++)
            //    {
            //        string strikerAttack = sAttack[j];
            //        Console.WriteLine(strikerAttack);

            //    }
            //    string cAttack = Console.ReadLine();
            //    if (cAttack == sAttack[0])
            //    {
            //        Console.WriteLine("Youve grazed your opponent for 4 hp.");
            //        Console.WriteLine("Beware, the enemy surrounds you! Use your special attck now!!");
            //    }
            //    string finisher = Console.ReadLine();
            //    if (finisher == sAttack[2])
            //    {
            //        Console.WriteLine("HA HA you really showed them!");
            //        Console.WriteLine("A voice coming from inside the tavern bellows");
            //        Console.WriteLine("Let's go see who'd like to celebrate with us!");
            //        Console.WriteLine("As you walk in you notice a large soldier waving in your direction" +
            //            "as you approach you are greeted with a tall jar of meade and a firm handhake.");

            //    }


            //}
            //else
            //{
            //    //dark path start
            //}

            //if (chosen == allclass[1])
            //{
            //    Console.WriteLine("Stranger!... Help me PLEEEEASSE!");
            //    Console.WriteLine("Just coming out of the storm into the tavern you hear shouting behind" +
            //        "you as the door swings closed. Will you go find out who called out to you?");
            //}
            //String decision2 = Console.ReadLine();
            //if (decision2 == yesOrNo[0])
            //{
            //    Console.WriteLine("Which attack would you like to use?");
            //    for (int a = 0; a < rAttack.Length; a++)
            //    {
            //        string rogueAttack = rAttack[a];
            //        Console.WriteLine(rogueAttack);
            //    }
            //}
            //else
            //{ //dark path start}
            //}
            /*******************ATTACKS & DAMAGE*******************/ //Harley Rogers
            /************Called for Example of them working*******/
            /*****************ATTACK****************************/
            var lightAttack = 1;
            Console.WriteLine(LightAttack(lightAttack));

            var medAttack = 1;
            Console.WriteLine(MedAttack(medAttack));

            var heavyAttack = 1;
            Console.WriteLine(HeavyAttack(heavyAttack));
            /****************DAMAGE*********************/
            var lightDamage = 1;
            Console.WriteLine(LightDamage(lightDamage));

            var medDamage = 1;
            Console.WriteLine(MedDamage(medDamage));

            var heavyDamage = 1;
            Console.WriteLine(HeavyDamage(heavyDamage));
        }
        /*****************METHODS FOR ATTACK & DAMAGE*****************///Harley Rogers
        /***********************ATTACK*******************************/
        private static int[] LightAttack(int lightAttack)
        {
            int[] randos = new int[lightAttack];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(2, 6);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
        }
        private static int[] MedAttack(int medAttack)
        {
            int[] randos = new int[medAttack];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(5, 11);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
        }
        private static int[] HeavyAttack(int heavyAttack)
        {
            int[] randos = new int[heavyAttack];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(11, 18);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
        }
        /******************DAMAGE*****************/
        private static int[] LightDamage(int lightDamage)
        {
            int[] randos = new int[lightDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(2, 6);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
        }
        private static int[] MedDamage(int medDamage)
        {
            int[] randos = new int[medDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(5, 11);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
        }
        private static int[] HeavyDamage(int heavyDamage)
        {
            int[] randos = new int[heavyDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(11, 18);
            }
            int randoNum = num.Next(randos.Length);
            Console.WriteLine(randos[randoNum]);

            return null;
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
        public static void TownScene()
        {
            Console.WriteLine("The town square.Behind you is the castle gate.To your left is the pub and market; to your right is the church;" +
                    " and in front of you is the road out of town. Where would you like to go next Adventurer?");
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
        public static void MarketMistake()
        {
            Console.WriteLine("Guards with joyous looks on their faces approach, while you see others run back to the " +
                "castle announcing the good news. " +
                "The church bells are rung as the crowd swells around you. Do you want to:");
            string[] mistakeChoice = { "1: Stay and wait for the king.", "2: Run away down the road out of town." };
            foreach(string choice in mistakeChoice)
            {
                Console.WriteLine(choice);
            }
            mistakeChoice[0] = "1";
            mistakeChoice[1] = "2";
            var marketDecision = Console.ReadLine();
            if( marketDecision == mistakeChoice[0])
            {
                Console.WriteLine("The king and queen arrive, surrounded by a large group of well - " +
                    "armed soldiers.He is crying out, \"My Daughter, my daughter! Where is she, my little my" +
                    " life? My daughter, my daughter, my love!?\" There is no escape now, Adventurer.The king," +
                    " heartbroken of course, and tired by so many nights of worry, has you arrested and puts you" +
                    " to death on the spot.So is the fate of all who would lie to the king on " +
                    "such an intimate matter.GAME OVER");

            }
                         
                
            
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
            string[] churchMainChoice = { "1: Pray" , "2: Ask the priest about the princess", "3: Steal the money from the poor box", "4: Leave the Church"};
            foreach(string option in churchMainChoice)
            {
                Console.WriteLine(option);
            }
            churchMainChoice[0] = "1";
            churchMainChoice[1] = "2";
            churchMainChoice[2] = "3";
            churchMainChoice[3] = "4";
            var churchDecision = Console.ReadLine();
            if(churchDecision == churchMainChoice[0])
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
                if(buffSelect == prayerRewards[0])
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
            else if(churchDecision == churchMainChoice[1])
            {
                Console.WriteLine("You ask about the princess.He says, \"We have been praying for her for so long. She would come in a few times a week to pray and then purchase some candles we make here at church. I was always curious why she would buy so many, but I don't know. Adventurer, I see that you are without any supplies for such a journey, may I assist you with some supplies, we have them from the funeral from the last adventurer");
                string[] askThePriest = { "1: Sword of Fallen Soldier: +1 Damage", "2: Small Vile of Healing : +25hp", "3: Minor Boots of the Tracker: Single use boots to guide your way." };
                foreach(string option in askThePriest)
                {
                    Console.WriteLine(option);
                }
                askThePriest[0] = "1";
                askThePriest[1] = "2";
                askThePriest[2] = "3";
                Console.WriteLine("Please select your reward");
                var lowerBuff = Console.ReadLine();
                if(lowerBuff == askThePriest[0])
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
    }
}
