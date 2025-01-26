using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace Inheritance
{
   
    internal class VideoPost : Post
    {
        private static System.Timers.Timer _timer;
        private static int time = 1
            ;
        public string VideoURL { get; set; }
        public static  int Length { get; set; }
        public void Play()
        {
            Console.WriteLine("Playing the video");

           
                _timer = new System.Timers.Timer(1000);
                _timer.Elapsed += OnTimerElapsed;
                _timer.AutoReset = true;
                _timer.Start();
           

            }
        public void Stop()
        {

            Console.ReadLine();
            _timer.Stop();
            _timer.Dispose();
            if (time < Length)
            {
                Console.WriteLine("Stopped at {0}s ", time);
            }
        }

        private static void OnTimerElapsed(Object source, ElapsedEventArgs e)
        {
           if(time < Length)
            {
                Console.WriteLine("Current duration of video is {0}", time);
                time++;
            }
            else
            {
                _timer.Stop();
                Console.WriteLine("Stopped at {0}s ", time);
            }
          
        }
      
        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUsername, string videoURL, int length,bool isPublic)

        {
            this.ID = GetNextID();
            this.Title = title;
            this.VideoURL = videoURL;
          Length = length;
            this.IsPublic = IsPublic;
            this.SendByUsername = sendByUsername;
                
        }
        public override string ToString()
        {
            return  String.Format("{0} - {1} - {2} of length {3} - by {4}", this.ID, this.Title,this.VideoURL,Length, this.SendByUsername);
        }
    }
}
