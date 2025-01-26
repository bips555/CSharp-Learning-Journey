using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    internal class AudioSystem
    {
        public AudioSystem() {

            GameEventManager.OnGameStart += StartAudioSystem;
            GameEventManager.OnGameStop += StopAudioSystem;
        
        }
        private void StartAudioSystem()
        {
            Console.WriteLine("Audio SYstem started.......");
            Console.WriteLine("Playing Audio");
        }
        private void StopAudioSystem()
        {
            Console.WriteLine("Audio SYstem Stopped.......");
       
        }
    }
}
