using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamViet.Src.Helper;

namespace TamViet.Src
{
    public partial class NewsDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request["id"];
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@Id", id));
                var table = DBHelper.GetDataTableSP("sp_News_GetNewsById",list);
                if (table != null && table.Rows.Count > 0)
                {
                    litContent.Text = table.Rows[0]["NewsContent"].ToString();
                    litTitle.Text = table.Rows[0]["Title"].ToString();
                }
            }
        }
    }
}