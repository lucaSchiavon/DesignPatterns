using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Exercise
{
    class TwitterClient
    {
        List<Tweet> tweets = new List<Tweet>();
        public List<Tweet> getRecentTweets(String accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return tweets;
        }

        public void NewTweet(string accessToken, Tweet tweet)
        {
            Console.WriteLine("Tweet new message " + tweet.Message);
            tweets.Add(tweet);
        }

        public void LikeTweet(string accessToken, Tweet tweet)
        {
            Console.WriteLine("Like the tweet");
        }
    }
}
