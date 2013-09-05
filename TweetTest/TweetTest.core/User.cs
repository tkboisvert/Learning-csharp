using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetTest.core
{
    public class User
    {
        public string Pin { get; set; }

        public static User LookupUserName(string sender)
        {
            var lookupTable = MyDictionary();

            if (lookupTable.ContainsKey(sender)) return lookupTable[sender];
            else throw new KeyNotFoundException("The user is not listed in the lookup table");
        }

        private static Dictionary<string, User> MyDictionary()
        {
            return new Dictionary<string, User>
                                 {
                                     {
                                         "+447803741296@mmail.co.uk",
                                         new User() {Pin = "8387557"}
                                     },
                                     {
                                         "tkboisvert@gmail.com",
                                         new User() {Pin = "8387557"}
                                     },
                                     {
                                         
                                         "texttotweet@gmail.com",
                                         new User() {Pin = "@1rf0rc3k1d"}
                                     }

                                 };
        } 
    }
}
