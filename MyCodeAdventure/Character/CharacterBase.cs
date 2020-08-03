using System;
using System.Collections.Generic;
using System.Text;

namespace MyCodeAdventure.Character
{
    abstract class CharacterBase : ICharacter
    {
        //All the character classes will conform to this base abstract class
        public string CharacterName { get; set; }
        public string ClassName { get; set; }
        public int StartXP { get; set; }
        public int Strength { get; set; }
        public int Intelegence { get; set; }
        public int HonorLevel { get; set; }
        public int Stamina { get; set; }
    }
}
