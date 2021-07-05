using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace AldoBiturku.RssLibrary
{
    public class RSS
    {
        public List<RSSModel> getRSS()
        {
            SyndicationFeed feed = null;
            List<RSSModel> rssList = new List<RSSModel>();

            try
            {
                using (var reader = XmlReader.Create("http://feeds.bbci.co.uk/news/rss.xml"))
                {
                    feed = SyndicationFeed.Load(reader);
                }
            }
            catch { } // TODO: Deal with unavailable resource.

            if (feed != null)
            {
                foreach (var element in feed.Items)
                {
                    RSSModel data = new RSSModel();
                    data.ID = element.Id;
                    data.Title = element.Title.Text;
                    data.Summary = element.Summary.Text;

                    rssList.Add(data);
                }
            }

            return rssList;
        }
    }
}
