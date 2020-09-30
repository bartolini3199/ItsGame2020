using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Characters
{
    public abstract class Character
    {
        public string Name { get; set; } = "Player";
        public bool Gender { get; set; }
        public CharacterType Type { get; set; }
    }
    public class Wizard : Character
    {

    }

    public enum CharacterType
    {
        Human,
        Elf,
        Orc
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

}
