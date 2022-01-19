using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KarimaMaaoui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagazinFlyout : ContentPage
    {
        public ListView ListView;

        public MagazinFlyout()
        {
            InitializeComponent();

            BindingContext = new MagazinFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MagazinFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MagazinFlyoutMenuItem> MenuItems { get; set; }

            public MagazinFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MagazinFlyoutMenuItem>(new[]
                {
                    new MagazinFlyoutMenuItem { Id = 0, Title = "Dresses", TargetType=typeof(Dresses) },
                    new MagazinFlyoutMenuItem { Id = 1, Title = "Shoes", TargetType=typeof(Shoes) },
                    new MagazinFlyoutMenuItem { Id = 2, Title = "Clothing", TargetType=typeof(Clothing) },
                    new MagazinFlyoutMenuItem { Id = 3, Title = "Accessories", TargetType=typeof(Accessories) },
                 
                    new MagazinFlyoutMenuItem { Id = 4, Title = "Baby", TargetType=typeof(Baby) },
                    new MagazinFlyoutMenuItem { Id = 5, Title = "NewArrivals", TargetType=typeof(NewArrivals) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}