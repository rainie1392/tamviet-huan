using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamViet.Src.Helper;

namespace TamViet.Src.BE.PageNews
{
    public partial class ManagerNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            var table = DBHelper.GetDataTableSP("sp_News_GetAllNews");
            dtgNews.DataSource = table;
            dtgNews.DataBind();
            dtgNews.FooterStyle.CssClass = "footer-grd-stdtable";
            dtgNews.HeaderStyle.CssClass = "head-grd-stdtable";
            dtgNews.CssClass = "grd-stdtable";
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNews.aspx");
        }

        protected void dtgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "cmdDelete")
            {
                try
                {
                    Label lblId = e.Item.FindControl("lblId") as Label;
                    var id = lblId.Text;
                    List<SqlParameter> listPar = new List<SqlParameter>();
                    listPar.Add(new SqlParameter("@Id", id));
                    DBHelper.ExecuteNonQuery("sp_News_DeleteNews", listPar);
                    Notify.ShowAdminMessageSuccess("Xóa thành công",this.Page);
                    LoadGrid();
                }
                catch
                {
                    Notify.ShowAdminMessageError("Lỗi", this.Page);
                    LoadGrid();
                }
                
            }
        }

        protected void dtgNews_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dtgNews.CurrentPageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void dtgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                ImageButton imgDelete = e.Item.FindControl("btnDelete") as ImageButton;
                imgDelete.OnClientClick = "javascript : return confirm('Bạn có chắc muốn xóa không?')";

                DropDownList ddl = e.Item.FindControl("ddlType") as DropDownList;
                ddl.SelectedValue = DataBinder.Eval(e.Item.DataItem, "Type").ToString();
                ddl.Enabled = false;
            }
        }
    }
}