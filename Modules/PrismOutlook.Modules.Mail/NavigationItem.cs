using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PrismOutlook.Business
{
    public class NavigationItem
    {
        public String Caption { get; set; }

        public String NavigationPath { get; set; }

        public ObservableCollection<NavigationItem> Items { get; set; }

        public NavigationItem()
        {
            Items = new ObservableCollection<NavigationItem>();
        }
    }
}
