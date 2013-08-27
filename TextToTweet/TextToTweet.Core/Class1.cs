using oAuthConnection;
using TweetinCore;
using Tweetinvi;
using TwitterToken;
using System;


namespace TextToTweet.Core
{
    public class Class1
    {
        public static void PostTweet(string username, string password, string tweet)
        {
            TokenCreator tc = new TokenCreator("UuvSzR1mttDQgHeIjeAGgg", "dOYJaH7GhcCG5AYfWmyKodtfYDc2K0BV4uINJyGJ4Q");

            Console.WriteLine(tc.ToString());

            TokenCredentials toc = new TokenCredentials("867817268-Aq4GMwKVOJYf6PGDGbJ0u6vvcNvqaDTiYdSga8Tf", "GfGoxR9GLWvViS9Ch2F5e8LUMr40nsil49IFk1LVOs", "UuvSzR1mttDQgHeIjeAGgg", "dOYJaH7GhcCG5AYfWmyKodtfYDc2K0BV4uINJyGJ4Q");

            OAuthToken oat = new OAuthToken(toc);

            tc.CreateTokenRequestAuthorizationUrl();
        }
    }
}