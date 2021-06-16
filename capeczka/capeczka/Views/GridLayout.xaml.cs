using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using capeczka.Model;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using capeczka.Views;
using capeczka.ViewModel;

namespace capeczka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
            TwitsResult();

            //^Tutaj odpalamy metodę przy starcie widoku, ale to jest do zmiany bo trzeba ją odpalać wraz ze startem bo zamula

        }



        public async void TwitsResult()
        {
            API.ApiV2 apiv2 = new API.ApiV2();
            CaruselView.ItemsSource = (ObservableCollection<CpkTwit>)await apiv2.Twits();
        }


        private async void Opacity_change(Frame fr)
        {
            await Task.Delay(25);
            await fr.FadeTo(0, 250);
            await Task.Delay(25);
            await fr.FadeTo(1, 250);

        }

        private async void Btn_Plane(object sender, EventArgs e)
        {
            try
            {

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
               // Opacity_change(Frame_Plane);
                Vibration.Vibrate(duration);
                await Navigation.PushAsync(new Flights(),true);


            }

            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private void Btn_Tickets(object sender, EventArgs e)
        {
            try
            {
                

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private async void Btn_Map(object sender, EventArgs e)
        {
            try
            {
                

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
                await Navigation.PushAsync(new Maps(), true);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private async void Btn_Shop(object sender, EventArgs e)
        {
            try
            {
                

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
                await Navigation.PushAsync(new TabbedPage1(), true);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private void Btn_Coupon(object sender, EventArgs e)
        {
            try
            {
                

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private void Btn_Parking(object sender, EventArgs e)
        {
            try
            {
                

                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private async void Btn_Menu(object sender, EventArgs e)
        {
            try
            {


                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
                await Navigation.PushAsync(new Settings(), true);
            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }
        private async void Btn_Camera(object sender, EventArgs e)
        {
            try
            {


                // Or use specified time
                var duration = TimeSpan.FromMilliseconds(5);
                Vibration.Vibrate(duration);
                await Navigation.PushAsync(new CameraView(),true);




            }
            catch (Exception)
            {
                // Other error has occurred.
            }

        }


    }
}