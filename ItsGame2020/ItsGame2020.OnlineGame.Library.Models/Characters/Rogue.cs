using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Characters
{
    public class Rogue : Character
    {
        public Rogue() : base() { }
        public Rogue(string name) : base(name) { }

        protected override int BaseHealth => 125;
        protected override int BaseMana => 150;
    }
}
