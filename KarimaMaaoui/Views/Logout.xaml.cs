using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KarimaMaaoui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Logout : ContentPage
    {
        public Logout()
        {
            InitializeComponent();
            LogoutAll();
        }
        public async void LogoutAll()
        {
            Preferences.Remove("mail");
            await Navigation.PushAsync(new Login());
        }
    }
}