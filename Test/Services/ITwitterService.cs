using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test.Services
{
    public interface ITwitterService
    {
        string authenticate(string utilisateur, string password);

        List<Tweet> getTweets(string tweet);
    }
}
