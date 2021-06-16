using capeczka.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using capeczka.Model;
using System.Collections.ObjectModel;

namespace capeczka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Services : ContentPage
    {

        public Services()
        {
            InitializeComponent();
            CarView_Shops.ItemsSource = Shops();

        }
        public async void ItemTapped(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(5));
            await Navigation.PushAsync(new Maps(), true);
        }

        private ObservableCollection<Shop> Shops()
        {
            ObservableCollection<Shop> ShopList = new ObservableCollection<Shop>();
            for (int i = 0; i < 10; i++)
            {
                ShopList.Add(new Shop { ServiceName = "Mcd", Description = "Sklep", ServiceImg = "mcdonalds.jpg" });
            }
            return ShopList;
        }

    }

   

    
}