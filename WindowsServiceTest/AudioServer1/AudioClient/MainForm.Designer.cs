﻿using System.Windows.Input;
namespace AudioServer1
{
    partial class MainForm
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
            this.ddlDevice = new System.Windows.Forms.ComboBox();
            this.getButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.muteButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.micLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlDevice
            // 
            this.ddlDevice.FormattingEnabled = true;
            this.ddlDevice.Location = new System.Drawing.Point(83, 21);
            this.ddlDevice.Name = "ddlDevice";
            this.ddlDevice.Size = new System.Drawing.Size(257, 20);
            this.ddlDevice.TabIndex = 0;
            this.ddlDevice.SelectedIndexChanged += new System.EventHandler(this.ddlDevice_SelectedIndexChanged);
            // 
            // getButton
            // 
            this.getButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.getButton.Location = new System.Drawing.Point(363, 21);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(108, 23);
            this.getButton.TabIndex = 4;
            this.getButton.Text = "开始指挥";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(83, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 50);
            this.panel1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(83, 47);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(257, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // muteButton
            // 
            this.muteButton.Enabled = false;
            this.muteButton.Location = new System.Drawing.Point(363, 50);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(108, 23);
            this.muteButton.TabIndex = 8;
            this.muteButton.Text = "客端静音";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 77);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AudioClient.Properties.Resources.microphone_icon;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(27, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 12;
            // 
            // micLabel
            // 
            this.micLabel.AutoSize = true;
            this.micLabel.Location = new System.Drawing.Point(46, 26);
            this.micLabel.Name = "micLabel";
            this.micLabel.Size = new System.Drawing.Size(17, 12);
            this.micLabel.TabIndex = 13;
            this.micLabel.Text = "源";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "客端音量";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.micLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.ddlDevice);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "AudioServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlDevice;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button muteButton;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label micLabel;
        private System.Windows.Forms.Label label1;
    }
}

