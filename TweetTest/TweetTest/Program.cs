using System;
using System.Diagnostics;
using TweetSharp;
using TweetTest.core;
using System.Threading;


namespace TweetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Pass your credentials to the service
            //TwitterService service = new TwitterService("UuvSzR1mttDQgHeIjeAGgg", "dOYJaH7GhcCG5AYfWmyKodtfYDc2K0BV4uINJyGJ4Q");

            //// Step 1 - Retrieve an OAuth Request Token
            //OAuthRequestToken requestToken = service.GetRequestToken();

            //// Step 2 - Redirect to the OAuth Authorization URL
            //Uri uri = service.GetAuthorizationUri(requestToken);
            //Process.Start(uri.ToString());

            //Console.WriteLine("EnterPin");

            //// Step 3 - Exchange the Request Token for an Access Token
            //string verifier = Console.ReadLine(); 
            //OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);

            //// Step 4 - User authenticates using the Access Token
            //service.AuthenticateWith(access.Token, access.TokenSecret);

            //var tweetOptions = new SendTweetOptions { Status = "Test" };

            //service.SendTweet(tweetOptions);

            //Console.Read();

            //var twitterApp = new TwitterService("UuvSzR1mttDQgHeIjeAGgg", "dOYJaH7GhcCG5AYfWmyKodtfYDc2K0BV4uINJyGJ4Q");
            //twitterApp.AuthenticateWith("867817268-Aq4GMwKVOJYf6PGDGbJ0u6vvcNvqaDTiYdSga8Tf", "GfGoxR9GLWvViS9Ch2F5e8LUMr40nsil49IFk1LVOs");
            //var tweetOptions = new SendTweetOptions { Status = "Test" };
            //twitterApp.SendTweet(tweetOptions);

            while (true)
            {
                StartProcessing.StartValidation();

                Thread.Sleep(5000);

                Console.Clear();
            }
        }
    }
}
