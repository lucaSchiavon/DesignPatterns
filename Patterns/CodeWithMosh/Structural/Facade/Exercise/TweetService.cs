using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Exercise
{
    class TweetService
    {
        private string accessToken { get; }
        private TwitterClient twitterClient { get; }
        public TweetService()
        {
            accessToken = GetAccessToken();
            twitterClient = new TwitterClient();
        }

       

        public List<Tweet> GetTweet()
        {
            var tweets = twitterClient.getRecentTweets(accessToken);
            return tweets;        
        }
        public void NewTweet(Tweet tweet)
        {
            twitterClient.NewTweet(accessToken, tweet);
        }

        public void LikeTweet(Tweet tweet)
        {
            twitterClient.LikeTweet(accessToken, tweet);
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken("appKey", "secret");
            var accessToken = oauth.getAccessToken(requestToken);
            return accessToken;
        }

    }
}
