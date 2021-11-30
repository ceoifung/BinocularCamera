using AForge.Video.DirectShow;
using BinocularCamera.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BinocularCamera
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;//所有摄像设备
        private VideoCaptureDevice videoDevice1;//摄像设备
        private VideoCaptureDevice videoDevice2;//摄像设备
        private ToolStripMenuItem preCameraItem1 = null;
        private ToolStripMenuItem preCameraItem2 = null;
        //private VideoCapabilities[] videoCapabilities;//摄像头分辨率

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetVideoLstTbl();
        }

        /// <summary>
        /// 获取视频设备
        /// </summary>
        private void GetVideoLstTbl()
        {
            CameraToolStripMenuItem1.DropDownItems.Clear();
            CameraToolStripMenuItem2.DropDownItems.Clear();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);//得到机器所有接入的摄像设备
            if (videoDevices.Count != 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    CameraToolStripMenuItem1.DropDownItems.Add(device.Name, null, new EventHandler(MenuCamera1Clicked));
                    CameraToolStripMenuItem2.DropDownItems.Add(device.Name, null, new EventHandler(MenuCamera2Clicked));
                }
                if (videoDevices.Count >= 2)
                {
                    CameraToolStripMenuItem1.DropDownItems[0].PerformClick();
                    CameraToolStripMenuItem2.DropDownItems[1].PerformClick();
                }
                else
                {
                    CameraToolStripMenuItem1.DropDownItems[0].PerformClick();
                }

            }
            else
            {
                CameraToolStripMenuItem1.DropDownItems.Add("没有找到摄像头");
                CameraToolStripMenuItem2.DropDownItems.Add("没有找到摄像头");
            }
        }

        private void MenuCamera2Clicked(object sender, EventArgs e)
        {
            if (preCameraItem2 != (sender as ToolStripMenuItem))
            {
                if (preCameraItem2 != null)
                    preCameraItem2.Image = null;
                (sender as ToolStripMenuItem).Image = Resources._checked;
                preCameraItem2 = (sender as ToolStripMenuItem);
                DisConnect(2);
                videoDevice2 = new VideoCaptureDevice(videoDevices[CameraToolStripMenuItem2.DropDownItems.IndexOf(preCameraItem2)].MonikerString);
                //videoCapabilities = videoDevice2.VideoCapabilities;
                //videoDevice2.VideoResolution = videoCapabilities[0]; //摄像头分辨率
                videoSourcePlayer2.VideoSource = videoDevice2;//把摄像头赋给控件
                videoSourcePlayer2.Start();//开启摄像头
            }
        }

        private void MenuCamera1Clicked(object sender, EventArgs e)
        {
            if (preCameraItem1 != (sender as ToolStripMenuItem))
            {
                if (preCameraItem1 != null)
                    preCameraItem1.Image = null;
                (sender as ToolStripMenuItem).Image = Resources._checked;
                preCameraItem1 = (sender as ToolStripMenuItem);
                DisConnect(1);
                videoDevice1 = new VideoCaptureDevice(videoDevices[CameraToolStripMenuItem1.DropDownItems.IndexOf(preCameraItem1)].MonikerString);
                videoSourcePlayer1.VideoSource = videoDevice1;//把摄像头赋给控件
                videoSourcePlayer1.Start();//开启摄像头
            }
        }

        /// <summary>
        /// 关闭并释放
        /// </summary>
        private void DisConnect(int type)
        {
            if (type == 1)
            {
                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();
                    videoSourcePlayer1.WaitForStop();
                    videoSourcePlayer1.VideoSource = null;
                }
            }
            else
            {
                if (videoSourcePlayer2.VideoSource != null)
                {
                    videoSourcePlayer2.SignalToStop();
                    videoSourcePlayer2.WaitForStop();
                    videoSourcePlayer2.VideoSource = null;
                }
            }
            
        }

        private void DisConnectAll()
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
                videoSourcePlayer1.VideoSource = null;
            }
            if (videoSourcePlayer2.VideoSource != null)
            {
                videoSourcePlayer2.SignalToStop();
                videoSourcePlayer2.WaitForStop();
                videoSourcePlayer2.VideoSource = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisConnectAll();
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            Graphics g = Graphics.FromImage(image);
            Font font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawString("video1_Ceoifung", font, Brushes.Red, new PointF(5, 15));
        }

        private void videoSourcePlayer2_NewFrame(object sender, ref Bitmap image)
        {
            Graphics g = Graphics.FromImage(image);
            Font font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawString("video2_Ceoifung", font, Brushes.Red, new PointF(5, 15));
        }

        private void RefreshDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisConnectAll();
            GetVideoLstTbl();
        }
    }
}
