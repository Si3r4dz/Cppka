using capeczka.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace capeczka.ViewModel
{
    class CpkTwitsViewModel
    {

        public ObservableCollection<CpkTwit> TwitsList { get; private set; } = new ObservableCollection<CpkTwit>();

        public CpkTwitsViewModel()
        {
            TwitsResult();

        }

        public async void TwitsResult()
        {
            API.ApiV2 apiv2 = new API.ApiV2();
            TwitsList = (ObservableCollection<CpkTwit>)await apiv2.Twits();
        }

       
    }
}
