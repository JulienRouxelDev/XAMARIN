using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTweet : ContentPage
    {
        public ListTweet()
        {
            InitializeComponent();

            ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();
            
            tweets.Add(new Tweet { DateCreation = "01/04/2020", Id = "1", Texte = "Premier tweet", UserId = "1", UserName = "Julien ROUXEL", UserPseudo = "julien" });
            tweets.Add(new Tweet { DateCreation = "31/03/2020", Id = "2", Texte = "Second tweet", UserId = "2", UserName = "Julien ROUXEL", UserPseudo = "julien" });

            this.listTweet.ItemsSource = tweets;
        }
    }
}