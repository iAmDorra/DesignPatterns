namespace LikeCounter
{
    public class ProductAnalysis : ILikeNumberProvider
    {
        private int likesNumber = 0;

        public void LikeProduct()
        {
            likesNumber++;
        }

        public int GetNumberLikes()
        {
            return likesNumber;
        }
    }
}
