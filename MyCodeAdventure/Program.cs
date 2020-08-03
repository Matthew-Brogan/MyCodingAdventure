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
            foreach (string attack in sAttack)
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
            Enemies angryGoat = new Enemies(1, 2, "animal", "very low", "You must've done something to his lady goat to make him this mad!");
        Enemies.PunyLevelEnemys.Add(angryGoat);
            //Low Leval Enemys
            Enemies bandit = new Enemies(3, 4, "human", "low", "They want your loot!");
        Enemies.LowLevelEnemys.Add(bandit);
            Enemies zombie = new Enemies(2, 6, "undead", "low", "It wants your brains!");
        Enemies.LowLevelEnemys.Add(zombie);
            Enemies imp = new Enemies(3, 3, "demon", "low", "Its a clever little fool! ");
        Enemies.LowLevelEnemys.Add(imp);
            Enemies goblin = new Enemies(3, 4, "humanoid", "low", "It want's your gold!");
        Enemies.LowLevelEnemys.Add(goblin);
            //Medium level enemies
            Enemies soldier = new Enemies(6, 8, "human", "medium", "Has a chip on his shoulder");
        Enemies.MedLevelEnemys.Add(soldier);
            Enemies hornnedDevil = new Enemies(7, 9, "demon", "medium", "Pretty much just wants you dead.");
        Enemies.MedLevelEnemys.Add(hornnedDevil);
            Enemies succubus = new Enemies(5, 8, "demon", "medium", "She wants you...dead. Dont fall for it bro.");
        Enemies.MedLevelEnemys.Add(succubus);
            Enemies orc = new Enemies(8, 8, "humanoid", "medium", "Better watch out. He'll break your bones!.");
        Enemies.MedLevelEnemys.Add(orc);
            //High level enemies
            Enemies knight = new Enemies(12, 10, "human", "high", "Honor above ALL!!");
        Enemies.HighLevelEnemys.Add(knight);
            Enemies fireDragon = new Enemies(15, 20, "creature", "high", "He'll make you fried chicken. That is you will be the chicken...");
        Enemies.HighLevelEnemys.Add(fireDragon);
            Enemies blueDragon = new Enemies(20, 15, "creature", "high", "No fire, but he's got a mean bite!");
        Enemies.HighLevelEnemys.Add(blueDragon);
            Enemies chainDevil = new Enemies(10, 22, "demon", "high", "I hope you like whips and chains...");
        Enemies.HighLevelEnemys.Add(chainDevil);
            //god level enemies
            Enemies goldDragon = new Enemies(35, 45, "creature", "very high", "Don't touch his stach. You probably wont live.");
        Enemies.GodLevelEnemys.Add(goldDragon);
            Enemies leviathan = new Enemies(45, 35, "creature", "very high", "Best start running.");
        Enemies.GodLevelEnemys.Add(leviathan);
            //Cave enemies
            Enemies vampire = new Enemies(10, 11, "undead", "high", "they want your blood! They also don't sparkle...");
        Enemies.CaveEnemys.Add(vampire);
            Enemies ghoul = new Enemies(6, 9, "undead", "med", "A less decayed zombie, cool.");
        Enemies.CaveEnemys.Add(ghoul);
            Enemies giantSpider = new Enemies(7, 8, "insect", "med", "Don't get bit! Poison!");
        Enemies.CaveEnemys.Add(giantSpider);
            Enemies giantRat = new Enemies(3, 5, "low", "creature", "Hopefully it doesn't have the black plague!");
        Enemies.CaveEnemys.Add(giantRat);
            Enemies bat = new Enemies(1, 3, "very low", "creature", "Probably has Covid.");
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
            Enemies bear = new Enemies(8, 10, "med", "creature", "Just do better than Leonardo.");
        Enemies.ForestEnemys.Add(bear);
            Enemies boar = new Enemies(5, 3, "low", "creature", "Oink");
        Enemies.ForestEnemys.Add(boar);
            Enemies wolf = new Enemies(3, 5, "low", "creature", "Thye travel in packs, watch out.");
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
            Enemies evilWizard = new Enemies(8, 15, "med-high", "human", "He is the contoller! Kill em quick before he makes more!");
        Enemies.EventEnemys.Add(evilWizard);
            //the wizard controlls the golums
            Enemies.RandomPunyLeval();
            Console.WriteLine(Enemies.PunyLevelEnemys.Count);


        
      
       
        
        }
    }
}
