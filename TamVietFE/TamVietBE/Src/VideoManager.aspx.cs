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
    public partial class VideoManager : System.Web.UI.Page
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
            var table = DBHelper.GetDataTableSP("sp_Video_GetAll");
            dtgVideo.DataSource = table;
            dtgVideo.DataBind();
            dtgVideo.FooterStyle.CssClass = "footer-grd-stdtable";
            dtgVideo.HeaderStyle.CssClass = "head-grd-stdtable";
            dtgVideo.CssClass = "grd-stdtable";
        }

        protected void dtgVideo_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "cmdUpdate": Update(e.Item); break;
                case "cmdDelete": Delete(e.Item); break;
                case "cmdAdd": Insert(e.Item); break;
            }
        }

        protected void dtgVideo_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dtgVideo.CurrentPageIndex = e.NewPageIndex;
            LoadGrid();
        }

        private void Update(DataGridItem e)
        {
            try
            {
                string id = (e.FindControl("lblId") as Label).Text;
                string url = (e.FindControl("txtUrl") as TextBox).Text;
                string detail = (e.FindControl("txtDetail") as TextBox).Text;

                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Id", id));
                pars.Add(new SqlParameter("@Url", url));
                pars.Add(new SqlParameter("@Detail", detail));
                DBHelper.ExecuteNonQuery("sp_Video_Update", pars);

                Notify.ShowAdminMessageSuccess("Update thành công", this.Page);
                dtgVideo.CurrentPageIndex = 0;
                LoadGrid();
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi !!!", this.Page);
                LoadGrid();
                return;
            }
        }

        private void Insert(DataGridItem e)
        {
            try
            {
                string url = (e.FindControl("txtUrl") as TextBox).Text;
                string detail = (e.FindControl("txtDetail") as TextBox).Text;
                
                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Url", url));
                pars.Add(new SqlParameter("@Detail", detail));
                DBHelper.ExecuteNonQuery("sp_Video_AddNew", pars);

                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
                dtgVideo.CurrentPageIndex = 0;
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
                string id = (e.FindControl("lblId") as Label).Text;
                List<SqlParameter> pars = new List<SqlParameter>();
                pars.Add(new SqlParameter("@Id", id));
                DBHelper.ExecuteNonQuery("sp_Video_Delete", pars);
                Notify.ShowAdminMessageSuccess("Đã xóa", this.Page);
                dtgVideo.CurrentPageIndex = 0;
                LoadGrid();
                Response.Redirect("VideoManager.aspx");
            }
            catch
            {
                Response.Redirect("VideoManager.aspx");
            }
             
            
        }
    }
}