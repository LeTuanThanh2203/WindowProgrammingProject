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
    }
}