using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TamViet.Src.BE.PageImages
{
    public partial class NewsImages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            DirectoryInfo d = new DirectoryInfo(Server.MapPath("/Images/news/"));
            FileInfo[] listFile = d.GetFiles("*.*", SearchOption.AllDirectories);
            litImages.DataSource = listFile;
            litImages.DataBind();
        }

        protected void litImages_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            Image img = e.Item.FindControl("img") as Image;
            img.ImageUrl = "/Images/news/" + DataBinder.Eval(e.Item.DataItem, "Name").ToString();

            Literal litFileName = e.Item.FindControl("litFileName") as Literal;
            litFileName.Text = DataBinder.Eval(e.Item.DataItem, "Name").ToString();
        }

        protected void litImages_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            dtpgImages.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            LoadData();
        }
    }
}