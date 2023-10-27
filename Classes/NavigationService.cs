using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimFolhaPagamento.Classes
{
    public class NavigationService
    {
        private List<NavigationItem> navigationItems = new List<NavigationItem>();

        public void AddNavigationItem(string title, string url)
        {
            navigationItems.Add(new NavigationItem(title, url));
        }

        public List<NavigationItem> GetNavigationItems()
        {
            return navigationItems;
        }
    }

    public class NavigationItem
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public NavigationItem(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}