using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimaMaaoui.DataBase;
using SQLite;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KarimaMaaoui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            bool Existance = Preferences.ContainsKey("mail");
            if (!Existance)
            {
                Navigation.PushAsync(new Login());
            }
        }


        public async void Magazin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Magazin());
        }
        public async void IsetRades(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IsetRades());
        }
        public async void Voiture(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Voiture());
        }
        public async void Logout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}