using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    public static class Striker
    {
        public static string CharacterName { get; set; }
        public static string Class { get; set; }

        public static int StartXP { get; set; } = 0;
        public static int Strength { get; set; } = 10;  //max cap 20.
        public static int HonorLevel { get; set; } = 10;

        public static int Intelegence { get; set; } = 3;
        public static int Stamina { get; set; } = 5;
        public static int Health { get; set; } = 10;

        public static int Power { get; set; } = 10;

        public static void Steroids()
        {
            Strength += 20;
        }
        public static void PowerStrike() //needs power
        {
            //give damage of 35
        }
        public static void GetCharacterName(string charname)
        {
            CharacterName = charname;
        }

        public static void GetClass(string userChoice)
        {
            Class = userChoice;
        }
        public static void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public static void Heal()
        {
            Health += 5; //base Healing. Can be more depending on potions and whatnot
        }
        public static void GiveDamage()
        {
            //
        }
    }
}
