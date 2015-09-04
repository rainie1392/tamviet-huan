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
    public partial class Support : System.Web.UI.Page
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
            var table = DBHelper.GetDataTableSP("sp_Support_GetAll");
            dtgSupport.DataSource = table;
            dtgSupport.DataBind();
            dtgSupport.FooterStyle.CssClass = "footer-grd-stdtable";
            dtgSupport.HeaderStyle.CssClass = "head-grd-stdtable";
            dtgSupport.CssClass = "grd-stdtable";
        }

        protected void dtgSupport_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                var type = DataBinder.Eval(e.Item.DataItem, "Type").ToString();
                DropDownList ddl = e.Item.FindControl("ddlType") as DropDownList;
                ddl.SelectedValue = type;
            }
        }

        protected void dtgSupport_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "cmdAdd": Insert(e.Item); break;
                case "cmdUpdate": Update(e.Item); break;
                case "cmdDelete": Delete(e.Item); break;
            }
        }

        protected void dtgSupport_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dtgSupport.CurrentPageIndex = e.NewPageIndex;
            LoadGrid();
        }

        private void Insert(DataGridItem e)
        {
            try
            {
                TextBox txtName = e.FindControl("txtName") as TextBox;
                TextBox txtAddress = e.FindControl("txtAddress") as TextBox;
                DropDownList ddlType = e.FindControl("ddlType") as DropDownList;

                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Name", txtName.Text));
                pars.Add(new SqlParameter("@Address", txtAddress.Text));
                pars.Add(new SqlParameter("@Type", ddlType.SelectedValue));
                DBHelper.ExecuteNonQuery("sp_Support_AddNew", pars);

                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
                dtgSupport.CurrentPageIndex = 0;
                LoadGrid();
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi", this.Page);
                LoadGrid();
                return;
            }
        }

        private void Update(DataGridItem e)
        {
            try
            {
                Label lblId = e.FindControl("lblId") as Label;
                var id = lblId.Text;
                TextBox txtName = e.FindControl("txtName") as TextBox;
                TextBox txtAddress = e.FindControl("txtAddress") as TextBox;
                DropDownList ddlType = e.FindControl("ddlType") as DropDownList;

                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Name", txtName.Text));
                pars.Add(new SqlParameter("@Address", txtAddress.Text));
                pars.Add(new SqlParameter("@Type", ddlType.SelectedValue));
                pars.Add(new SqlParameter("@Id", id));
                DBHelper.ExecuteNonQuery("sp_Support_Update", pars);

                Notify.ShowAdminMessageSuccess("Cập nhật thành công", this.Page);
                dtgSupport.CurrentPageIndex = 0;
                LoadGrid();
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi", this.Page);
                LoadGrid();
                return;
            }
        }

        private void Delete(DataGridItem e)
        {
            try
            {
                Label lblId = e.FindControl("lblId") as Label;
                var id = lblId.Text;
                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Id", id));
                DBHelper.ExecuteNonQuery("sp_Support_Delete", pars);
                Notify.ShowAdminMessageSuccess("Đã xóa", this.Page);
                dtgSupport.CurrentPageIndex = 0;
                LoadGrid();
                Response.Redirect("Support.aspx");
            }
            catch
            {
                Response.Redirect("Support.aspx");
            }
        }
    }
}