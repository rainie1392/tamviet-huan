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
    public partial class CategoryManager : System.Web.UI.Page
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
            var table = DBHelper.GetDataTableSP("GetAllCategory");
            dtgCategory.DataSource = table;
            dtgCategory.DataBind();
            dtgCategory.FooterStyle.CssClass = "footer-grd-stdtable";
            dtgCategory.HeaderStyle.CssClass = "head-grd-stdtable";
            dtgCategory.CssClass = "grd-stdtable";
        }

        protected void dtgCategory_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "cmdAdd": Insert(e.Item); break;
                case "cmdUpdate": Update(e.Item); break;
                case "cmdDelete": Delete(e.Item); break;
            }
        }

        protected void dtgCategory_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                
                DropDownList ddl = e.Item.FindControl("ddlCat") as DropDownList;
                LoadDdl(ddl);
                int parentid = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "ParentId"));
                if (parentid != 0)
                    ddl.SelectedValue = parentid.ToString();
                CheckBox c = e.Item.FindControl("chkSubCat") as CheckBox;
                bool isSub = (bool)DataBinder.Eval(e.Item.DataItem, "IsSubCat");
                c.Checked = isSub;
                if (isSub)
                    ddl.Visible = true;
                else
                    ddl.Visible = false;

                ImageButton imbDelete = e.Item.FindControl("btnDelete") as ImageButton;
                imbDelete.OnClientClick = "javascript : return confirm('Bạn có chắc muốn xóa không?')";
            }
            else if (e.Item.ItemType == ListItemType.Footer)
            {
                DropDownList ddl = e.Item.FindControl("ddlCat") as DropDownList;
                LoadDdl(ddl);
                ddl.Visible = false;
            }
        }

        protected void dtgCategory_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dtgCategory.CurrentPageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void chkSubCat_CheckedChanged(object sender, EventArgs e)
        {
            DropDownList ddl = ((CheckBox)sender).Parent.FindControl("ddlCat") as DropDownList;
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
                ddl.Visible = true;
            else
                ddl.Visible = false;
        }

        private void LoadDdl(DropDownList ddl)
        {
            var table = DBHelper.GetDataTableSP("GetAllCategory");
            ddl.DataSource = table;
            ddl.DataTextField = "Name";
            ddl.DataValueField = "Id";
            ddl.DataBind();
            
        }

        private void Insert(DataGridItem e)
        {
            try
            {
                string name = (e.FindControl("txtCatName") as TextBox).Text;
                bool isSub = (e.FindControl("chkSubCat") as CheckBox).Checked;
                int parentId = 0;
                if (isSub)
                    parentId = Convert.ToInt32((e.FindControl("ddlCat") as DropDownList).SelectedValue);

                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Name", name));
                pars.Add(new SqlParameter("@IsSubCat", isSub));
                pars.Add(new SqlParameter("@ParentId", parentId));
                DBHelper.ExecuteNonQuery("sp_Category_InsertNew", pars);

                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
                dtgCategory.CurrentPageIndex = 0;
                LoadGrid();
            }
            catch
            {
                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
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
                string name = (e.FindControl("txtCatName") as TextBox).Text;
                bool isSub = (e.FindControl("chkSubCat") as CheckBox).Checked;
                bool active = (e.FindControl("chkActive") as CheckBox).Checked;
                int parentId = 0;
                if (isSub)
                    parentId = Convert.ToInt32((e.FindControl("ddlCat") as DropDownList).SelectedValue);

                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Id", id));
                pars.Add(new SqlParameter("@Name", name));
                pars.Add(new SqlParameter("@IsSubCat", isSub));
                pars.Add(new SqlParameter("@Active", active));
                pars.Add(new SqlParameter("@ParentId", parentId));
                DBHelper.ExecuteNonQuery("sp_Category_Update", pars);

                Notify.ShowAdminMessageSuccess("Update thành công", this.Page);
                dtgCategory.CurrentPageIndex = 0;
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
                DBHelper.ExecuteNonQuery("sp_Category_Delete", pars);
                Notify.ShowAdminMessageSuccess("Đã xóa", this.Page);
                dtgCategory.CurrentPageIndex = 0;
                LoadGrid();
                Response.Redirect("CategoryManager.aspx");
            }
            catch
            {
                Response.Redirect("CategoryManager.aspx");
            }
           
        }
    }
}