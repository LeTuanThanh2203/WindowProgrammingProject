using System;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public class ValidateData
    {
        // MSSV phải là số
        public static bool IsNumber(string text)
        {
            return long.TryParse(text, out _);
        }

        // Email đúng định dạng
        public static bool IsValidEmail(string email)
        {
            string pattern =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(
                email,
                pattern);
        }

        // Ngày sinh không lớn hơn hiện tại
        public static bool IsValidBirthDay(DateTime dob)
        {
            return dob <= DateTime.Now;
        }
        public static bool IsValidMSSV(string mssv)
        {
            return Regex.IsMatch(mssv, @"^[a-zA-Z0-9]+$");
        }

        // Họ tên / Tên: chỉ chứa chữ cái và khoảng trắng (hỗ trợ tiếng Việt)
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\s]+$");
        }

        // Số điện thoại: chỉ chứa số
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]+$");
        }
        public static bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
    }
}