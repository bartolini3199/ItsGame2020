﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Characters
{
    public class Rogue : Character
    {
        public Rogue() : base()
        {
        }
        public Rogue(string name) : base(name)
        {
        }
        public override int BaseDamage => 8;
        public override int BaseDefense => 1;
        protected override int BaseHealth => 110;
        protected override int BaseMana => 50;
    }
}
