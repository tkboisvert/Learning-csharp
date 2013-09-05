using TweetSharp;


namespace TweetTest.core
{
    public class Interact
    {
        public static void PostTweet(TwitterService tweetApp, string tweet )
        {
            var tweetOptions = new SendTweetOptions() {Status = tweet};

            if (tweetApp != null)
            {
                tweetApp.SendTweet(tweetOptions);

            
            }
        }
    }
}
