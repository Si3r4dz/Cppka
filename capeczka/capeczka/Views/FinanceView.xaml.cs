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
	public partial class FinanceView : ContentPage
	{
		public FinanceView ()
		{
			InitializeComponent ();
			CarView_Finance.ItemsSource = Finances();
		}


		private ObservableCollection<Finance> Finances()
		{
			ObservableCollection<Finance> FinanceList = new ObservableCollection<Finance>();
			for (int i = 0; i < 10; i++)
			{
				FinanceList.Add(new Finance { Name = "Mcd", Description = "Sklep", Img = "mcdonalds.jpg" });
			}
			return FinanceList;
		}
	}
}