using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace capeczka
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherApp : ContentPage
    {
        public WeatherApp(string str)
        {

            InitializeComponent();
            lbl_Navbar.Text = str;
            ArrDepList.ItemsSource = InfoData(str);



        }

        public ObservableCollection<Info> InfoData(string str)
        {

            if (str == "Odloty")
            {
                var tempList = new ObservableCollection<Info>
                {

                    new Info { Number = "LA 1456", City = "WARSZAWA", Time = " 17:20", DepAr = "departures.png", Expands= new ObservableCollection<Expand>{ new Expand { Text="Tutaj powinny być",Text2="GATE 42", Terminal="Terminal 3", Icon = "wizz.png" } }  },
                    new Info { Number = "LA 1456", City = "NOWY JORK", Time = " 19:22", DepAr = "departures.png", Expands= new ObservableCollection<Expand>{ new Expand { Text= "Jebać kurwy ", Text2= "GATE 13", Terminal = "Terminal 3", Icon = "wizz.png" } }   },
                    new Info { Number = "LA 1456", City = "WROCŁAW", Time = " 21:00", DepAr = "departures.png", Expands= new ObservableCollection<Expand>{ new Expand { Text= "Tutaj powinny być", Text2= "GATE 3", Terminal = "Terminal 3", Icon = "wizz.png" } }   },
                    new Info { Number = "LA 1456", City = "LONDYN", Time = " 21:00", DepAr = "departures.png", Expands= new ObservableCollection<Expand>{ new Expand { Text= "Tutaj powinny być ", Text2= "GATE 15", Terminal = "Terminal 3", Icon = "wizz.png" } }   }
                };
                return tempList;
            }
            else if (str == "Przyloty")
            {
                var tempList = new ObservableCollection<Info>
                {
                    new Info { Number = "LA 1456", City = "CLEVELAND", Time = " 15:14", DepAr = "arrivals.png"},

                    new Info { Number = "LA 1456", City = "WROCŁAW", Time = " 18:56", DepAr = "arrivals.png" },

                    new Info { Number = "LA 1456", City = "AMSTERDAM", Time = " 20:00", DepAr = "arrivals.png" },
                    new Info { Number = "LA 1456", City = "WARSZAWA", Time = " 21:00", DepAr = "arrivals.png" },

                    new Info { Number = "LA 1456", City = "LONDYN", Time = " 21:00", DepAr = "arrivals.png" },
                    new Info { Number = "LA 1456", City = "LONDYN", Time = " 21:00", DepAr = "arrivals.png" }
                };
                return tempList;
            }
            else
            {
                var tempList = new ObservableCollection<Info>
                {
                    new Info { Number = "LA 1456", City = "CLEVELAND", Time = " 15:14", DepAr = "arrivals.png" },

                    new Info { Number = "LA 1456", City = "WROCŁAW", Time = " 18:56", DepAr = "arrivals.png" },

                    new Info { Number = "LA 1456", City = "AMSTERDAM", Time = " 20:00", DepAr = "arrivals.png" },
                    new Info { Number = "LA 1456", City = "WARSZAWA", Time = " 21:00", DepAr = "arrivals.png" },

                    new Info { Number = "LA 1456", City = "LONDYN", Time = " 21:00", DepAr = "arrivals.png" },
                    new Info { Number = "LA 1456", City = "LONDYN", Time = " 21:00", DepAr = "arrivals.png" }
                };
                return tempList;
            }



        }
    }

    public class Info
    {
        public string City { get; set; }
        public string Time { get; set; }
        public string Number { get; set; }
        public string DepAr { get; set; }

        public ObservableCollection<Expand> Expands { get; set; }
    }
    public class Expand
    {
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Terminal { get; set; }
        public string Icon { get; set; }

    }

}