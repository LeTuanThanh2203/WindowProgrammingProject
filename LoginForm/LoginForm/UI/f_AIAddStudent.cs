using LoginForm;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Project_Group6.UI
{
    public partial class f_AIAddStudent : Form
    {
        public string MSSV = "";
        public string Fname = "";
        public string Lname = "";
        public string Dob = "";
        public string Gender = "";
        public string Phone = "";
        public string Address = "";
        public string Hometown = "";
        public string Email = "";

        byte[] aiScanImage;
        private FilterInfoCollection cameras;
        private VideoCaptureDevice camera;


        public f_AIAddStudent()
        {
            InitializeComponent();
        }

        private void f_AIScan_Load(
object sender,
EventArgs e)
        {
            picCard.Visible = false;

            cameras =
                new FilterInfoCollection(
                FilterCategory.VideoInputDevice);

            foreach (FilterInfo cam
                in cameras)
            {
                cboCamera.Items
                .Add(cam.Name);
            }

            if (cboCamera.Items.Count > 0)
                cboCamera.SelectedIndex = 0;
        }


      
       
   

        private void btnStartCamera_Click(
object sender,
EventArgs e)
        {
            camera =
                new VideoCaptureDevice(
                    cameras[
                    cboCamera.SelectedIndex]
                    .MonikerString);

            camera.NewFrame +=
                Camera_NewFrame;

            camera.Start();
        }

        private void Camera_NewFrame(
object sender,
NewFrameEventArgs e)
        {
            Bitmap bmp =
                (Bitmap)e.Frame.Clone();

            picCamera.Image =
                bmp;
        }


        private void btnCapture_Click(
object sender,
EventArgs e)
        {
            if (picCamera.Image == null)
                return;

            picCard.Image =
                (Image)
                picCamera.Image.Clone();

            picCard.Visible = true;

            using (MemoryStream ms =
                new MemoryStream())
            {
                picCard.Image.Save(
                    ms,
                    System.Drawing.Imaging
                    .ImageFormat.Jpeg);

                aiScanImage =
                    ms.ToArray();
            }

            MessageBox.Show(
                "Captured");
        }

        private void btnUpload_Click(
object sender,
EventArgs e)
        {
            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
            "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog()
                == DialogResult.OK)
            {
                aiScanImage =
                    File.ReadAllBytes(
                        ofd.FileName);

                picCard.Image =
                    Image.FromFile(
                        ofd.FileName);

                picCard.Visible = true;
            }
        }



        private async void btnConfirm_Click(
object sender,
EventArgs e)
        {
            try
            {
                if (aiScanImage == null)
                {
                    MessageBox.Show(
                        "Choose or capture image first");

                    return;
                }

                btnConfirm.Enabled = false;
                btnConfirm.Text = "Scanning...";


                AIService ai =
                    new AIService();

                string data =
                    await ai
                    .ReadStudentCard(
                        aiScanImage);

                if (string.IsNullOrWhiteSpace(
                    data))
                {
                    MessageBox.Show(
                        "No data detected");

                    return;
                }


                JObject obj =
                    JObject.Parse(data);


                MSSV =
                    obj["MSSV"]?
                    .ToString() ?? "";

                Fname =
                    obj["Fname"]?
                    .ToString() ?? "";

                Lname =
                    obj["Lname"]?
                    .ToString() ?? "";

                Dob =
                    obj["Dob"]?
                    .ToString() ?? "";

                Gender =
                    obj["Gender"]?
                    .ToString() ?? "";

                Phone =
                    obj["Phone"]?
                    .ToString() ?? "";

                Address =
                    obj["Address"]?
                    .ToString() ?? "";

                Hometown =
                    obj["Hometown"]?
                    .ToString() ?? "";

                Email =
                    obj["Email"]?
                    .ToString() ?? "";


                MessageBox.Show(
                    "Scan successful");

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }

            finally
            {
                btnConfirm.Enabled = true;

                btnConfirm.Text =
                    "Confirm";
            }
        }

        private void btnCancel_Click(
object sender,
EventArgs e)
        {
            this.DialogResult =
                DialogResult.Cancel;

            this.Close();
        }

        private void f_AIScan_FormClosing(
object sender,
FormClosingEventArgs e)
        {
            if (camera != null
                && camera.IsRunning)
            {
                camera.SignalToStop();
            }
        }

    }
}
