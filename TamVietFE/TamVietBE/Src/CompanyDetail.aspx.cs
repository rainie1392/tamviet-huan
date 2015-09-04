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
    public partial class CompanyDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var table = DBHelper.GetDataTableSP("GetCompanyDetail");
                if (table != null && table.Rows.Count > 0)
                {
                    var row = table.Rows[0];
                    txtAddress.Text = row["Address"] == DBNull.Value ? "" : row["Address"].ToString();
                    txtPhone.Text = row["Telephone"] == DBNull.Value ? "" : row["Telephone"].ToString();
                    txtHotline.Text = row["Hotline"] == DBNull.Value ? "" : row["Hotline"].ToString();
                    txtEmail.Text = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                    txtWebsite.Text = row["Website"] == DBNull.Value ? "" : row["Website"].ToString();
                    txtCompanyName.Text = row["CompanyName"] == DBNull.Value ? "" : row["CompanyName"].ToString();
                    txtTaxCode.Text = row["TaxCode"] == DBNull.Value ? "" : row["TaxCode"].ToString();
                    hidVal.Value = row["Id"] == DBNull.Value ? "" : row["Id"].ToString();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = hidVal.Value;
                if (String.IsNullOrEmpty(id))
                {
                    List<SqlParameter> listPar = new List<SqlParameter>();
                    listPar.Add(new SqlParameter("@Address", txtAddress.Text));
                    listPar.Add(new SqlParameter("@Telephone", txtPhone.Text));
                    listPar.Add(new SqlParameter("@Hotline", txtHotline.Text));
                    listPar.Add(new SqlParameter("@Email", txtEmail.Text));
                    listPar.Add(new SqlParameter("@Website", txtWebsite.Text));
                    listPar.Add(new SqlParameter("@CompanyName", txtCompanyName.Text));
                    listPar.Add(new SqlParameter("@TaxCode", txtTaxCode.Text));
                    DBHelper.ExecuteNonQuery("InsertCompanyDetail", listPar);
                    Notify.ShowAdminMessageSuccess("Cập nhật thành công", this.Page);
                }
                else
                {
                    List<SqlParameter> listPar = new List<SqlParameter>();
                    listPar.Add(new SqlParameter("@Address", txtAddress.Text));
                    listPar.Add(new SqlParameter("@Telephone", txtPhone.Text));
                    listPar.Add(new SqlParameter("@Hotline", txtHotline.Text));
                    listPar.Add(new SqlParameter("@Email", txtEmail.Text));
                    listPar.Add(new SqlParameter("@Website", txtWebsite.Text));
                    listPar.Add(new SqlParameter("@CompanyName", txtCompanyName.Text));
                    listPar.Add(new SqlParameter("@TaxCode", txtTaxCode.Text));
                    listPar.Add(new SqlParameter("@Id", id));
                    DBHelper.ExecuteNonQuery("UpdateCompanyDetail", listPar);
                    Notify.ShowAdminMessageSuccess("Cập nhật thành công", this.Page);
                }
                
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi", this.Page);
                return;
            }
            
        }
    }
}