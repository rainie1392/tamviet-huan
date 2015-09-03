using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamVietBE.Src.Helper;

namespace TamVietBE.Src
{
    public partial class _Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ShowMessageError(string messageError)
        {
            litNotify.Visible = true;
            string template = Method.GetContentFileByVirtulFilePath("Src/Template/Notify/error.html");
            litNotify.Text = template.Replace("{MessageError}", messageError);
        }

        public void HideMesseage()
        {
            litNotify.Visible = false;
        }

        public void ShowMessageSuccess(string messageSuccess)
        {
            litNotify.Visible = true;
            string template = Method.GetContentFileByVirtulFilePath("Src/Template/Notify/success.html");
            litNotify.Text = template.Replace("{message}", messageSuccess);
        }

        public void ShowMessageAlert(string messageAlert)
        {
            litNotify.Visible = true;
            string template = Method.GetContentFileByVirtulFilePath("Src/Template/Notify/alert.html");
            litNotify.Text = template.Replace("{message}", messageAlert);
        }
    }
}