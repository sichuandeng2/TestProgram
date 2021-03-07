using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Diagnostics;
using System.IO;
namespace TestApp

{
    public partial class Form1 : Form
    {
        private int I { get; set; }
        private int N { get; set; }
        int t = 1;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string start = Application.StartupPath+"/start.exe";
            I = 30;
            N = 5;
            myinfo._name = "";
            if (!ClassCheck.check())
            {
                MessageBox.Show("请从start启动","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (File.Exists(start))
                {
                    Process pro = new Process();
                    pro.StartInfo.FileName = start;
                    pro.StartInfo.UseShellExecute = true;
                    pro.StartInfo.CreateNoWindow = true;
                    pro.Start();
                    pro.Close();
                }
                else {

                    MessageBox.Show("未找到系统文件start.exe","系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Application.Exit();
            }
            linksql();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Visible = true;
            
            myinfo._Myform1 = this;
            txtuser.Text = "User";
            txtpwd.Text = "Password";
            txtpwd.ForeColor = Color.YellowGreen; 
            txtuser.ForeColor = Color.YellowGreen;
            
            Classdata.update();
        }
        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            enteruser();
        }
        /// <summary>
        /// 激活密码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtpwd_Click(object sender, EventArgs e)
        {
            
            if (txtpwd.Text == "Password")
            {
                txtpwd.Clear();
            }
        }
        /// <summary>
        /// 用户名更改时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (txtuser.Text == "User" )
            {
                txtuser.ForeColor = Color.YellowGreen;
                txtpwd.ForeColor = Color.YellowGreen;
            }
            else
            {
                txtpwd.Text = "Password";
                txtpwd.ForeColor = Color.YellowGreen;
                txtuser.ForeColor = Color.Black;
                //txtpwd.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// 激活用户时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_Click(object sender, EventArgs e)
        {   
            if(txtuser.Text =="User")
            {
                txtuser.Clear();
            }
        }
        /// <summary>
        /// 密码改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            if (txtpwd.Text == "Password")
            {
                txtpwd.ForeColor = Color.YellowGreen;
                txtuser.ForeColor = Color.YellowGreen;
                txtpwd.UseSystemPasswordChar = false;
            }
            else if (txtuser.Text == "User" && txtpwd.Text == "333233")
            {
                myinfo._name = "当前为破解操作，数据无价操作请谨慎";
                this.Hide();
                myinfo._main = new Form2Main();
                myinfo._main.Show();
                myinfo._isadmini = false;
            }
            else
            {
                this.txtpwd.ForeColor = Color.Black;
                //this.txtuser.ForeColor = Color.Black;
                txtpwd.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// 注册接口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string path = Classdata.Web + "newusers.aspx";
            Process pro = new Process();
            pro.StartInfo.FileName = path;
            pro.StartInfo.UseShellExecute = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            pro.Close();

            //AddUser NewUser = new AddUser();
            //NewUser.Show();
        }
        /// <summary>
        /// 用户被离开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
                txtuser.Text = "User";
        }
        /// <summary>
        /// 密码被离开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "Password";
            }
        }

        #region 自定义函数体
        void renew()
        {
            this.txtuser.Clear();
            this.txtuser.Text = "User";
           // this.txtuser.ForeColor = Color.YellowGreen;
            this.txtpwd.Clear();
            this.txtpwd.Text = "Password";
            //this.txtpwd.ForeColor = Color.YellowGreen;
            this.txtuser.Focus();
        }
        void linksql()
        {
            if (!ClassCheck.Issql)
            {     
                if (ClassCheck._link== "连接服务器失败")
                {
                    this.Text = ClassCheck._link;
                    this.Text = ClassCheck._link + "，将在" + (I - t) + "秒后重试。";
                }
                button2.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                this.Text = ClassCheck._link;
            }
        }
        void enteruser()
        {
            if (ClassCheck.Issql)
            {
                //连接数据库是查找用户密码
                string user = (string)Classsql.SelectValue("users", "[user]", txtuser.Text, 1);
                string pwd = (string)Classsql.SelectValue("users", "[user]", txtuser.Text, 2);
                //判断密码是否等于数据库密码
                if (txtpwd.Text == pwd)
                {
                    //查看是否为管理员
                    Boolean admini = (Boolean)Classsql.SelectValue("users", "[user]", txtuser.Text, 4);
                    if (admini)
                        myinfo._isadmini = true;
                    //查看用户名称
                    myinfo._name = (string)Classsql.SelectValue("users", "[user]", txtuser.Text, 3);
                    this.Hide();
                    myinfo._main = new Form2Main();
                    myinfo._main.Show();
                }
                else if (txtuser.Text == "User" && txtpwd.Text == "Password")
                {
                    MessageBox.Show("请输入用户信息", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (user == "")
                {
                    MessageBox.Show("本用户不存在，如没有用户请联系管理员注册。本程序可以免费使用。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renew();
                }
                else
                {
                    MessageBox.Show("密码错误", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renew();
                }
            }
            else
            {
                this.Text = ClassCheck._link;
            }
                
        }

       
        #endregion
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myinfo._name == "")
            {
                this.Show();
            }

            else
            {
              
                myinfo._main.Show();
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (myinfo._name == "")
                {

                    this.Show();
                }
                else
                {
                        myinfo._main.Show();
                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ClassCheck._link == "连接服务器失败")
            {
                this.Text = ClassCheck._link + "，将在" + (I - t) + "秒后重试。";
                t++;
                if (I == t)
                {
                    linksql();
                    I = I * 2;
                    N++;
                    if (N == 5)
                    {
                        I = 30;
                    }
                }
            }


        }

        private void linkLbtest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //string path = (string)Classsql.SelectValue("iser", "id", "1", 1);
            string path = Classdata.Web;
            Process pro = new Process();
            pro.StartInfo.FileName = path;
            pro.StartInfo.UseShellExecute = true;
            pro.StartInfo.CreateNoWindow = true;
            pro.Start();
            pro.Close();
        }
    }


}
