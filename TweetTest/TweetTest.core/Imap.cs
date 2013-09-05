using System;
using System.Collections.Generic;
using System.Net.Mail;
using S22.Imap;

namespace TweetTest.core
{
    public class Imap
    {
        public static MessageInfo GetUnreadMessageAndSender()
        {
            using (var client = new ImapClient("imap.gmail.com", 993,
             "TextToTweet", "@1rf0rc3k1d", AuthMethod.Login, true))
            {
                var uids = client.Search(SearchCondition.Unseen());
                if (uids.Length >= 1)
                {
                    var message = client.GetMessage(uids[0], false, "inbox");
                    return new MessageInfo {EnclosedText = message.Body, Sender = message.From.ToString()};
                }
                return new MessageInfo();

            }
        }

        public static void DeleteMessages()
        {
            using (var client = new ImapClient("imap.gmail.com", 993,
             "TextToTweet", "@1rf0rc3k1d", AuthMethod.Login, true))
            {
                uint[] uids = client.Search(SearchCondition.Seen());
                MailMessage[] messages = client.GetMessages(uids);

                foreach(var uid in uids)
                {
                    client.DeleteMessage(uid);
                }
            }
        }
    }

}