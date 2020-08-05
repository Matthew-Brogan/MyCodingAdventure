﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure
{
    public class Damage
    {

        //Based on the input attack. (light, medium, heavy, blocked, blocked medium, blocked heavy)






        /**********************Block*********************/
        // private static void Blocked()//put in the damage here. it takes away some damage.

        /*Maybe a switch statement inside this method could allow us to run/call individual 
         * damage methods and return the rng number "- a percentage or 1-2 damage point based on the attack"
         * ex: if light damage is blocked assign LightDamage() to a var, and then return LightDamage * .75..
           this might cause all of our damage to have to be parsed as doubles or floats, floats seem more logical 
        as they are the least exact and would allow some variation in output
         *****just an idea*****
         */

        public static float LightCrit()//put in the damage here. it takes away some damage.

        {
            var baseDamage = LightDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var critDamage = altBase *= 1.70f;

            return critDamage;

        }
        public static float MedCrit()//put in the damage here. it takes away some damage.

        {
            var baseDamage = MedDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var critDamage = altBase *= 1.70f;

            return critDamage;

        }
        public static float HeavyCrit()//put in the damage here. it takes away some damage.

        {
            var baseDamage = HeavyDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var critDamage = altBase *= 1.70f;

            return critDamage;

        }
        public float LightBlocked()//put in the damage here. it takes away some damage.

        {
            var baseDamage = LightDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var blockedDamage = altBase *= .70f;

            return blockedDamage;
                
        }
        public float HeavyBlocked()//put in the damage here. it takes away some damage.

        {
            var baseDamage = HeavyDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var blockedDamage = altBase *= .70f;

            return blockedDamage;

        }
        public float MediumBlocked()//put in the damage here. it takes away some damage.

        {
            var baseDamage = MedDamage(5);
            var altBase = Convert.ToSingle(baseDamage);
            var blockedDamage = altBase *= .70f;

            return blockedDamage;

        }

        /*******************Damage**********************/
        public static int LightDamage(int lightDamage)
        {
            int[] randos = new int[lightDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(2, 6);
            }
            int randoNum = num.Next(randos.Length);
            int answer = randos[randoNum];

            

            return answer;
        }
        public static int MedDamage(int medDamage)
        {
            int[] randos = new int[medDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(5, 11);
            }
            int randoNum = num.Next(randos.Length);
            int answer = randos[randoNum];

            return answer;
        }
        public static int HeavyDamage(int heavyDamage)
        {
            int[] randos = new int[heavyDamage];

            Random num = new Random();

            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = num.Next(11, 18);
            }
            int randoNum = num.Next(randos.Length);
            int answers = randos[randoNum];

            return answers;
        }
        /********************Attack*********************/
        public static int[] LightAttack(int lightAttack)
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
        public static int[] MedAttack(int medAttack)
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
        public static int[] HeavyAttack(int heavyAttack)
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
    }
}
