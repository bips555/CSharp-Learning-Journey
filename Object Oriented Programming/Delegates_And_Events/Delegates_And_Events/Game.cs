using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    internal class Game
    {
      
        public string Name { get; set; }
        public Game(string name)
        {
            this.Name = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameStop += StopGame;
           
        }
        private void StartGame()
        {
            Console.WriteLine($"Spawning player with ID: {this.Name}");
        }
        private void StopGame()
        {
            Console.WriteLine($"Removing player with ID:{this.Name}");
        }
    }
}
