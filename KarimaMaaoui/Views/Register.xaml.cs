using KarimaMaaoui.DataBase;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KarimaMaaoui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Database.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<DataBaseQuery>();

            var item = new DataBaseQuery()
            {
                UserName = EntryUserName.Text,
                Email = EntryEmail.Text,
                Password = EntryPassword.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Congratulation", "User Registration Sucessfull", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new Login());

            });

        }
    }
}