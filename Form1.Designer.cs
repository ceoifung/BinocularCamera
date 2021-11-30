namespace BinocularCamera
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CameraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CameraToolStripMenuItem1,
            this.CameraToolStripMenuItem2,
            this.RefreshDeviceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CameraToolStripMenuItem1
            // 
            this.CameraToolStripMenuItem1.Name = "CameraToolStripMenuItem1";
            this.CameraToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.CameraToolStripMenuItem1.Text = "摄像头1";
            // 
            // CameraToolStripMenuItem2
            // 
            this.CameraToolStripMenuItem2.Name = "CameraToolStripMenuItem2";
            this.CameraToolStripMenuItem2.Size = new System.Drawing.Size(77, 24);
            this.CameraToolStripMenuItem2.Text = "摄像头2";
            // 
            // RefreshDeviceToolStripMenuItem
            // 
            this.RefreshDeviceToolStripMenuItem.Name = "RefreshDeviceToolStripMenuItem";
            this.RefreshDeviceToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.RefreshDeviceToolStripMenuItem.Text = "刷新设备";
            this.RefreshDeviceToolStripMenuItem.Click += new System.EventHandler(this.RefreshDeviceToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoSourcePlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 397);
            this.panel1.TabIndex = 1;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BorderColor = System.Drawing.Color.DimGray;
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(440, 397);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.videoSourcePlayer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(442, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 397);
            this.panel2.TabIndex = 2;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.BorderColor = System.Drawing.Color.DimGray;
            this.videoSourcePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer2.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(440, 397);
            this.videoSourcePlayer2.TabIndex = 1;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            this.videoSourcePlayer2.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer2_NewFrame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "双目摄像头测试软件 | Copyright © 2021 | 饮尽鸿爪下的雪泥 · 小R科技强力驱动";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CameraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CameraToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private System.Windows.Forms.ToolStripMenuItem RefreshDeviceToolStripMenuItem;
    }
}

