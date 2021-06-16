using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using capeczka.Model;

namespace capeczka.ViewModel
{
    class MapServiceViewModel
    {
        public IList<MapService> MapServiceList { get; set; }
        public MapServiceViewModel()
        {

            MapServiceList = new ObservableCollection<MapService>();
            MapServiceList.Add(new MapService() { MapServiceImg = "wizz.png", MapServiceName = "McDonald's" });
            MapServiceList.Add(new MapService() { MapServiceImg = "wizz.png", MapServiceName = "McDonald's" });
            MapServiceList.Add(new MapService() { MapServiceImg = "wizz.png", MapServiceName = "McDonald's" });
            MapServiceList.Add(new MapService() { MapServiceImg = "wizz.png", MapServiceName = "McDonald's" });
            MapServiceList.Add(new MapService() { MapServiceImg = "wizz.png", MapServiceName = "McDonald's" });

        }
    }
}
