﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Characters
{
    public class CharacterFactory
    {
        public Character Create(string name = null)
        {
            var randomClass = (CharacterClass)new Random((int)DateTime.UtcNow.Millisecond).Next(0, 3);
            return this.Create(randomClass, name);
        }
        public Character Create(CharacterClass heroClass, string name = null)
        {
            switch (heroClass)
            {
                default:
                case CharacterClass.Warrior:
                    return new Warrior(name);
                case CharacterClass.Wizard:
                    return new Wizard(name);
                case CharacterClass.Rogue:
                    return new Rogue(name);
                case CharacterClass.Paladin:
                    return new Paladin(name);
            }
        }
    }
}
