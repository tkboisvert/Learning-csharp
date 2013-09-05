//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TweetTest.core
//{
//    class UserUse
//    {
//        Console.Clear();
//                //Start Status thread
//                var status = TextAndUi.GetStatisThread();
//                status.Start("Validating");

//                //Authurize connection and app
//                var authenticate = new Authenticate();
//                var tweetApp = authenticate.Authurize();

//                //End thread
//                status.Abort();
//                Console.WriteLine("Validated!");

//                var myTweet = TextAndUi.GetText();

//                Console.Clear();
//                status = TextAndUi.GetStatisThread();
//                status.Start("Posting");

//                var responseText = Interact.PostTweet(tweetApp, myTweet).Response.Response;

//                status.Abort();

//                TextAndUi.IsSuccuess(responseText);

//                Console.Read();
//    }
//}
