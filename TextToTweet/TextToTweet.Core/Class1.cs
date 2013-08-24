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

<<<<<<< HEAD
    	        // set up the stream
    	        Stream reqStream = request.GetRequestStream();
    	        // write to the stream
    	        reqStream.Write(bytes, 0, bytes.Length);
    	        // close the stream
    	        reqStream.Close();
            }
            catch (Exception ex) { throw new NotSupportedException(); }
=======
            tc.CreateTokenRequestAuthorizationUrl();
>>>>>>> 0c4f5e54ce1d0f70c7e05c5c5a23fcdcd38bd28c
        }
    }
}