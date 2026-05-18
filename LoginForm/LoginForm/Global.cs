using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Group6
{
    internal class Globals
    {
        // ID người dùng đăng nhập
        public static int GlobalUserId { get; private set; }

        // Tên người dùng
        public static string Username { get; private set; }

        // Chức vụ / quyền
        public static string Role { get; private set; }

        // Email


        // Thời gian hoạt động cuối cùng
        public static DateTime LastActivityTime { get; private set; }

        // Thời gian timeout (30 phút)
        private static readonly TimeSpan SessionTimeout =
            TimeSpan.FromMinutes(30);

        // Gán thông tin session sau khi login
        public static void SetSession(
            int userId,
            string username,
            string role)
        {
            GlobalUserId = userId;
            Username = username;
            Role = role;

            UpdateActivity();
        }

        // Cập nhật thời gian hoạt động
        public static void UpdateActivity()
        {
            LastActivityTime = DateTime.Now;
        }

        // Kiểm tra session còn hạn hay không
        public static bool IsSessionExpired()
        {
            return DateTime.Now - LastActivityTime
                   > SessionTimeout;
        }

        // Xóa session khi logout
        public static void ClearSession()
        {
            GlobalUserId = 0;
            Username = string.Empty;
            Role = string.Empty;

            LastActivityTime = DateTime.MinValue;
        }
    }
}
