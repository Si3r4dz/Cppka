using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using capeczka.Model;
using System.Collections.ObjectModel;

namespace capeczka.API
{
    class ApiV2
    {
        public async Task<IEnumerable<CpkTwit>> Twits() //Metoda do łączenia się z Api twittera oraz do pobierania danych na temat CPK.
        {
            var userClient = new TwitterClient("O5i2H5GC0v3dhYAHe3alljlt2", "YakcQ4QbHSqS3mZ6NWmWvdE5ERYm2J7njrvwLSIU6BqcnP6Slq", "1356914659400568832-pcb4xSmPBfu73MPPeUGTybAGy9z2rJ", "mfkMqetcsdhy9zxi7Hngx75n2rV8GvtMfqFbuwHvBlJFA");

            var userTimeline = await userClient.Timelines.GetUserTimelineAsync("STH_Poland");

            ObservableCollection<CpkTwit> cpk = new ObservableCollection<CpkTwit>();
            foreach (var item in userTimeline)
            {
                cpk.Add(new CpkTwit
                {
                    Text = item.Text,
                    Created_at = item.CreatedAt.DateTime.ToString(),
                    Username = item.CreatedBy.ToString()
                });
            }

            return cpk;


        }

    }
}
