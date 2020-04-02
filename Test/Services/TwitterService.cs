using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Test.Services;
using Test.UWP;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwitterService))]
namespace Test.UWP
{
    class TwitterService : ITwitterService
    {
        public string authenticate(string utilisateur, string password)
        {

            string message = "";

            var current = Connectivity.NetworkAccess;
            if (current != NetworkAccess.Internet)
            {
                message = "Veuillez vous connecter à internet";             
                return message;
            }

            if (utilisateur == null || utilisateur.Length < 3)
            {
                message = "L'identifiant doit contenir au moins 3 caractères";
                return message;
            }

            if (password == null || password.Length < 6)
            {
                message = "Le mot de passe doit contenir au moins 6 caractères";
                return message;
            }
        
            if (utilisateur!="julien" || password!="123456")
            {
                message = "L'identifiant ou le mot de passe est incorrect";
                return message;
            }
            return message;
        }

        public List<Tweet> getTweets(string tweet)
        {
            List<Tweet> tweets = new List<Tweet>();

            //tweets.Add(new Tweet { DateCreation = "01/04/2020", Id = "1", Texte = "Premier tweet", UserId = "1", UserName = "Julien ROUXEL", UserPseudo = "julien" });
            //tweets.Add(new Tweet { DateCreation = "31/03/2020", Id = "2", Texte = "Second tweet", UserId = "2", UserName = "Julien ROUXEL", UserPseudo = "julien" });

            return tweets;

        }
    }
}
