using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    interface ICharacter  
    {
        //The base abstract call conforms to this interface
        public string CharacterName { get; set; }
        public string ClassName { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
    }
}
