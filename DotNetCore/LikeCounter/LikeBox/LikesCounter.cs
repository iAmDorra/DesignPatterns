using System;

namespace LikeCounter.LikeBox
{
    public class LikesCounter: ILikeCounter
    {
        private int likeNumber;

        public LikesCounter(IProductAnalysis likeNumberProvider)
        {
            likeNumber = 0;
            likeNumberProvider.Add(this);
        }

        public int LikeNumber => likeNumber;
        
        public void Update(int likesNumber)
        {
            likeNumber++;
            // We can call the console to write the number also.
            // Console.WriteLine(likesNumber);
        }
    }
}
