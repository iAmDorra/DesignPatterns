using LikeCounter;
using LikeCounter.LikeBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ProductLikerTest
    {
        [TestMethod]
        public void Should_return_one_like_when_only_one_like_added()
        {
            ProductLiker liker = new ProductLiker();
            liker.LikeProduct();
            int numberLikes = liker.GetNumberLikes();
            Check.That(numberLikes).IsEqualTo(1);
        }

        [TestMethod]
        public void Should_return_two_likes_when_two_likes_added()
        {
            ProductLiker liker = new ProductLiker();
            liker.LikeProduct();
            liker.LikeProduct();
            int numberLikes = liker.GetNumberLikes();
            Check.That(numberLikes).IsEqualTo(2);
        }

        [TestMethod]
        public void Should_return_likes_number_when_calling_product_liker()
        {
            ProductLiker liker = new ProductLiker();
            liker.LikeProduct();
            LikesCounter counter = new LikesCounter(liker);
            int likeNumber = counter.CountLikes();
            Check.That(likeNumber).IsEqualTo(1);
        }

        [TestMethod]
        public void Should_run_timer_when_start_runner()
        {
            var runner = new Runner(new LikesCounter(new ProductLiker()));
            runner.Run();

            runner.Stop();
        }
    }
}
