using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamViet.Src.Helper;

namespace TamViet.Src
{
    public partial class AllNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            int page = (Request.QueryString["page"] + "" != "") ? int.Parse("0" + Request.QueryString["page"]) : 1;
            int pagerecord = 4;
            int pagesize = 5;
            string news = string.Empty;
            string category = Request["category"];

            string listpage = string.Empty;

            if (category == null)
            {
                if (pagesize > 0)
                {
                    List<SqlParameter> para = new List<SqlParameter>();
                    para.Add(new SqlParameter("@currPage", page));
                    para.Add(new SqlParameter("@recordperpage", pagerecord));
                    para.Add(new SqlParameter("@Pagesize", pagesize));
                    DataTable tbPagingNews = DBHelper.GetDataTableSP("sp_News_PhanTrangNews", para);

                    foreach (DataRow dr in tbPagingNews.DataSet.Tables[0].Rows)
                    {
                        string temp = string.Empty;
                        string m = Regex.Replace(dr["NewsContent"].ToString(), @"(<img\/?[^>]+>)", @"", RegexOptions.IgnoreCase);
                        if (m.Length > 250) temp = m.Substring(0, 250) + "...";
                        else temp = m.ToString();

                        news +="<div class='about-us' style='margin-top:10px;'>" +
                                    "<div style='float: left; width: 40%;'>" + 
                                        "<img src='"+dr["Images"]+"' style='width: 100%; height: 190px;' />" +
                                    "</div>" +
                                    "<div style='float: left; width: 50%;margin-left:15px;'>"+
                                        "<p style='font-size:14px;color:black;'><a style='color:black;' href='/Src/NewsDetail.aspx?id=" + dr["Id"] + "'><b>" + dr["Title"] + "</b></a></p>" +
                                        "<div>"+
                                            temp +
                                        "</div>" +
                                        "<p><a href='/Src/NewsDetail.aspx?id=" + dr["Id"] + "'><span class='hyperlink' style='float: right; margin-right: 10px; margin-left: 20px;'>Xem chi tiết</span></a></p>" +
                                    "</div>"+
                                "</div>";
                    }

                    listpage = tbPagingNews.DataSet.Tables[1].Rows[0][0].ToString();
                }

            }
            else
            {
                List<SqlParameter> para = new List<SqlParameter>();

                if (pagesize > 0)
                {
                    para.Clear();
                    para.Add(new SqlParameter("@currPage", page));
                    para.Add(new SqlParameter("@recordperpage", pagerecord));
                    para.Add(new SqlParameter("@Pagesize", pagesize));
                    para.Add(new SqlParameter("@category", category));
                    DataTable tbPagingNews = DBHelper.GetDataTableSP("sp_News_PhanTrangNews", para);

                    foreach (DataRow dr in tbPagingNews.DataSet.Tables[0].Rows)
                    {
                        string temp = string.Empty;
                        string m = Regex.Replace(dr["NewsContent"].ToString(), @"(<img\/?[^>]+>)", @"", RegexOptions.IgnoreCase);

                        if (m.Length > 250) temp = m.Substring(0, 250) + "...";
                        else temp = m.ToString();
                        news += "<div class='about-us' style='margin-top:10px;'>" +
                                    "<div style='float: left; width: 40%;'>" +
                                        "<img src='" + dr["Images"] + "' style='width: 100%; height: 190px;' />" +
                                    "</div>" +
                                    "<div style='float: left; width: 50%;margin-left:15px;'>" +
                                        "<p style='font-size:14px;color:black;'><a style='color:black;' href='/Src/NewsDetail.aspx?id=" + dr["Id"] + "'><b>" + dr["Title"] + "</b></a></p>" +
                                        "<div>" +
                                            temp +
                                        "</div>" +
                                        "<p><a href='/Src/NewsDetail.aspx?id=" + dr["Id"] + "'><span class='hyperlink' style='float: right; margin-right: 10px; margin-left: 20px;'>Xem chi tiết</span></a></p>" +
                                    "</div>" +
                                "</div>";
                    }

                    listpage = tbPagingNews.DataSet.Tables[1].Rows[0][0].ToString();
                }
            }
            ltNews.Text = news;
            ltPagging.Text = listpage;
        }
    }
}