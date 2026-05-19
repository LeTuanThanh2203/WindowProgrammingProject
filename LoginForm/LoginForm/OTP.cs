using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace ProjectMonHoc
{
    internal class OTP
    {
        // Gmail gửi OTP
        private readonly MailAddress fromAddress =
            new MailAddress(
                "cutcho384@gmail.com"
            );

        // Gmail App Password
        private const string fromPass =
    "ysgrsafyyodnceqo";

        // OTP hiện tại
        private string generatedOTP;

        // Hết hạn OTP
        private DateTime expireTime;

        Random random = new Random();

        // =========================
        // Sinh OTP
        // =========================
        private string GenerateOTP()
        {
            generatedOTP =
                random.Next(
                    100000,
                    1000000
                ).ToString();

            expireTime =
                DateTime.Now.AddSeconds(60);

            return generatedOTP;
        }

        // =========================
        // Lấy Email từ UserName
        // =========================
        public string GetEmailByUsername(
    string username)
        {
            using (My_DB db = new My_DB())
            {
                SqlCommand command =
                    new SqlCommand(
                    @"SELECT Email
              FROM DataLoginForm
              WHERE UserName=@user",
                    db.getConnection
                );

                command.Parameters.Add(
                    "@user",
                    SqlDbType.VarChar
                ).Value = username;

                db.openConnection();

                object result =
                    command.ExecuteScalar();

                db.closeConnection();

                if (result != null)
                {
                    return result.ToString().Trim();
                }

                return null;
            }
        }
        public string MaskEmail(
    string email)
        {
            int atIndex = email.IndexOf('@');

            if (atIndex <= 3)
            {
                return email;
            }

            string firstPart =
                email.Substring(0, 3);

            string lastPart =
                email.Substring(atIndex - 3, 3);

            string domain =
                email.Substring(atIndex);

            return firstPart
                   + "*****"
                   + lastPart
                   + domain;
        }

        // =========================
        // Gửi OTP bằng UserName
        // =========================
        public bool SendOTP(
            string username)
        {
            try
            {
                // Tìm email
                string email =
                    GetEmailByUsername(
                        username);
                MessageBox.Show(email);

                // Không tìm thấy username
                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                string otp =
                    GenerateOTP();

                MailAddress toAddress =
                    new MailAddress(email);

                var smtp =
                    new SmtpClient
                    {
                        Host = "smtp.gmail.com",

                        Port = 587,

                        EnableSsl = true,

                        DeliveryMethod =
                            SmtpDeliveryMethod.Network,

                        UseDefaultCredentials = false,

                        Credentials =
                            new NetworkCredential(
                                fromAddress.Address,
                                fromPass
                            ),

                        Timeout = 10000
                    };

                using (
                    var message =
                    new MailMessage(
                        fromAddress,
                        toAddress
                    )
                    {
                        Subject = "OTP Code",

                        Body =
                            "Your OTP is: "
                            + otp
                            + "\nOTP expires in 60 seconds."
                    }
                )
                {
                    smtp.Send(message);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        // =========================
        // Verify OTP
        // =========================
        public bool VerifyOTP(
            string inputOTP)
        {
            // Hết hạn
            if (DateTime.Now > expireTime)
            {
                return false;
            }

            // OTP đúng
            return generatedOTP ==
                   inputOTP;
        }

        // =========================
        // Time còn lại
        // =========================
        public int GetRemainingSeconds()
        {
            int remain =
                (int)(
                    expireTime
                    - DateTime.Now
                ).TotalSeconds;

            return remain > 0
                ? remain
                : 0;
        }
    }
}