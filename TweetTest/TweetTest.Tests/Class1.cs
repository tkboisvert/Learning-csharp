using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSubstitute;
using NUnit.Framework;
using TweetSharp;

namespace TweetTest.Tests
{
    [TestFixture]
    public class When_broadcasting_a_message_via_twitter
    {
        [Test]
        public void Should_call_tweet_service()
        {
            ITwitterService tweetSharp = Substitute.For<ITwitterService>();

            var messageBroadCaster = new TwitterMessageBroadCaster(tweetSharp);
            
            messageBroadCaster.SendMessage("Foo");

            tweetSharp.Received().SendTweet(Arg.Is<SendTweetOptions>(x => x.Status == "Foo"));
        }
    }

    public class TwitterMessageBroadCaster
    {
        private ITwitterService twitterService;

        public TwitterMessageBroadCaster(ITwitterService tweetSharp)
        {
            twitterService = tweetSharp;
        }

        public void SendMessage(string message)
        {
            twitterService.SendTweet(new SendTweetOptions(){Status = message});
        }
    }
}
