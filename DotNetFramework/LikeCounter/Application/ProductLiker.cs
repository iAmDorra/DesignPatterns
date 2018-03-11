namespace LikeCounter
{
    public class ProductLiker : ILikeNumberProvider
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
