﻿using System;
using TextToTweet.Core;


namespace TextToTweet.App
{
    public class Run
    {
        private static void Main(string[] args)
        {
            Class1.PostTweet("theboysenberry", "airkid123", "Test - sent via TEXTTOTWEET");
            Console.Read();
        }
    }
}