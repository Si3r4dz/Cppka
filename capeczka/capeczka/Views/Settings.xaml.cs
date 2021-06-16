using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace capeczka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<SettingsName> Setting { get => SettingsData(); }

        private List<SettingsName> SettingsData()
        {
            var tempList = new List<SettingsName>();
            tempList.Add(new SettingsName { Name = "Tryb nocny" });
            tempList.Add(new SettingsName { Name = "Powiadomienia Push"});
            tempList.Add(new SettingsName { Name = "Powiadomienia Marketingowe"});
            tempList.Add(new SettingsName { Name = "Powiadomienai Tweet"});
            tempList.Add(new SettingsName { Name = "Powiadomienia Lotnicze"});

            return tempList;
        }
    }

    public class SettingsName
    {
        public string Name { get; set; }
    }
}