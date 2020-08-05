using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Mechanics
{
    
    class Attack
    {
        private static int _choice;

        public static int Choices()
        {
            string[] attackChoice = { "(1)light attack", "(2)heavy attack", "(3)special attack" };
            foreach (string attack in attackChoice)
            {
                Console.WriteLine(attack);
            }
            _choice = int.Parse(Console.ReadLine());
            return _choice;
        }
        public static void AttackChoice()
        {
            Choices();
            AttackChance();
            //switch (Choices())
            //{
            //    case 1://light
            //        AttackChance();
            //        break;
            //    case 2://heavy
            //        AttackChance();
            //        break;
            //    case 3://special
            //        AttackChance();
            //        break;

            //}
        }
        public static void AttackChance()
        {
            if (RandomNumber() > 3)
            {
                DamageType();
            }
            else
            {
                Console.WriteLine("You missed");
                //make method for defense.
            }
        }
        public static void DamageType()
        {
            if (RandomNumber() < 8)
            {
                RegHitChance();
            }
            else
            {
                CritHitChance();
            }
        }
        public static int RegHitChance()
        {
            
            if (_choice == 1)
            {
                return LightAttack();
            }
            else if (_choice == 2)
            {
                return HeavyAttack();
            }
            else
            {
                return SpecialAttack();
            }
        }
        public static float CritHitChance()
        {
            if (_choice == 1)
            {
                return LightCrit();
            }
            else if (_choice == 2)
            {
                return HeavyCrit();
            }
            else
            {
                return SpecialCrit();
            }
        }
        public static int LightAttack()
        {
            return Damage.LightDamage(4);
        }
        public static int HeavyAttack()
        {
            return Damage.MedDamage(8);
        }
        public static int SpecialAttack()
        {
            return Damage.HeavyDamage(15);
        }
        public static float LightCrit()
        {
            return Damage.LightCrit();
        }
        public static float HeavyCrit()
        {
            return Damage.MedCrit();
        }
        public static float SpecialCrit()
        {
            return Damage.HeavyCrit();
        }
        public static int RandomNumber()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(0, 10);
            return num;
        }

        

    }
}
