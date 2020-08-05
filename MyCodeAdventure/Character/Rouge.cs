using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    public static class Rouge
    {
        public static string CharacterName { get; set; }
        public static string Class { get; set; }

        public static int StartXP { get; set; } = 0;
        public static int HonorLevel { get; set; } = 10;
        public static int Health { get; set; } = 7;

        public static int Strength { get; set; } = 5;
        public static int Intelegence { get; set; } = 7;
        public static int Stamina { get; set; } = 10;

        public static int Dexterity { get; set; } = 10;
        
        public static void NinjaMoves()
        {
            Stamina += 20;
        }
        public static void BackStab()
        {
            //give damage of 20;
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
