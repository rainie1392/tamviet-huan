using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using TamViet.Src.Helper;

namespace TamViet.Src
{
    public partial class _FE : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string dayofweek = "";
                switch ((int)DateTime.Today.DayOfWeek)
                {
                    case 0: dayofweek = "Chủ nhật"; break;
                    case 1: dayofweek = "Thứ 2"; break;
                    case 2: dayofweek = "Thứ 3"; break;
                    case 3: dayofweek = "Thứ 4"; break;
                    case 4: dayofweek = "Thứ 5"; break;
                    case 5: dayofweek = "Thứ 6"; break;
                    case 6: dayofweek = "Thứ 7"; break;
                }
                litDayOfWeek.Text = dayofweek;
                litToday.Text = DateTime.Today.ToString("dd/MM/yyyy");

                #region[ExchangeBox]
                try
                {
                    var m_strFilePath = "http://vietcombank.com.vn/ExchangeRates/ExrateXML.aspx";
                    string xmlStr;
                    using (var wc = new WebClient())
                    {
                        xmlStr = wc.DownloadString(m_strFilePath);
                    }
                    var xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xmlStr);
                    XmlNode rootNode = xmlDoc.SelectSingleNode("ExrateList");
                    XmlNodeList list = rootNode.SelectNodes("Exrate");
                    XmlNode nodeDate = rootNode.SelectSingleNode("DateTime");

                    string html = string.Empty;
                    if (File.Exists(Server.MapPath("/Src/Template/Currency.html")))
                        html = File.ReadAllText(Server.MapPath("/Src/Template/Currency.html"));

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Attributes["CurrencyCode"].Value == "AUD" || list[i].Attributes["CurrencyCode"].Value == "EUR" ||
                            list[i].Attributes["CurrencyCode"].Value == "JPY" || list[i].Attributes["CurrencyCode"].Value == "GBP" ||
                            list[i].Attributes["CurrencyCode"].Value == "USD")
                        {
                            var temp_html = html;
                            temp_html = temp_html.Replace("{code}", list[i].Attributes["CurrencyCode"].Value);
                            temp_html = temp_html.Replace("{buy}", FormatHelper.FormatPrice(list[i].Attributes["Buy"].Value));
                            temp_html = temp_html.Replace("{transfer}", FormatHelper.FormatPrice(list[i].Attributes["Transfer"].Value));
                            temp_html = temp_html.Replace("{sell}", FormatHelper.FormatPrice(list[i].Attributes["Sell"].Value));
                            litCurrencyDetail.Text += temp_html;
                        }
                    }

                    litUpdatedCurrencyTime.Text = nodeDate.InnerText;
                }
                catch
                {

                }


                #endregion

            }
        }
    }
}