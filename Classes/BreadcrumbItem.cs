using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimFolhaPagamento.Classes
{
    public class BreadcrumbItem
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public BreadcrumbItem(string title, string url)
        {
            Title = title;
            Url = url;
        }
         
    }
}