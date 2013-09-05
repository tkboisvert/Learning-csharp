using Hammock.Authentication.OAuth;
using TweetSharp;

namespace TweetTest.core
{
    public class Authenticate
    {
        public TwitterService CreateClient()
        {
            var twitterApp = new TwitterService("UuvSzR1mttDQgHeIjeAGgg", "dOYJaH7GhcCG5AYfWmyKodtfYDc2K0BV4uINJyGJ4Q");
            twitterApp.AuthenticateWith("867817268-Aq4GMwKVOJYf6PGDGbJ0u6vvcNvqaDTiYdSga8Tf", "GfGoxR9GLWvViS9Ch2F5e8LUMr40nsil49IFk1LVOs");

            return twitterApp;
        }
    }
}
