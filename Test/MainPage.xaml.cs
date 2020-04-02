using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        public async void Connection_Clicked(object sender, EventArgs e)
        {
            this.erreur.IsVisible = false;

            if (string.IsNullOrEmpty(DependencyService.Get<ITwitterService>().authenticate(this.identifiant.Text, this.mdp.Text)))
            {
                await Navigation.PushAsync(new ListTweet()); 
            }
            else
            {
                AfficherErreur(DependencyService.Get<ITwitterService>().authenticate(this.identifiant.Text, this.mdp.Text));
            }

            
        }

        private void AfficherErreur(string message)
        {
            this.erreur.Text = message;
            this.erreur.IsVisible = true;
        }

    }
}
