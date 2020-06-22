using System;
using System.Runtime.InteropServices.ComTypes;

namespace MyCodeAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Choose Your Class:");
            string[] allclass = { "Striker", "Rouge", "Wizard", "Monk" };
            string[] stats = { "Strength:10 Stamina:8 Dexterity:6 Intelligence:4", "Strength:6 Stamina:9 Dexterity:10 Intelligence:7", "Strength:4 Stamina:7 Dexterity:7 Intelligence:10", "Strength:6 Stamina:9 Dexterity:9 Intelligence:7" };
            string[] yesOrNo = { "yes", "no" };
            string[] sAttack = { "Light","A light attack 4-6hp", "Heavy", "Special" };//striker attacks
            string[] rAttack = { "Light: 3-5" , "Heavy: 4-7hp" , "Special: Dance around with furious grace and speed, slicing and dicing all for 10 hp" };


            for (int i = 0; i < allclass.Length; i++)
            {
                var selectable = allclass[i];
                Console.WriteLine(selectable);
            }
            string chosen = Console.ReadLine();
            if (chosen == allclass[0])
            {
                Console.WriteLine($"{name}, You have chosen the {allclass[0]} class! The strongest and bravest of all!");
                Console.WriteLine($"Your stats are as follows:");
                Console.WriteLine($"{stats[0]}");
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
                Console.WriteLine($"{name}, You have chosen the {allclass[3]} class! The enlightend and powerfull!");
                Console.WriteLine($"Your stats are as follows:{stats[3]}");
                Console.WriteLine("Farewell monk, may your spirit guide you!");
            }
            Console.WriteLine("Begin you journey!");
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            if (chosen == allclass[0])
            {
                Console.WriteLine("Warrior!... Warrior!... please... help!!!");
                Console.WriteLine("As you were strolling home from the local tavern you notice a " +
                    "fair young lady being attacked by ghouls! Will you help her?");


            }
            string decision1 = Console.ReadLine();
            if (decision1 == yesOrNo[0])
            {
                Console.WriteLine("Which attack would you like to use?");

                for (int j = 0; j < sAttack.Length; j++)
                {
                    string strikerAttack = sAttack[j];
                    Console.WriteLine(strikerAttack);
                    
                }
                string cAttack = Console.ReadLine();
                    if( cAttack == sAttack[0])
                    {
                        Console.WriteLine("Youve grazed your opponent for 4 hp.");
                        Console.WriteLine("Beware, the enemy surrounds you! Use your special attck now!!");
                    }
                string finisher = Console.ReadLine();
                if (finisher == sAttack[2])
                {
                    Console.WriteLine("HA HA you really showed them!");
                    Console.WriteLine("A voice coming from inside the tavern bellows");
                    Console.WriteLine("Let's go see who'd like to celebrate with us!");
                    Console.WriteLine("As you walk in you notice a large soldier waving in your direction" +
                        "as you approach you are greeted with a tall jar of meade and a firm handhake.");

                }


            }

            if (chosen == allclass[1])
            {
                Console.WriteLine("Stranger!... Help me PLEEEEASSE!");
                Console.WriteLine("Just coming out of the storm into the tavern you hear shouting behind" +
                    "you as the door swings closed. Will you go find out who called out to you?");
            }
            String decision2 = Console.ReadLine();
            if (decision2 == yesOrNo[0])
            {
                Console.WriteLine("Which attack would you like to use?");
                for(int a = 0; a < rAttack.Length; a++)
                {
                    string rogueAttack = rAttack[a];
                    Console.WriteLine(rogueAttack);
                }
            }
        }
    }
}
