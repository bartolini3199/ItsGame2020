using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Characters
{
    public class Wizard : Character
    {
        public Wizard() : base() { }
        public Wizard(string name) : base(name) 
        {
            this.ManaPoints = 150;
            this.HealthPoints = MaxHealth;
        }
        protected override int BaseHealth => 100;
        protected override int BaseMana => 150;
        public void ThrowFireBall(Character target)
        {
            Console.WriteLine($"{this.Name} throws a fireball to {target.Name}");
        }
    }

    
}
