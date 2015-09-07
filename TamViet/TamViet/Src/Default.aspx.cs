using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TamViet.Src
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string aboutUs = "Công ty Cổ phần Y tế Quang Minh được thành lập vào ngày 29/05/2007, trải qua gần 10 năm hoạt động Quang Minh tự hào là nhà cung cấp sản phẩm và dịch vụ Chăm sóc sức khỏe con người hàng đầu tại Việt Nam.Với hệ thống phân phối trải dài từ Bắc vào Nam, Quang Minh đã đánh dấu sự có mặt của mình khắp các tỉnh thành trên cả nước, mang đến cho khách hàng sự hài lòng về các sản phẩm, dịch vụ mà Quang Minh cung cấp với phương châm “ Phát triển vì sức khỏe cộng đồng”  tạo nên giá trị cốt lõi Doanh Nghiệp.";
                int iNextSpace = aboutUs.LastIndexOf(" ", 250);
                var temp = string.Format("{0}...", aboutUs.Substring(0, (iNextSpace > 0) ? iNextSpace : 250).Trim());
                litAboutUs.Text = temp;
            }
        }
    }
}