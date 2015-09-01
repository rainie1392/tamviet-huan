using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace TamVietFE.Src
{
    public partial class AjaxWeather : System.Web.UI.Page
    {
        public class YahooWeatherRssItem
        {
            public string Text { get; set; }
            public string Code { get; set; }
            //public string Description { get; set; }
            //public string City { get; set; }
            //public string Country { get; set; }
            // temp, wind, etc...
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request["id"];
            var m_strFilePath = "http://weather.yahooapis.com/forecastrss?w="+id+"&u=c";
            XDocument rssXml = XDocument.Load(m_strFilePath);
            XNamespace wind = "http://xml.weather.yahoo.com/ns/rss/1.0";
            XElement dateBuild = rssXml.Element("rss").Element("channel").Element("lastBuildDate");
            string speed = rssXml.Descendants(wind + "wind").FirstOrDefault().Attribute("speed").Value;
            string humidity = rssXml.Descendants(wind + "atmosphere").FirstOrDefault().Attribute("humidity").Value;
            string visibility = rssXml.Descendants(wind + "atmosphere").FirstOrDefault().Attribute("visibility").Value;

            string condition = rssXml.Descendants(wind + "condition").FirstOrDefault().Attribute("text").Value;
            string code = rssXml.Descendants(wind + "condition").FirstOrDefault().Attribute("code").Value;
            string temp = rssXml.Descendants(wind + "condition").FirstOrDefault().Attribute("temp").Value;
            string updatedTime = dateBuild.Value;

            string html = string.Empty;
            if (File.Exists(Server.MapPath("/Src/Template/Weather.html")))
                html = File.ReadAllText(Server.MapPath("/Src/Template/Weather.html"));

            html = html.Replace("{code}", code);
            html = html.Replace("{humidity}", humidity);
            html = html.Replace("{visibility}", visibility);
            html = html.Replace("{speed}", speed);
            html = html.Replace("{condition}", condition);
            html = html.Replace("{temp}", temp);
            html = html.Replace("{updatedTime}", updatedTime);

            litHtml.Text = html;
        }
    }
}