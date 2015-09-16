using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamViet.Src.Helper;

namespace TamViet.Src.BE.PageNews
{
    public partial class usrNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (String.IsNullOrEmpty(Request["id"]))
                {
                    //pnlUpload.Visible = true;
                    pnlImg.Visible = false;
                    chkActive.Checked = true;
                    chkActive.Enabled = false;
                    litTitle.Text = "Thêm bài viết mới";
                    litText.Text = "Hình ảnh";
                    btnEditNews.Visible = false;
                    btnSubmitNews.Visible = true;
                }
                else
                {
                    btnEditNews.Visible = true;
                    btnSubmitNews.Visible = false;
                    //pnlUpload.Visible = false;
                    pnlImg.Visible = true;
                    litText.Text = "Cập nhật hình ảnh";
                    litTitle.Text = "Cập nhật bài viết";
                    var listPar = new List<SqlParameter>();
                    listPar.Add(new SqlParameter("@Id", Request["id"]));
                    var table = DBHelper.GetDataTableSP("sp_News_GetNewsById", listPar);
                    if (table != null && table.Rows.Count > 0)
                    {
                        var row = table.Rows[0];
                        txtTitle.Text = row["Title"] == DBNull.Value ? "" : row["Title"].ToString();
                        ddlType.SelectedValue = row["Type"].ToString();
                        imgNews.ImageUrl = row["Images"].ToString();
                        chkActive.Checked = Convert.ToBoolean(row["Active"]);
                        txtContent.Text = row["NewsContent"] == DBNull.Value ? "" : row["NewsContent"].ToString();
                    }
                }
            }
        }

        protected void btnSubmitNews_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                Notify.ShowAdminMessageError("Tiêu đề không được để trống", this.Page);
                return;
            }
            string img = string.Empty;
            if (String.IsNullOrEmpty(txtImg.Text) && !fileUpload.HasFile)
            {
                Notify.ShowAdminMessageError("Chưa chọn hình ảnh ", this.Page);
                return;
            }
            if (!String.IsNullOrEmpty(txtImg.Text))
            {
                img = txtImg.Text;
            }
            else
            {
                string filename = Path.GetFileName(fileUpload.PostedFile.FileName);
                fileUpload.PostedFile.SaveAs(Server.MapPath("/Images/news/") + filename);
                img = "/Images/news/" + filename;
            }
            try
            {
                string title = txtTitle.Text;
                string content = txtContent.Text;
                string type = ddlType.SelectedValue;
                bool active = chkActive.Checked;

                List<SqlParameter> listPar = new List<SqlParameter>();
                listPar.Add(new SqlParameter("@Title", title));
                listPar.Add(new SqlParameter("@Type", type));
                listPar.Add(new SqlParameter("@NewsContent", content));
                listPar.Add(new SqlParameter("@Images", img));
                DBHelper.ExecuteNonQuery("sp_News_InsertNew", listPar);
                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi !!!", this.Page);
            }
            
            
        }

        protected void btnEditNews_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                Notify.ShowAdminMessageError("Tiêu đề không được để trống", this.Page);
                return;
            }
            string img = string.Empty;
            if (!String.IsNullOrEmpty(txtImg.Text))
            {
                img = txtImg.Text;
            }
            else
            {
                string filename = Path.GetFileName(fileUpload.PostedFile.FileName);
                fileUpload.PostedFile.SaveAs(Server.MapPath("/Images/news/") + filename);
                img = "/Images/news/" + filename;
                var former_image = Server.MapPath(imgNews.ImageUrl);
                if (System.IO.File.Exists(former_image)) { System.IO.File.Delete(former_image); }
            }
            try
            {
                string title = txtTitle.Text;
                string content = txtContent.Text;
                string type = ddlType.SelectedValue;
                bool active = chkActive.Checked;

                List<SqlParameter> listPar = new List<SqlParameter>();
                listPar.Add(new SqlParameter("@Title", title));
                listPar.Add(new SqlParameter("@Type", type));
                listPar.Add(new SqlParameter("@NewsContent", content));
                listPar.Add(new SqlParameter("@Images", img));
                listPar.Add(new SqlParameter("@Active", active));
                listPar.Add(new SqlParameter("@Id", Request["id"]));
                DBHelper.ExecuteNonQuery("sp_News_UpdateNews", listPar);
                Notify.ShowAdminMessageSuccess("Cập nhật thành công", this.Page);
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi !!!", this.Page);
            }

            
        }
    }
}