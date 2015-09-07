using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamViet.Src.Helper;

namespace TamViet.Src.BE
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var tableCategory = DBHelper.GetDataTableSP("GetAllCategory");
                ddlCategory.DataSource = tableCategory;
                ddlCategory.DataTextField = "Name";
                ddlCategory.DataValueField = "Id";
                ddlCategory.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string categoryid = ddlCategory.SelectedValue;
                string manufacturer = txtManufacturer.Text;
                string year = txtYear.Text;
                string country = txtCountry.Text;
                string criterion = txtCriterion.Text;
                string power = txtPower.Text;
                string temperature = txtTemperature.Text;
                string humidity = txtHumidity.Text;
                string price = txtPrice.Text;
                bool active = chkActive.Checked;
                string content = txtContent.Text;
                string image = "";
                if (fileUpload.HasFile)
                {
                    string filename = Path.GetFileName(fileUpload.PostedFile.FileName);
                    fileUpload.PostedFile.SaveAs(Server.MapPath("~/Images/product/") + filename);
                    image = "~/images/product/" + filename;
                }
                List<SqlParameter> listPar = new List<SqlParameter>();
                listPar.Add(new SqlParameter("@Name", name));
                listPar.Add(new SqlParameter("@CategoryId", categoryid));
                listPar.Add(new SqlParameter("@Manufacturer", manufacturer));
                listPar.Add(new SqlParameter("@Year", year));
                listPar.Add(new SqlParameter("@Country", country));
                listPar.Add(new SqlParameter("@Criterion", criterion));
                listPar.Add(new SqlParameter("@Power", power));
                listPar.Add(new SqlParameter("@Temperature", temperature));
                listPar.Add(new SqlParameter("@Humidity", humidity));
                listPar.Add(new SqlParameter("@Price", price));
                listPar.Add(new SqlParameter("@Active", active));
                listPar.Add(new SqlParameter("@Id", Request["id"]));
                listPar.Add(new SqlParameter("@SpecificDetail", content));
                if (!String.IsNullOrEmpty(image))
                    listPar.Add(new SqlParameter("@Images", image));

                DBHelper.ExecuteNonQuery("sp_Product_AddNew", listPar);
                Notify.ShowAdminMessageSuccess("Thêm mới thành công", this.Page);
                System.Threading.Thread.Sleep(3000);
                Response.Redirect("/Src/ProductManager.aspx");
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi!!!", this.Page);
            }
        }
    }
}