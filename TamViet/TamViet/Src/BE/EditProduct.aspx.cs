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
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    int id = Convert.ToInt32(Request["id"]);
                    List<SqlParameter> pars = new List<SqlParameter>();
                    pars.Add(new SqlParameter("@Id", id));
                    var table = DBHelper.GetDataTableSP("sp_Product_GetProductById", pars);
                    var tableCategory = DBHelper.GetDataTableSP("GetAllCategory");
                    if (table != null && table.Rows.Count > 0)
                    {
                        var row = table.Rows[0];
                        txtName.Text = row["Name"] == DBNull.Value ? "" : row["Name"].ToString();
                        ddlCategory.DataSource = tableCategory;
                        ddlCategory.DataTextField = "Name";
                        ddlCategory.DataValueField = "Id";
                        ddlCategory.DataBind();
                        ddlCategory.SelectedValue = row["CategoryId"].ToString();
                        txtManufacturer.Text = row["Manufacturer"] == DBNull.Value ? "" : row["Manufacturer"].ToString();
                        txtYear.Text = row["Year"] == DBNull.Value ? "" : row["Year"].ToString();
                        txtCountry.Text = row["Country"] == DBNull.Value ? "" : row["Country"].ToString();
                        txtCriterion.Text = row["Criterion"] == DBNull.Value ? "" : row["Criterion"].ToString();
                        txtPower.Text = row["PowerRequirement"] == DBNull.Value ? "" : row["PowerRequirement"].ToString();
                        txtTemperature.Text = row["WorkingTemperature"] == DBNull.Value ? "" : row["WorkingTemperature"].ToString();
                        txtHumidity.Text = row["WorkingHumidity"] == DBNull.Value ? "" : row["WorkingHumidity"].ToString();
                        txtPrice.Text = row["Price"] == DBNull.Value ? "" : row["Price"].ToString();
                        chkActive.Checked = (bool)row["Active"];
                        hidValue.Value = row["Images"] == DBNull.Value ? "" : row["Images"].ToString();
                        txtContent.Text = row["SpecificDetail"] == DBNull.Value ? "" : row["SpecificDetail"].ToString();
                        lnkImages.NavigateUrl = row["Images"] == DBNull.Value ? "" : row["Images"].ToString();
                        lnkImages.Attributes.Add("data-lightbox", "image-" + id);
                        imgProduct.ImageUrl = row["Images"] == DBNull.Value ? "" : row["Images"].ToString();
                    }
                    else
                    {
                        Response.Redirect("/Src/Error.aspx");
                    }
                }
                catch
                {
                    Response.Redirect("/Src/Error.aspx");
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
                    image = "~/Images/product/" + filename;
                    var former_image = Server.MapPath(hidValue.Value);
                    if (System.IO.File.Exists(former_image)) { System.IO.File.Delete(former_image); }
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

                DBHelper.ExecuteNonQuery("sp_Product_Update", listPar);
                Notify.ShowAdminMessageSuccess("Cập nhật thành công", this.Page);
                System.Threading.Thread.Sleep(3000);
                Response.Redirect(Request.Url.ToString());
            }
            catch
            {
                Notify.ShowAdminMessageError("Lỗi!!!", this.Page);
            }
        }
    }
}