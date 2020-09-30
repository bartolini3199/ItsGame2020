using ItsGame2020.OnlineGame.Library.Models.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItsGame2020.Game
{
    public class GameManager
    {
        private static GameManager gameManager = null;
        public static GameManager Instance()
        {
            if (gameManager == null)
            {
                gameManager = GetFromDatabase();
            }
            return gameManager;
        }

        private static GameManager GetFromDatabase()
        {
            return new GameManager();
        }
        public void PrintPlayers()
        {
            foreach (var character in this.Characters)
            {
                character.PrintInfo();
            }
        }

        public List<Character> Characters { get; } = new List<Character>();
        public void AddPlayers(params Character[] character)
        {
            Characters.AddRange(character);
        }

    }
}
