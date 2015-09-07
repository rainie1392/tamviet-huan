using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using TamViet.Src.BE;

namespace TamViet.Src.Helper
{
    public class Notify
    {
        public static void ShowAdminMessageError(string errorMessage, Page page)
        {
            var be = (_Admin)page.Controls[0];
            be.ShowMessageError(errorMessage);
        }

        public static void ShowAdminMessageSuccess(string successMessage, Page page)
        {
            var be = (_Admin)page.Controls[0];
            be.ShowMessageSuccess(successMessage);
        }

        public static void ShowAdminMessageAlert(string alertMessage, Page page)
        {
            var be = (_Admin)page.Controls[0];
            be.ShowMessageAlert(alertMessage);
        }
    }
}