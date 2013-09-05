using System;
using TweetSharp;


namespace TweetTest.core
{
    public class Interact
    {
        public static void PostTweet(TwitterService tweetApp, string tweet )
        {
            var tweetOptions = new SendTweetOptions() {Status = "another test"};

            if (tweetApp != null)
            {
                try
                {
                    tweetApp.SendTweet(tweetOptions);
                }
                catch (Exception ex)
                {
                    
                    throw;
                }
                

            
            }
        }
    }
}
