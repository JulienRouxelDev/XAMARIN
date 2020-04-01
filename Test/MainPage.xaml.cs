using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Services;
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

        public void Connection_Clicked(object sender, EventArgs e)
        {
            this.erreur.IsVisible = false;

            string message = "";
            //Console.WriteLine("connexion OK");
            if (this.identifiant.Text == null || this.identifiant.Text.Length < 3)
            {
                //DisplayAlert("Erreur", "L'identifiant doit contenir au moins 3 caractères", "OK");
                message = "L'identifiant doit contenir au moins 3 caractères";
                AfficherErreur(message);
                return;
            }
            if (this.mdp.Text == null || this.mdp.Text.Length < 6)
            {
                //DisplayAlert("Erreur", "Le mot de passe doit contenir au moins 6 caractères", "OK");
                message = "Le mot de passe doit contenir au moins 6 caractères";
                AfficherErreur(message);
                return;
            }

            if (DependencyService.Get<ITwitterService>().authenticate(this.identifiant.Text, this.mdp.Text))
            {
                this.tweet.IsVisible = true;
            }
            message = "L'identifiant ou le mot de passe est incorrect";
            AfficherErreur(message);
            //return;

        }

        private void AfficherErreur(string message)
        {
            this.erreur.Text = message;
            this.erreur.IsVisible = true;
        }

    }
}
