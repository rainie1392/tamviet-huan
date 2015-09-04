using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamVietBE.Src.Helper;

namespace TamVietBE.Src
{
    public partial class ProductManager : System.Web.UI.Page
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
            var table = DBHelper.GetDataTableSP("sp_Product_GetAllProduct");
            dtgProduct.DataSource = table;
            dtgProduct.DataBind();
            dtgProduct.FooterStyle.CssClass = "footer-grd-stdtable";
            dtgProduct.HeaderStyle.CssClass = "head-grd-stdtable";
            dtgProduct.CssClass = "grd-stdtable";
        }

        protected void dtgProduct_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var id = (e.Item.FindControl("lblId") as Label).Text;
                HyperLink lnk = e.Item.FindControl("lnkEditProduct") as HyperLink;
                lnk.NavigateUrl = "EditProduct.aspx?id="+id;
                lnk.Text = "Sửa thông tin sản phẩm";

                ImageButton imbDelete = e.Item.FindControl("btnDelete") as ImageButton;
                imbDelete.OnClientClick = "javascript : return confirm('Bạn có chắc muốn xóa sản phẩm này?')";

            }
        }

        protected void dtgProduct_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dtgProduct.CurrentPageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void dtgProduct_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "cmdDelete")
            {
                try
                {
                    Response.Redirect("ProductManager.aspx");
                    var id = (e.Item.FindControl("lblId") as Label).Text;
                    List<SqlParameter> pars = new List<SqlParameter>();
                    pars.Add(new SqlParameter("@Id", id));
                    DBHelper.ExecuteNonQuery("sp_Product_Delete", pars);
                    Notify.ShowAdminMessageSuccess("Đã xóa", this.Page);
                    dtgProduct.CurrentPageIndex = 0;
                    LoadGrid();
                }
                catch
                {
                    Response.Redirect("ProductManager.aspx");
                }
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }
    }
}