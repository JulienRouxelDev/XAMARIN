using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Test.Services;
using Test.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwitterService))]
namespace Test.UWP
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string utilisateur, string password)
        {
            if (utilisateur=="julien" && password=="123456")
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets(string tweet)
        {
            List<Tweet> tweets = new List<Tweet>();

            tweets.Add(new Tweet { DateCreation = "01/04/2020", Id = "1", Texte = "Premier tweet", UserId = "1", UserName = "Julien ROUXEL", UserPseudo = "julien" });
            tweets.Add(new Tweet { DateCreation = "31/03/2020", Id = "2", Texte = "Second tweet", UserId = "2", UserName = "Julien ROUXEL", UserPseudo = "julien" });

            return tweets;

        }
    }
}
