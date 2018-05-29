using System.Collections.Generic;

namespace LikeCounter
{
    public class ProductAnalysis : IProductAnalysis
    {
        private int likesNumber = 0;
        private List<ILikeCounter> likeCounters = new List<ILikeCounter>();

        public void LikeProduct()
        {
            likesNumber++;
            foreach (var counter in this.likeCounters)
            {
                counter.Update(likesNumber);
            }
        }

        public void Add(ILikeCounter counter)
        {
            likeCounters.Add(counter);
        }
    }
}
