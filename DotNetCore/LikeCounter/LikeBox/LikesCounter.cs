namespace LikeCounter.LikeBox
{
    public class LikesCounter
    {
        private readonly ILikeNumberProvider likeNumberProvider;

        public LikesCounter(ILikeNumberProvider likeNumberProvider)
        {
            this.likeNumberProvider = likeNumberProvider;
        }

        public int CountLikes()
        {
            return this.likeNumberProvider.GetNumberLikes();
        }
    }
}
