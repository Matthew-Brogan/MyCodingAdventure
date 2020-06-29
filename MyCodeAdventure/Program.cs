using System;
using System.Runtime.InteropServices.ComTypes;

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
            string[] allclass = { "Striker", "Rouge", "Wizard", "Monk" };
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
            if (chosen == allclass[0])
            {
                Console.WriteLine($"{name}, You have chosen the {allclass[0]} class! The strongest and " +
                    $"bravest of all!");
                Console.WriteLine();
                Console.WriteLine($"Your stats are as follows:");
                Console.WriteLine($"{stats[0]}");
                Console.WriteLine();
                Console.WriteLine("Farewell brave warrior!");
            }
            if (chosen == allclass[1])
            {
                Console.WriteLine($"{name}, You have chosen the {allclass[1]} class! The quick and cunning!");
                Console.WriteLine($"Your stats are as follows:");
                Console.WriteLine($"{stats[1]}");
                Console.WriteLine("Farewell cunning rouge!");
            }
            if (chosen == allclass[2])
            {
                Console.WriteLine($"{name}, You have chosen the {allclass[2]} class! The wise and fearless!");
                Console.WriteLine($"Your stats are as follows:{stats[2]}");
                Console.WriteLine("Farewell wise wizard!");
            }
            if (chosen == allclass[3])
            {
                Console.WriteLine($"{name}, You have chosen the {allclass[3]} class! The enlightend and " +
                    $"powerfull!");
                Console.WriteLine($"Your stats are as follows:{stats[3]}");
                Console.WriteLine("Farewell monk, may your spirit guide you!");
            }
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            if (chosen == allclass[0] ||chosen == allclass[1] || chosen == allclass[2] || chosen == allclass[3])
            {
                Console.WriteLine("The town square.Behind you is the castle gate.To your left is the pub and market; to your right is the church;" +
                    " and in front of you is the road out of town. Where would you like to go next Adventurer?");
                Console.WriteLine("Please choose your path:");
                string[] townPath = { "The Pub" , "The Market" , "The Church" , "Leave Town" };
                for (int x = 0; x < townPath.Length; x++)
                {
                    Console.WriteLine(townPath[x]);
                }
                string decision1 = Console.ReadLine();
                switch (decision1)
                {
                    case "The Pub":
                        Console.WriteLine("The Pub is pretty empty, but bar tender is behind the bar cleaning glasses. Classic. Would you like to speak with the bar tender or leave the pub?");
                        string[] pubChoice = { "Speak with the Bartender", "Leave the pub", "Buy a bottle of Gin(You havent made money yet!)", "Back to the town square" };  
                        foreach (string choice in pubChoice)
                        {
                            Console.WriteLine(choice);
                            
                        }
                        string pubDecision = Console.ReadLine();
                        if(pubDecision == pubChoice[0])
                        {
                            BarTalk();
                        }
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
    }
}
