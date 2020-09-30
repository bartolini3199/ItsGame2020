using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using ItsGame2020.OnlineGame.Library.Models;
using ItsGame2020.OnlineGame.Library.Models.Characters;

namespace ItsGame2020.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Wizard();
            PrintCharacters(new Wizard());
        }

        private static void PrintCharacters(Character character )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(character.Name);
            Console.ResetColor();
        }
    }
}
