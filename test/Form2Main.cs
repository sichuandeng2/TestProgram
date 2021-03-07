using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TestApp

{
    public partial class Form2Main : Form
    {
        private int I { get; set; }
        private int N { get; set; }
        int t = 1;
        private Boolean iserror = false;
        public Form2Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2Main_Load(object sender, EventArgs e)
        {
            lookusers.Enabled = true;
            string cla = "用户:";
            this.Text =   ClassCheck._link;
            this.ForeColor = Color.Red;
            this.Font = new Font("楷体", 14);
            if (myinfo._isadmini)
            {
                cla = "管理员:";
                //lookusers.Enabled = true;
                lookusers.Visible = true;
            }
            else
            {
                //lookusers.Enabled = false;
                lookusers.Visible = false;
            }
                
            this.toolStripStatusLabelname.Text = "欢迎"+cla+myinfo._name+"使用本程序。";
            this.toolStripStatusLabeldate.Text = "当前时间：" +
            DateTime.Now.ToString() + "     " +DateTime.Today.ToString("dddd");

            iserr();
        }
        /// <summary>
        /// 关闭本窗口是结束程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        /// <summary>
        /// 进入强度窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 强度试验ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myinfo._MyTest == null)
            {
                myinfo._MyTest = new test();
                myinfo._MyTest.MdiParent = this;
            } 
            myinfo._MyTest.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iserror)
            {
                this.Text = ClassCheck._link + "，将在" + (I - t) + "秒后重试。";
                t++; 
                if (I == t)
                {
                    if (ClassCheck.Issql)
                    {
                        iserror = false;
                        this.Text = ClassCheck._link;
                    }
                    I = I * 2;
                    N++;
                    if (N == 5)
                    {
                        I = 30;
                    }
                }
            }
            this.toolStripStatusLabeldate.Text = "当前时间：" + 
                DateTime.Now + "     "+DateTime.Today.ToString("dddd");
        }
        private void 切换用户ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = ClassCheck.getstartstr;
            pro.StartInfo.UseShellExecute = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            Application.Exit();
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 版本信息端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 版本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myinfo._myinfo == null)
            {
                myinfo._myinfo = new info();
                myinfo._myinfo.MdiParent = this;
            }
            
            myinfo._myinfo.Show();
            
            //TextBox infotext = new TextBox();
            //infotext.Text = "欢迎使用";
            //this.Controls.Add(infotext);
            //infotext.Location = new System.Drawing.Point(40, 100);
            //infotext.Size = new System.Drawing.Size(540,480);
            //infotext.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //test z = new test();
            
        }
        /// <summary>
        /// mini版端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 精简模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formmin min = new Formmin();
            this.Hide();
            min.Show();
        }
        /// <summary>
        /// 用户管理端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassCheck.Issql)
            {
                if (myinfo._MyUsers == null)
                {
                    myinfo._MyUsers = new Users();
                    myinfo._MyUsers.MdiParent = this;
                }
                myinfo._MyUsers.Show();
            }
            else
            {
                I = 30;
                N = 5;
                iserror = true;
                this.Text = ClassCheck._link;
                linksql();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Classdata.Web+ "testwin.aspx";
            Process pro = new Process();
            pro.StartInfo.FileName = path;
            pro.StartInfo.UseShellExecute = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            pro.Close();
        }
        void linksql()
        {
            if (!ClassCheck.Issql)
            {
                if (ClassCheck._link == "连接服务器失败")
                {
                    this.Text = ClassCheck._link + "，将在" + (I - t) + "秒后重试。";

                } 
            }
            else
            {
                this.Text = ClassCheck._link;
            }
        }

        void iserr()
        {
            string  iser = (string)Classsql.SelectValue("iser", "[id]", "1", 3);
            if (iser!="")
            {
                iner te = new iner();
                te.MdiParent = this;
                te.Show();
            }
        }    
    }
}
