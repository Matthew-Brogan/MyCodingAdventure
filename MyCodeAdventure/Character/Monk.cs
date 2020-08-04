using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    class Monk : ICharacter
    {
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Virtue { get; set; }

        public Monk(string charName, int xp, int str, int intel, int honor, int stamina, int health, int virtue)
        {
            CharacterName = charName;
            StartXP = xp;
            Strength = str;
            Intelegence = intel;
            HonorLevel = honor;
            Stamina = stamina;
            Health = health;
            Virtue = virtue;
        }
        public void Pray() //needs virtue
        {
            HonorLevel += 10;
        }
        public void GodsWrath() //needs virtue
        {
            //give damage +30;
        }
        public void GetCharacterName(string charname)
        {
            CharacterName = charname;
        }

        public void GetClass(string userChoice)
        {
            Class = userChoice;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void Heal()
        {
            Health += 5; //base Healing. Can be more depending on potions and whatnot
        }
        public void GiveDamage()
        {
            //
        }
    }
}
