using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeon_game
{
    internal class Player
    {
        Random rng = new Random();
        private int health;
        private int strength;
        private int speed;
        private int dexterity;
        private int classID;
        private string[] classNames = {"Warrior", "Assassin", "Mage"};
        public player()
        {
            System.Console.WriteLine("Choose a class:");
            System.Console.WriteLine("[1] Warrior");
            System.Console.WriteLine("[2] Assassin");
            System.Console.WriteLine("[3] Mage");
            classID = Convert.ToInt32(Console.ReadLine());
            display_class();
        }
        public void display_class()
        {
            System.Console.WriteLine(classNames[classID]);
        }
    }
}