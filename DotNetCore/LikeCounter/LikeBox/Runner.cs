using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LikeCounter.LikeBox
{
    public class Runner
    {
        private readonly LikesCounter likesCounter;
        private Timer timer;
        private int likesNumber;

        public Runner(LikesCounter likesCounter)
        {
            this.likesCounter = likesCounter;
            timer = new Timer(1000);
        }
        
        public void Run()
        {
            timer.Elapsed += CallLikesCounter;
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void CallLikesCounter(object sender, ElapsedEventArgs e)
        {
            this.likesNumber = this.likesCounter.CountLikes();
            Console.WriteLine(this.likesNumber);
        }
    }
}
