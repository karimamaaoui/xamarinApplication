using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimaMaaoui.DataBase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace KarimaMaaoui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Database.db");
            var db = new SQLiteConnection(dbpath);
            var muquery = db.Table<DataBaseQuery>().Where(u => u.Email.Equals(EntryEmail.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (muquery != null)
            {
                Preferences.Set("mail",EntryEmail.Text);

                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () => {
                    var result = await this.DisplayAlert("Error", "Failed Email and/or Password", "Yes", "Cancel");

                    if (result)
                        await Navigation.PushAsync(new Login());
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }
                });
            }
        }
    }
}