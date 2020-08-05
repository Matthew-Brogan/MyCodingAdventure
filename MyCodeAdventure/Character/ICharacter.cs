using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    interface ICharacter  
    {
        
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }

        public void GetCharacterName(string charname);
        public void GetClass(string userChoice);
        public void TakeDamage(int damage);
        public void Heal();
        public void GiveDamage();
        public void HonorChaneg();
    }
}
