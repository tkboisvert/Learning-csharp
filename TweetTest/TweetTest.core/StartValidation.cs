using System;
using System.Collections.Generic;
using System.Linq;
using TweetSharp;

namespace TweetTest.core
{
    public class StartProcessing
    {
        public static void StartValidation()
        {
            Console.Clear();
            //Start Status thread
            var status = TextAndUi.GetStatisThread();
            status.Start("Validating");

            //Check for Messages
            var tweetAndSenderData = Imap.GetUnreadMessageAndSender();

            if (tweetAndSenderData != null)
            {
                //Get credentials
                //var user = User.LookupUserName(tweetAndSenderData.Sender);

                //Authurize connection and app
                var authenticate = new Authenticate();
                var tweetApp = authenticate.CreateClient();

                //End thread
                status.Abort();
                Console.WriteLine("Validated!");
                Console.Clear();

                //Post tweets
                PostContent("test", tweetApp);

                //Delete messages
                Imap.DeleteMessages();

            }

            else
            {
                //End thread
                status.Abort();
                TextAndUi.ShowSomethingToTheUser("The box is empty, or TTT could not secure a connection", true);
            }

        }


        private static void PostContent(string myTweet, TwitterService tweetApp)
        {
            if (TextAndUi.MessageIsSuitableLength(myTweet))
            {
                //Start Status Thread
                //var status = TextAndUi.GetStatisThread();
                //status.Start("Posting");

                //Post tweet
                Interact.PostTweet(tweetApp, myTweet + "\n\n Sent via T³");

                //End thread
                // status.Abort();

                //For Succuess
                //TextAndUi.IsSuccuess(responseText);
            }
        }
    }
}
