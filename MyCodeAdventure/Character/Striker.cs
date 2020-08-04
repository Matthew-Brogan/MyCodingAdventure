using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    class Striker : ICharacter
    {
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }

        public Striker(string charName, int xp, int str, int intel, int honor, int stamina, int health, int pow)
        {
            CharacterName = charName;
            StartXP = xp;
            Strength = str;
            Intelegence = intel;
            HonorLevel = honor;
            Stamina = stamina;
            Health = health;
            Power = pow;
        }
        public void Steroids()
        {
            Strength += 20;
        }
        public void PowerStrike() //needs power
        {
            //give damage of 35
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
