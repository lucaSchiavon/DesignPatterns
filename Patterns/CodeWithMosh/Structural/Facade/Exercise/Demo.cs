using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Exercise
{
    class Demo
    {
        public static void show()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken("appKey", "secret");
            var accessToken = oauth.getAccessToken(requestToken);

            var twitterClient = new TwitterClient();
            var tweets = twitterClient.getRecentTweets(accessToken);
        }
    }
}
