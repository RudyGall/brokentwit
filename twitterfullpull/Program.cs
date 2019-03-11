using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twitterfullpull
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new Twitter(OauthConsumerKey,
                          MvcApplication.OauthConsumerKeySecret,
                          MvcApplication.OauthAccesToken,
                          MvcApplication.OauthAccessTokenSecret);

            //twitter.PostStatusUpdate(status, 54.35,-0.2);
            var response = twitter.GetTweets("GCSocialMediaT1", 5);
            dynamic timeline = System.Web.Helpers.Json.Decode(response);
            foreach (var tweet in timeline)
            {
                string text = tweet["text"].ToString();
                model.Timeline.Add(text);
            }
        }
    }
}
