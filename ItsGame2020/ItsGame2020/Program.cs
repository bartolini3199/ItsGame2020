using ItsGame2020.Game;
using ItsGame2020.OnlineGame.Library.Models.Characters;

using System;
using System.Collections.Generic;

namespace Test.ConsoleApp
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            GameManager.Instance().AddPlayers
            (
                characterFactory.Create(CharacterClass.Warrior, "Guerrirero"),
                characterFactory.Create(CharacterClass.Wizard),
                characterFactory.Create()
            );
            GameManager.Instance().PrintPlayers();
        }
    }      
}
/*ConsoleKey key = ConsoleKey.Enter;
           while(key != ConsoleKey.Escape) 
           {
               GameManager.Instance().AddPlayer(characterFactory.Create(CharacterClass.Warrior, "MyName"));
               GameManager.Instance().AddPlayer(characterFactory.Create(CharacterClass.Wizard));
               GameManager.Instance().AddPlayer(characterFactory.Create());

               Console.WriteLine();
               key = Console.ReadKey().Key;
           }*/