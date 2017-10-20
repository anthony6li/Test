﻿using System;
using System.Net;
using System.Windows.Forms;
using Util;
using System.Text;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using System.Xml;
using System.Collections;

namespace JsonTestServer
{
    public partial class FrmTestSystem : Form
    {
        HttpUtil htmlUtil = new HttpUtil();
        XmlDocument doc = new XmlDocument();
        StringBuilder sb = new StringBuilder();
        //XML每行的内容
        private string xmlLine = "";


        public FrmTestSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.tv_Method.ExpandAll();
            doc.Load("TreeXml.xml"); 
            RecursionTreeControl(doc.DocumentElement, tv_Method.Nodes);//将加载完成的XML文件显示在TreeView控件
        }

        private void btn_POST_Click(object sender, EventArgs e)
        {
            string strUrl = GetUrlString();
            string postdata = this.rtb_Data.Text;
            this.rtb_ACK.Text = htmlUtil.HttpPost(strUrl, postdata);
        }

        private void btn_POST8_Click(object sender, EventArgs e)
        {
            string strUrl = GetUrlString();
            string postdata = this.rtb_Data.Text;
            this.rtb_ACK.Text = htmlUtil.HttpPostUTF8(strUrl, postdata);
        }

        private void btn_GET_Click(object sender, EventArgs e)
        {
            string strUrl = GetUrlString();
            string postdata = this.rtb_Data.Text;
            this.rtb_ACK.Text = htmlUtil.HttpGet(strUrl, postdata);
        }

        private string GetUrlString()
        {
            string strUrl = string.Empty;
            try
            {
                Uri uri = new Uri(new Uri("http://" + this.Tb_IP.Text + ":" + this.Tb_Port.Text + "/"), this.cb_Request.SelectedItem.ToString());
                strUrl = uri.OriginalString;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Url不合法，请检查输入项。\r\n{0}", ex.Message);
            }
            return strUrl;
        }

        private void tv_Method_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = 1;//指向展开的图标
        }

        private void tv_Method_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;//指向关闭的图标
        }

        private void tv_Method_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e.Node.ImageIndex = 2;
            //e.Node.SelectedImageIndex = 2;//指向展开的图标
        }

        private void tv_Method_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                if (Enum.IsDefined(typeof(JsonMethodType), e.Node.Name))
                {
                    string temp = htmlUtil.JsonObjectCreator(e.Node.Name);
                    this.rtb_Data.Text = temp;
                }
                else
                {
                    this.rtb_Data.Text = string.Empty;
                }
            }
            else
            {
                this.rtb_Data.Text = string.Empty;
            }
        }

        private void btb_SaveNodesToXml_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                //写文件头部内容
                //下面是生成RSS的OPML文件
                sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                sb.Append("<Tree>");

                //遍历根节点
                foreach (TreeNode node in tv_Method.Nodes)
                {
                    xmlLine = GetRSSText(node);
                    sb.Append(xmlLine);

                    //递归遍历节点
                    parseNode(node, sb);

                    sb.Append("</Node>");
                }
                sb.Append("</Tree>");

                StreamWriter sr = new StreamWriter("TreeXml.xml", false, System.Text.Encoding.UTF8);
                sr.Write(sb.ToString());
                sr.Close();
                //toolStripStatusLabel1.Text = "保存成功";
            }
            catch (Exception ex)
            {
                //toolStripStatusLabel1.Text = ex.Message;
            }
        }
        //递归遍历节点内容,最关键的函数
        private void parseNode(TreeNode tn, StringBuilder sb)
        {
            IEnumerator ie = tn.Nodes.GetEnumerator();

            while (ie.MoveNext())
            {
                TreeNode ctn = (TreeNode)ie.Current;
                xmlLine = GetRSSText(ctn);
                sb.Append(xmlLine);
                //如果还有子节点则继续遍历
                if (ctn.Nodes.Count > 0)
                {
                    parseNode(ctn, sb);
                }
                sb.Append("</Node>");
            }
        }

        //成生RSS节点的XML文本行
        private string GetRSSText(TreeNode node)
        {
            //根据Node属性生成XML文本
            string rssText = "<Node Name=\"" + node.Name + "\" Text=\"" + node.Text + "\" >";

            return rssText;
        }

        /// <summary>
        /// RecursionTreeControl:表示将XML文件的内容显示在TreeView控件中
        /// </summary>
        /// <param name="xmlNode">将要加载的XML文件中的节点元素</param>
        /// <param name="nodes">将要加载的XML文件中的节点集合</param>
        private void RecursionTreeControl(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)//循环遍历当前元素的子元素集合
            {
                TreeNode new_child = new TreeNode();//定义一个TreeNode节点对象
                new_child.Name = node.Attributes["Name"].Value;
                new_child.Text = node.Attributes["Text"].Value;
                nodes.Add(new_child);//向当前TreeNodeCollection集合中添加当前节点
                RecursionTreeControl(node, new_child.Nodes);//调用本方法进行递归
            }
        }
    }
}
