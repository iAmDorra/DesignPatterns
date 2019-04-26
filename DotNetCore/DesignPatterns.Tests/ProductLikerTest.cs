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
            var liker = new ProductAnalysis();
            var counter = new LikesCounter(liker);
            liker.LikeProduct();
            Check.That(counter.LikeNumber).IsEqualTo(1);
        }

        [TestMethod]
        public void Should_return_two_likes_when_two_likes_added()
        {
            var liker = new ProductAnalysis();
            var counter = new LikesCounter(liker);
            liker.LikeProduct();
            liker.LikeProduct();
            Check.That(counter.LikeNumber).IsEqualTo(2);
        }
    }
}
