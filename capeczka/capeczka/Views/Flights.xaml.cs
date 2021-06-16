using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace capeczka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flights : ContentPage
    {
        public Flights()
        {
            InitializeComponent();
            
            
        }

        private async void Btn_Odloty(object sender, EventArgs e)
        {
            Vibration.Vibrate(TimeSpan.FromMilliseconds(5));
            await Navigation.PushAsync(new WeatherApp("Odloty"),true);
        }
        private async void Btn_Przyloty(object sender, EventArgs e)
        {

            Vibration.Vibrate(TimeSpan.FromMilliseconds(5));
            await Navigation.PushAsync(new WeatherApp("Przyloty"),true);
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            // Page appearance not animated
            await Navigation.PopAsync(true);
        }
    }
}