using capeczka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace capeczka.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestaurantView : ContentPage
	{
		public RestaurantView ()
		{
			InitializeComponent ();
			CarView_Restaurant.ItemsSource = Restaurants();
		}


		private ObservableCollection<Restaurant> Restaurants()
		{
			ObservableCollection<Restaurant> RestaurantList = new ObservableCollection<Restaurant>();
			for (int i = 0; i < 10; i++)
			{
				RestaurantList.Add(new Restaurant { Name = "Mcd", Description = "Sklep", Img = "mcdonalds.jpg" });
			}
			return RestaurantList;
		}
	}
}