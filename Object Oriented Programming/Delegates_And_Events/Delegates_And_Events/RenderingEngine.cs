using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_And_Events
{
    internal class RenderingEngine
    {
        public RenderingEngine() {
            GameEventManager.OnGameStart += StartRenderingEngine;
            GameEventManager.OnGameStop += StopRenderingEngine;
        
        }    
        private void StartRenderingEngine()
        {
            Console.WriteLine("Renering engine Started");
            Console.WriteLine("Drawing Visuals");
        }
        private void StopRenderingEngine()
        {
            Console.WriteLine("Rendering engine Stopped.......");

        }
    }
}
