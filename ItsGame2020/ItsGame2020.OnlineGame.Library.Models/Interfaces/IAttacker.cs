﻿using ItsGame2020.OnlineGame.Library.Models.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.OnlineGame.Library.Models.Interfaces
{
    public interface IAttacker
    {
        void Attack(Character target);
    }
}
