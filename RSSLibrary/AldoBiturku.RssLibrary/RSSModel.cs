using System;
using System.Collections.Generic;
using System.Text;

namespace AldoBiturku.RssLibrary
{
    public class RSSModel
    {
        private string id;
        private string title;
        private string summary;

        public string Title { get => title; set => title = value; }
        public string Summary { get => summary; set => summary = value; }
        public string ID { get => id; set => id = value; }
    }
}
