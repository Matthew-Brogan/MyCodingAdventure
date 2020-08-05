using MyCodeAdventure.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Story._3._Forest.Choices
{
    class ForestFight
    {
        public static void FirstFight()
        {
            Enemies bandit = new Enemies();

            Console.WriteLine($"Press enter to continue: ");
            Console.ReadLine();
            Console.WriteLine("You exit the town center and wonder into the surrounding forest," +
                " \nAs you go deeper in you grow tired and decide to have a quick rest under an ancient tree." +
                "\n You are rudely awakened by the sound of two familiar voices approaching....");
            Console.WriteLine($"Bandits{bandit.Name}, and henchman of an old ally since turned enemy," +
                "\n the men approach, you have the element of suprise! Attack now!");
            Console.WriteLine();
            Console.WriteLine("Select your attack!");
            Attack.AttackChoice();

            //display stats of char and enemy. 
            //
            Console.WriteLine("Character \t\t Enemy");

            // heavy attack is slower and may be easier to block but does have knockback chance:**suprise first att success, next att blocked
            // light fast but weak more difficult to block ** incresed crit chance, if pick light crit for first, and roll random to block following
            // special unleash hell**must have selected sword alethia allow special otherwise no** slay 2 enemies at once but enrage all others

           
        }
    }
}
