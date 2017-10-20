﻿namespace JsonTestServer
{
    partial class FrmTestSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTestSystem));
            this.Lbl_IP = new System.Windows.Forms.Label();
            this.Lbl_Port = new System.Windows.Forms.Label();
            this.Tb_IP = new System.Windows.Forms.TextBox();
            this.Tb_Port = new System.Windows.Forms.TextBox();
            this.tv_Method = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_Data = new System.Windows.Forms.Label();
            this.rtb_Data = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_ACK = new System.Windows.Forms.RichTextBox();
            this.btn_POST = new System.Windows.Forms.Button();
            this.btn_POST8 = new System.Windows.Forms.Button();
            this.btn_GET = new System.Windows.Forms.Button();
            this.lb_RequestType = new System.Windows.Forms.Label();
            this.cb_Request = new System.Windows.Forms.ComboBox();
            this.btb_SaveNodesToXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_IP
            // 
            this.Lbl_IP.AutoSize = true;
            this.Lbl_IP.Location = new System.Drawing.Point(252, 13);
            this.Lbl_IP.Name = "Lbl_IP";
            this.Lbl_IP.Size = new System.Drawing.Size(17, 12);
            this.Lbl_IP.TabIndex = 1;
            this.Lbl_IP.Text = "IP";
            // 
            // Lbl_Port
            // 
            this.Lbl_Port.AutoSize = true;
            this.Lbl_Port.Location = new System.Drawing.Point(420, 9);
            this.Lbl_Port.Name = "Lbl_Port";
            this.Lbl_Port.Size = new System.Drawing.Size(29, 12);
            this.Lbl_Port.TabIndex = 2;
            this.Lbl_Port.Text = "Port";
            // 
            // Tb_IP
            // 
            this.Tb_IP.Location = new System.Drawing.Point(254, 26);
            this.Tb_IP.Name = "Tb_IP";
            this.Tb_IP.Size = new System.Drawing.Size(151, 21);
            this.Tb_IP.TabIndex = 3;
            this.Tb_IP.Text = "10.10.1.77";
            // 
            // Tb_Port
            // 
            this.Tb_Port.Location = new System.Drawing.Point(422, 26);
            this.Tb_Port.Name = "Tb_Port";
            this.Tb_Port.Size = new System.Drawing.Size(52, 21);
            this.Tb_Port.TabIndex = 4;
            this.Tb_Port.Text = "9905";
            // 
            // tv_Method
            // 
            this.tv_Method.FullRowSelect = true;
            this.tv_Method.ImageKey = "folder.png";
            this.tv_Method.ImageList = this.imageList1;
            this.tv_Method.Location = new System.Drawing.Point(13, 13);
            this.tv_Method.Name = "tv_Method";
            this.tv_Method.SelectedImageIndex = 0;
            this.tv_Method.Size = new System.Drawing.Size(229, 449);
            this.tv_Method.TabIndex = 8;
            this.tv_Method.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tv_Method_AfterCollapse);
            this.tv_Method.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tv_Method_AfterExpand);
            this.tv_Method.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Method_AfterSelect);
            this.tv_Method.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Method_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder_heart.png");
            this.imageList1.Images.SetKeyName(2, "folder_key.png");
            this.imageList1.Images.SetKeyName(3, "folder_delete.png");
            this.imageList1.Images.SetKeyName(4, "folder_edit.png");
            // 
            // lb_Data
            // 
            this.lb_Data.AutoSize = true;
            this.lb_Data.Location = new System.Drawing.Point(254, 69);
            this.lb_Data.Name = "lb_Data";
            this.lb_Data.Size = new System.Drawing.Size(41, 12);
            this.lb_Data.TabIndex = 9;
            this.lb_Data.Text = "数据：";
            // 
            // rtb_Data
            // 
            this.rtb_Data.Location = new System.Drawing.Point(256, 84);
            this.rtb_Data.Name = "rtb_Data";
            this.rtb_Data.Size = new System.Drawing.Size(376, 157);
            this.rtb_Data.TabIndex = 10;
            this.rtb_Data.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "应答：";
            // 
            // rtb_ACK
            // 
            this.rtb_ACK.Location = new System.Drawing.Point(258, 274);
            this.rtb_ACK.Name = "rtb_ACK";
            this.rtb_ACK.Size = new System.Drawing.Size(374, 188);
            this.rtb_ACK.TabIndex = 12;
            this.rtb_ACK.Text = "";
            // 
            // btn_POST
            // 
            this.btn_POST.Location = new System.Drawing.Point(386, 245);
            this.btn_POST.Name = "btn_POST";
            this.btn_POST.Size = new System.Drawing.Size(52, 23);
            this.btn_POST.TabIndex = 13;
            this.btn_POST.Text = "POST";
            this.btn_POST.UseVisualStyleBackColor = true;
            this.btn_POST.Click += new System.EventHandler(this.btn_POST_Click);
            // 
            // btn_POST8
            // 
            this.btn_POST8.Location = new System.Drawing.Point(467, 245);
            this.btn_POST8.Name = "btn_POST8";
            this.btn_POST8.Size = new System.Drawing.Size(76, 23);
            this.btn_POST8.TabIndex = 13;
            this.btn_POST8.Text = "POST(utf8)";
            this.btn_POST8.UseVisualStyleBackColor = true;
            this.btn_POST8.Click += new System.EventHandler(this.btn_POST8_Click);
            // 
            // btn_GET
            // 
            this.btn_GET.Location = new System.Drawing.Point(560, 245);
            this.btn_GET.Name = "btn_GET";
            this.btn_GET.Size = new System.Drawing.Size(58, 23);
            this.btn_GET.TabIndex = 13;
            this.btn_GET.Text = "GET";
            this.btn_GET.UseVisualStyleBackColor = true;
            this.btn_GET.Click += new System.EventHandler(this.btn_GET_Click);
            // 
            // lb_RequestType
            // 
            this.lb_RequestType.AutoSize = true;
            this.lb_RequestType.Location = new System.Drawing.Point(490, 9);
            this.lb_RequestType.Name = "lb_RequestType";
            this.lb_RequestType.Size = new System.Drawing.Size(53, 12);
            this.lb_RequestType.TabIndex = 14;
            this.lb_RequestType.Text = "请求类型";
            // 
            // cb_Request
            // 
            this.cb_Request.FormattingEnabled = true;
            this.cb_Request.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Request.Items.AddRange(new object[] {
            "api/hedajwreq",
            "api/hedacmdreq",
            "xml/upload"});
            this.cb_Request.Location = new System.Drawing.Point(492, 26);
            this.cb_Request.Name = "cb_Request";
            this.cb_Request.Size = new System.Drawing.Size(121, 20);
            this.cb_Request.TabIndex = 15;
            this.cb_Request.Text = "api/hedajwreq";
            // 
            // btb_SaveNodesToXml
            // 
            this.btb_SaveNodesToXml.Location = new System.Drawing.Point(376, 55);
            this.btb_SaveNodesToXml.Name = "btb_SaveNodesToXml";
            this.btb_SaveNodesToXml.Size = new System.Drawing.Size(75, 23);
            this.btb_SaveNodesToXml.TabIndex = 16;
            this.btb_SaveNodesToXml.Text = "SaveToXml";
            this.btb_SaveNodesToXml.UseVisualStyleBackColor = true;
            this.btb_SaveNodesToXml.Click += new System.EventHandler(this.btb_SaveNodesToXml_Click);
            // 
            // FrmTestSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 474);
            this.Controls.Add(this.btb_SaveNodesToXml);
            this.Controls.Add(this.cb_Request);
            this.Controls.Add(this.lb_RequestType);
            this.Controls.Add(this.btn_GET);
            this.Controls.Add(this.btn_POST8);
            this.Controls.Add(this.btn_POST);
            this.Controls.Add(this.rtb_ACK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Data);
            this.Controls.Add(this.lb_Data);
            this.Controls.Add(this.tv_Method);
            this.Controls.Add(this.Tb_Port);
            this.Controls.Add(this.Tb_IP);
            this.Controls.Add(this.Lbl_Port);
            this.Controls.Add(this.Lbl_IP);
            this.Name = "FrmTestSystem";
            this.Text = "Json Test Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_IP;
        private System.Windows.Forms.Label Lbl_Port;
        private System.Windows.Forms.TextBox Tb_IP;
        private System.Windows.Forms.TextBox Tb_Port;
        private System.Windows.Forms.TreeView tv_Method;
        private System.Windows.Forms.Label lb_Data;
        private System.Windows.Forms.RichTextBox rtb_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_ACK;
        private System.Windows.Forms.Button btn_POST;
        private System.Windows.Forms.Button btn_POST8;
        private System.Windows.Forms.Button btn_GET;
        private System.Windows.Forms.Label lb_RequestType;
        private System.Windows.Forms.ComboBox cb_Request;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btb_SaveNodesToXml;
    }
}

