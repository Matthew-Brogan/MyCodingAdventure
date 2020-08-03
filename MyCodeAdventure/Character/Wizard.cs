using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    class Wizard : ICharacter
    {

        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }

        public int Mana { get; set; }
        public void HealingSpell() //needs mana to do this.
        {
            Health += 20;
        }
        public void FireBall() //needs mana to do this.
        {
            //give damage of 25
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
