﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    class Damage
    {

        //Based on the input attack. (light, medium, heavy, blocked, blocked medium, blocked heavy)
        


        /*Maybe a switch statement inside this method could allow us to run/call individual 
         * damage methods and return the rng number "- a percentage or 1-2 damage point based on the attack"
         * ex: if light damage is blocked return light damage * .75..
           this might cause all of our damage to have to be parsed as doubles or floats, floats seem more logical 
        as they are the least exact and would allow some variation in output
         *****just an idea*****
         */
        private static int Blocked(int a)//put in the damage here. it takes away some damage.
        {
            return a;
                
        }
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
    }
}
