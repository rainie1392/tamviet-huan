using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

namespace TamVietFE.Src.Helper
{
    public class FormatHelper
    {
        public static string ConvertStringToUnsign(string content)
        {
            string stFromD = content.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            for (int i = 0; i < stFromD.Length; i++)
            {
                var uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFromD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(stFromD[i]);
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        public static string FormatLink(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            s = s.Replace('&', ' ');
            s = s.Replace('–', ' ');
            s = s.Replace('-', ' ');
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s{2,}", " ");
            s = s.Replace(' ', '-');
            s = s.Replace('á', 'a');
            s = s.Replace('à', 'a');
            s = s.Replace('ả', 'a');
            s = s.Replace('ạ', 'a');
            s = s.Replace('ã', 'a');
            s = s.Replace('â', 'a');
            s = s.Replace('ấ', 'a');
            s = s.Replace('ầ', 'a');
            s = s.Replace('ẩ', 'a');
            s = s.Replace('ẫ', 'a');
            s = s.Replace('ậ', 'a');
            s = s.Replace('ă', 'a');
            s = s.Replace('ắ', 'a');
            s = s.Replace('ằ', 'a');
            s = s.Replace('ẳ', 'a');
            s = s.Replace('ẵ', 'a');
            s = s.Replace('ặ', 'a');
            s = s.Replace('é', 'e');
            s = s.Replace('è', 'e');
            s = s.Replace('ẻ', 'e');
            s = s.Replace('ẽ', 'e');
            s = s.Replace('ẹ', 'e');
            s = s.Replace('ê', 'e');
            s = s.Replace('ế', 'e');
            s = s.Replace('ề', 'e');
            s = s.Replace('ể', 'e');
            s = s.Replace('ễ', 'e');
            s = s.Replace('ệ', 'e');
            s = s.Replace('í', 'i');
            s = s.Replace('ì', 'i');
            s = s.Replace('ỉ', 'i');
            s = s.Replace('ĩ', 'i');
            s = s.Replace('ị', 'i');
            s = s.Replace('ó', 'o');
            s = s.Replace('ò', 'o');
            s = s.Replace('ỏ', 'o');
            s = s.Replace('õ', 'o');
            s = s.Replace('ọ', 'o');
            s = s.Replace('ô', 'o');
            s = s.Replace('ố', 'o');
            s = s.Replace('ồ', 'o');
            s = s.Replace('ổ', 'o');
            s = s.Replace('ỗ', 'o');
            s = s.Replace('ộ', 'o');
            s = s.Replace('ơ', 'o');
            s = s.Replace('ớ', 'o');
            s = s.Replace('ờ', 'o');
            s = s.Replace('ở', 'o');
            s = s.Replace('ỡ', 'o');
            s = s.Replace('ợ', 'o');
            s = s.Replace('ú', 'u');
            s = s.Replace('ù', 'u');
            s = s.Replace('ủ', 'u');
            s = s.Replace('ũ', 'u');
            s = s.Replace('ụ', 'u');
            s = s.Replace('ư', 'u');
            s = s.Replace('ứ', 'u');
            s = s.Replace('ừ', 'u');
            s = s.Replace('ử', 'u');
            s = s.Replace('ữ', 'u');
            s = s.Replace('ự', 'u');
            s = s.Replace('ý', 'y');
            s = s.Replace('ỳ', 'y');
            s = s.Replace('ỷ', 'y');
            s = s.Replace('ỹ', 'y');
            s = s.Replace('ỵ', 'y');
            s = s.Replace('đ', 'd');
            return s;
        }

        public static string FormatTextToUnsign(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s{2,}", " ");
            s = s.Replace('á', 'a');
            s = s.Replace('à', 'a');
            s = s.Replace('ả', 'a');
            s = s.Replace('ạ', 'a');
            s = s.Replace('ã', 'a');
            s = s.Replace('â', 'a');
            s = s.Replace('ấ', 'a');
            s = s.Replace('ầ', 'a');
            s = s.Replace('ẩ', 'a');
            s = s.Replace('ẫ', 'a');
            s = s.Replace('ậ', 'a');
            s = s.Replace('ă', 'a');
            s = s.Replace('ắ', 'a');
            s = s.Replace('ằ', 'a');
            s = s.Replace('ẳ', 'a');
            s = s.Replace('ẵ', 'a');
            s = s.Replace('ặ', 'a');
            s = s.Replace('é', 'e');
            s = s.Replace('è', 'e');
            s = s.Replace('ẻ', 'e');
            s = s.Replace('ẽ', 'e');
            s = s.Replace('ẹ', 'e');
            s = s.Replace('ê', 'e');
            s = s.Replace('ế', 'e');
            s = s.Replace('ề', 'e');
            s = s.Replace('ể', 'e');
            s = s.Replace('ễ', 'e');
            s = s.Replace('ệ', 'e');
            s = s.Replace('í', 'i');
            s = s.Replace('ì', 'i');
            s = s.Replace('ỉ', 'i');
            s = s.Replace('ĩ', 'i');
            s = s.Replace('ị', 'i');
            s = s.Replace('ó', 'o');
            s = s.Replace('ò', 'o');
            s = s.Replace('ỏ', 'o');
            s = s.Replace('õ', 'o');
            s = s.Replace('ọ', 'o');
            s = s.Replace('ô', 'o');
            s = s.Replace('ố', 'o');
            s = s.Replace('ồ', 'o');
            s = s.Replace('ổ', 'o');
            s = s.Replace('ỗ', 'o');
            s = s.Replace('ộ', 'o');
            s = s.Replace('ơ', 'o');
            s = s.Replace('ớ', 'o');
            s = s.Replace('ờ', 'o');
            s = s.Replace('ở', 'o');
            s = s.Replace('ỡ', 'o');
            s = s.Replace('ợ', 'o');
            s = s.Replace('ú', 'u');
            s = s.Replace('ù', 'u');
            s = s.Replace('ủ', 'u');
            s = s.Replace('ũ', 'u');
            s = s.Replace('ụ', 'u');
            s = s.Replace('ư', 'u');
            s = s.Replace('ứ', 'u');
            s = s.Replace('ừ', 'u');
            s = s.Replace('ử', 'u');
            s = s.Replace('ữ', 'u');
            s = s.Replace('ự', 'u');
            s = s.Replace('ý', 'y');
            s = s.Replace('ỳ', 'y');
            s = s.Replace('ỷ', 'y');
            s = s.Replace('ỹ', 'y');
            s = s.Replace('ỵ', 'y');
            s = s.Replace('đ', 'd');
            return s;
        }
        /// <summary>
        /// trả về xâu định dạng dd/MM/yyyy
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string FormatDate(DateTime date, string format = "dd/MM/yyyy")
        {
            if (date == null)
            {
                return "";
            }
            return date.ToString(format, CultureInfo.GetCultureInfo("vi"));
        }
        public static string FormatDate(string date, string formart = "dddd dd/MM/yyyy")
        {
            DateTime d;
            if (DateTime.TryParse(date, out d))
            {
                return d.ToString(formart, CultureInfo.GetCultureInfo("vi"));
            }
            else
            {
                return "";
            }
        }
        public static string FormatTime(DateTime dateTime)
        {
            if (dateTime == null)
            {
                return "";
            }
            return dateTime.ToString("HH:mm");
        }
        public static string FormatMoney(string monney)
        {
            if (monney == null)
            {
                return "0";
            }
            try
            {
                if (Convert.ToDecimal(monney) == 0) return "0";
                return String.Format(new CultureInfo("vi-VN"), "{0:0,##}", Convert.ToDecimal(monney));
                //return String.Format("{0:0,0}", monney);
            }
            catch
            {
                return "0";
            }
        }

        public static string FormatPrice(string money)
        {
            if (money == null)
            {
                return "0";
            }
            try
            {
                if (Convert.ToDecimal(money) == 0) return "0";
                return String.Format(new CultureInfo("vi-VN"), "{0:#,###.##}", Convert.ToDecimal(money));
                //return String.Format("{0:0,0}", monney);
            }
            catch
            {
                return "0";
            }
        }

        public static string FormatMoney(object p)
        {
            if (p == null)
            {
                return "0";
            }
            return FormatMoney(p.ToString());
        }


        //Dùng cho format input translate, lưu ý khi sửa :3
        public static string FormatNvarchar(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            s = System.Text.RegularExpressions.Regex.Replace(s, @"\s{2,}", " ");
            s = s.Replace('á', 'a');
            s = s.Replace('à', 'a');
            s = s.Replace('ả', 'a');
            s = s.Replace('ạ', 'a');
            s = s.Replace('ã', 'a');
            s = s.Replace('â', 'a');
            s = s.Replace('ấ', 'a');
            s = s.Replace('ầ', 'a');
            s = s.Replace('ẩ', 'a');
            s = s.Replace('ẫ', 'a');
            s = s.Replace('ậ', 'a');
            s = s.Replace('ă', 'a');
            s = s.Replace('ắ', 'a');
            s = s.Replace('ằ', 'a');
            s = s.Replace('ẳ', 'a');
            s = s.Replace('ẵ', 'a');
            s = s.Replace('ặ', 'a');
            s = s.Replace('é', 'e');
            s = s.Replace('è', 'e');
            s = s.Replace('ẻ', 'e');
            s = s.Replace('ẽ', 'e');
            s = s.Replace('ẹ', 'e');
            s = s.Replace('ê', 'e');
            s = s.Replace('ế', 'e');
            s = s.Replace('ề', 'e');
            s = s.Replace('ể', 'e');
            s = s.Replace('ễ', 'e');
            s = s.Replace('ệ', 'e');
            s = s.Replace('í', 'i');
            s = s.Replace('ì', 'i');
            s = s.Replace('ỉ', 'i');
            s = s.Replace('ĩ', 'i');
            s = s.Replace('ị', 'i');
            s = s.Replace('ó', 'o');
            s = s.Replace('ò', 'o');
            s = s.Replace('ỏ', 'o');
            s = s.Replace('õ', 'o');
            s = s.Replace('ọ', 'o');
            s = s.Replace('ô', 'o');
            s = s.Replace('ố', 'o');
            s = s.Replace('ồ', 'o');
            s = s.Replace('ổ', 'o');
            s = s.Replace('ỗ', 'o');
            s = s.Replace('ộ', 'o');
            s = s.Replace('ơ', 'o');
            s = s.Replace('ớ', 'o');
            s = s.Replace('ờ', 'o');
            s = s.Replace('ở', 'o');
            s = s.Replace('ỡ', 'o');
            s = s.Replace('ợ', 'o');
            s = s.Replace('ú', 'u');
            s = s.Replace('ù', 'u');
            s = s.Replace('ủ', 'u');
            s = s.Replace('ũ', 'u');
            s = s.Replace('ụ', 'u');
            s = s.Replace('ư', 'u');
            s = s.Replace('ứ', 'u');
            s = s.Replace('ừ', 'u');
            s = s.Replace('ử', 'u');
            s = s.Replace('ữ', 'u');
            s = s.Replace('ự', 'u');
            s = s.Replace('ý', 'y');
            s = s.Replace('ỳ', 'y');
            s = s.Replace('ỷ', 'y');
            s = s.Replace('ỹ', 'y');
            s = s.Replace('ỵ', 'y');
            s = s.Replace('đ', 'd');
            return s;
        }
    }
}