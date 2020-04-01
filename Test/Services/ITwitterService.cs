using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test.Services
{
    public interface ITwitterService
    {
        bool authenticate(string utilisateur, string password);

        List<Tweet> getTweets(string tweet);
    }
}
