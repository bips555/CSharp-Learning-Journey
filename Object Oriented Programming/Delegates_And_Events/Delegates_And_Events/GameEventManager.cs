using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    internal static class GameEventManager
    {
        public delegate void EventManager();

        public static event EventManager OnGameStart, OnGameStop;
        



      public  static void TriggerGameStart()
        {
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started");
                OnGameStart();
            }
           
        }
       public static void TriggerGameStop()
        {
            if (OnGameStop != null)
            {
                Console.WriteLine("The game has stopped");
                OnGameStop();
            }

        }
    }
}
