﻿using System;
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
            ConsoleLogging.OpenAdventure();
            //Just an idea for an opener -working on the town square scene.

            ConsoleLogging.ChooseCharacter();
            
            string[] yesOrNo = { "yes", "no" };
            string[] sAttack = { "Light", "A light attack 4-6hp", "Heavy", "A Heavy attack 5-8hp", "Special", "Special attack, powerful but limited use: Charge at the enemy with a furious howl swinging wildly for 10hp to all nearby enemies" };//striker attacks

            ConsoleLogging.CharacterSelected();

            
            
         
            
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
          
            
                string decision1 = Console.ReadLine();
                switch (decision1)
                {
                    
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
                        if (marketDecision == marketChoice[0])
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
                Console.WriteLine($"Press enter to continue: ");
                Console.ReadLine();
                Console.WriteLine("You exit the town center and wonder into the surrounding forest, \nAs you go deeper in you grow tired and decide to have a quick rest under an ancient tree.\n You are rudely awakened by the sound of two familiar voices approaching....");
                Console.WriteLine("Bandits, and henchman of an old ally since turned enemy,\n the two men approach, you have the element of suprise! Attack now!");
                Console.WriteLine();
                foreach(string attack in sAttack)
                {
                    Console.WriteLine(attack);
                }
                Console.WriteLine();
                Console.WriteLine("Select your attack!");
                sAttack[0] = "1";
                sAttack[1] = "2";
                sAttack[2] = "3";
                var usedAttack = Console.ReadLine();
                Damage firstDamage = new Damage();
                Console.WriteLine(firstDamage.LightBlocked());
                Console.WriteLine(firstDamage.LightBlocked());
                Console.WriteLine(firstDamage.MediumBlocked());
                Console.WriteLine(firstDamage.HeavyBlocked());

            }

            /*****************LIST OF ENEMIES**************************/
            Enemies punyLevEnemyList = new Enemies();
            Enemies lowLevEnemyList = new Enemies();
            Enemies medLevEnemyList = new Enemies();
            Enemies highLevEnemyList = new Enemies();
            Enemies godLevEnemyList = new Enemies();
            Enemies caveEnemyList = new Enemies();
            Enemies forestEnemyList = new Enemies();
            Enemies waterEnemyList = new Enemies();
            Enemies eventEnemyList = new Enemies();

            //health(1-50), damage(1-50), type, threatLeval(1-10), attributes

            //Puny enemies
            Enemies drunk = new Enemies(1, 1, "human", "very low", "He smells really bad");
            Enemies.PunyLevelEnemys.Add(drunk);
            Enemies angryGoat = new Enemies(1, 2, "animal", "very low", "You must've done something to his lady goat to make him this mad!" );
            Enemies.PunyLevelEnemys.Add(angryGoat);
            //Low Leval Enemys
            Enemies bandit = new Enemies(3, 4, "human", "low", "They want your loot!" );
            Enemies.LowLevelEnemys.Add(bandit);
            Enemies zombie = new Enemies(2, 6, "undead", "low", "It wants your brains!");
            Enemies.LowLevelEnemys.Add(zombie);
            Enemies imp = new Enemies(3, 3, "demon", "low", "Its a clever little fool! " );
            Enemies.LowLevelEnemys.Add(imp);
            Enemies goblin = new Enemies(3, 4, "humanoid", "low", "It want's your gold!" );
            Enemies.LowLevelEnemys.Add(goblin);
            //Medium level enemies
            Enemies soldier = new Enemies(6, 8, "human", "medium", "Has a chip on his shoulder");
            Enemies.MedLevelEnemys.Add(soldier);
            Enemies hornnedDevil = new Enemies(7, 9, "demon", "medium", "Pretty much just wants you dead.");
            Enemies.MedLevelEnemys.Add(hornnedDevil);
            Enemies succubus = new Enemies(5, 8, "demon", "medium", "She wants you...dead. Dont fall for it bro." );
            Enemies.MedLevelEnemys.Add(succubus);
            Enemies orc = new Enemies(8,8,"humanoid", "medium", "Better watch out. He'll break your bones!.");
            Enemies.MedLevelEnemys.Add(orc);
            //High level enemies
            Enemies knight = new Enemies(12, 10, "human", "high" , "Honor above ALL!!");
            Enemies.HighLevelEnemys.Add(knight);
            Enemies fireDragon = new Enemies(15, 20, "creature", "high", "He'll make you fried chicken. That is you will be the chicken..." );
            Enemies.HighLevelEnemys.Add(fireDragon);
            Enemies blueDragon = new Enemies(20, 15, "creature", "high", "No fire, but he's got a mean bite!");
            Enemies.HighLevelEnemys.Add(blueDragon);
            Enemies chainDevil = new Enemies(10, 22, "demon", "high", "I hope you like whips and chains...");
            Enemies.HighLevelEnemys.Add(chainDevil);
            //god level enemies
            Enemies goldDragon = new Enemies(35, 45, "creature", "very high", "Don't touch his stach. You probably wont live." );
            Enemies.GodLevelEnemys.Add(goldDragon);
            Enemies leviathan = new Enemies(45, 35, "creature", "very high", "Best start running." );
            Enemies.GodLevelEnemys.Add(leviathan);
            //Cave enemies
            Enemies vampire = new Enemies(10, 11, "undead", "high", "they want your blood! They also don't sparkle...");
            Enemies.CaveEnemys.Add(vampire);
            Enemies ghoul = new Enemies(6, 9, "undead", "med", "A less decayed zombie, cool." );
            Enemies.CaveEnemys.Add(ghoul);
            Enemies giantSpider = new Enemies(7, 8, "insect", "med", "Don't get bit! Poison!");
            Enemies.CaveEnemys.Add(giantSpider);
            Enemies giantRat = new Enemies(3, 5, "low", "creature", "Hopefully it doesn't have the black plague!");
            Enemies.CaveEnemys.Add(giantRat);
            Enemies bat = new Enemies(1,3, "very low", "creature", "Probably has Covid.");
            Enemies.CaveEnemys.Add(bat);
            Enemies caveTroll = new Enemies(12, 12, "high", "humanoid", "Do you hear the drums?");
            Enemies.CaveEnemys.Add(caveTroll);
            //Water enemies
            Enemies shark = new Enemies(7, 12, "med", "creature", "Dun Dun....Dun Dun...Dun, Dundundundundun!!");
            Enemies.WaterEnemys.Add(shark);
            Enemies giantSquid = new Enemies(15, 8, "high", "creature", "It'll squeeze you tell you pop!");
            Enemies.WaterEnemys.Add(giantSquid);
            //forest enemies
            Enemies fox = new Enemies(1, 2, "very low", "creature", "What does the fox say?");
            Enemies.ForestEnemys.Add(fox);
            Enemies bear = new Enemies(8, 10, "med", "creature", "Just do better than Leonardo." );
            Enemies.ForestEnemys.Add(bear);
            Enemies boar = new Enemies(5, 3, "low", "creature", "Oink");
            Enemies.ForestEnemys.Add(boar);
            Enemies wolf = new Enemies(3, 5, "low", "creature", "Thye travel in packs, watch out." );
            Enemies.ForestEnemys.Add(wolf);
            Enemies giantFrog = new Enemies(3, 7, "med", "creature", "It has a huge maw!");
            Enemies.ForestEnemys.Add(giantFrog);
            Enemies unicorn = new Enemies(5, 10, "med", "creature", "Look! A magical skewer!");
            Enemies.ForestEnemys.Add(unicorn);
            //event enemy   
            Enemies stoneGolum = new Enemies(12, 12, "high", "Construct", "Hes got thicker skin than the clay one...got to find the creator!");
            Enemies.EventEnemys.Add(stoneGolum);
            Enemies clayGolum = new Enemies(5, 7, "low", "Construct", "Somoen must've made this dude!");
            Enemies.EventEnemys.Add(clayGolum);
            Enemies evilWizard = new Enemies(8, 15, "med-high", "human", "He is the contoller! Kill em quick before he makes more!" );
            Enemies.EventEnemys.Add(evilWizard);
            //the wizard controlls the golums
            Enemies.RandomPunyLeval();
            Console.WriteLine(Enemies.PunyLevelEnemys.Count);


        
      
       
        
      
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
