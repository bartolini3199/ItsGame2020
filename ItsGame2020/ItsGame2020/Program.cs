﻿using ItsGame2020.Game;
using ItsGame2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.ConsoleApp
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            GameManager.Instance().AddPlayers
            (
                characterFactory.Create(CharacterClass.Warrior, "Player 1"),
                characterFactory.Create(CharacterClass.Wizard, "Player 2")
            );
            GameManager.Instance().PrintPlayers();
            Character player1 = GameManager.GetFirstPlayer();
            Character player2 = GameManager.GetSecondPlayer();
            if (player1 != null && player2 != null)
            {
                player1.Attack(player2);
            }
            else
            {
                Console.WriteLine("Empty player list");
            }
        }
    }
}
