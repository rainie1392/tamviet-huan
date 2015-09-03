using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TamVietBE.Src.Helper
{
    public class Method
    {
        public static string GetContentFileByVirtulFilePath(string virtualFilePath)
        {
            if (!string.IsNullOrEmpty(virtualFilePath))
            {
                virtualFilePath = virtualFilePath.Replace("\\", "/").Trim();
                if (virtualFilePath.Substring(0, 1) != "/" && virtualFilePath.Substring(0, 1) != "~")
                {
                    virtualFilePath = "/" + virtualFilePath;
                }
                string physicalFilePath = HttpContext.Current.Server.MapPath(virtualFilePath);
                string content = GetContentFileByPhysicalFilePath(physicalFilePath);
                return content;
            }
            else
                return string.Empty;
        }

        public static string GetContentFileByPhysicalFilePath(string physicalFilePath)
        {
            string content = string.Empty;
            if (File.Exists(physicalFilePath))
                content = File.ReadAllText(physicalFilePath);
            return content;
        }
        /// <summary>
        /// đóng cửa sổ hiện tại và load lại cửa sổ chính
        /// </summary>
        /// <param name="httpResponse"></param>
        public static void RefreshParentWindow(HttpResponse httpResponse)
        {
            #region close and back to parent page
            string strScript = String.Empty;
            strScript = "<script languages=\"javascript\">";
            strScript += "window.opener.location.href = window.opener.location.href;";
            strScript += "if (window.opener.progressWindow)";
            strScript += "{";
            strScript += "window.opener.progressWindow.close()";
            strScript += "}";
            strScript += "window.close(); ";
            strScript += "</script>";
            httpResponse.Write(strScript);
            #endregion
        }
    }
}