using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    interface ICharacter  
    {
        //All the character classes will conform to this base abstract class
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }

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
