using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
namespace TestApp

{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextEntpwd_TextChanged(object sender, EventArgs e)
        {
            if (Textpwd.Text != TextEntpwd.Text)
            {
                errorProvideruser.SetError(TextEntpwd, "您输入的密码不相同。");
                LabelEntpwd.Text = "您输入的密码不相同。";
            }
            else
            {
                errorProvideruser.SetError(TextEntpwd, "");
                LabelEntpwd.Text = "";
            }
        }

        private void Textpwd_TextChanged(object sender, EventArgs e)
        {
            if (Textpwd.TextLength < 3||Textpwd.TextLength>20)
            {
                errorProvideruser.SetError(Textpwd, "密码长度请设置为3～10个字符。");
                Labelpwd.Text = "密码长度请设置为3～10个字符。";
            }
            else
            {
                errorProvideruser.SetError(Textpwd, "");
                Labelpwd.Text = "";
            }

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            Labelpwd.ForeColor = Color.Red;
            LabelEntpwd.ForeColor = Color.Red;
            LabelUser.ForeColor = Color.Red;
            Labelpwd.Font = new Font("楷体",8);
            LabelEntpwd.Font = new Font("楷体",8);
            LabelUser.Font = new Font("楷体",8);
        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {
            if (TextUser.Text.Length > 10 || TextUser.Text.Length < 3)
            {
                errorProvideruser.SetError(TextUser, "用户名长度请设置在3～20位。");
                LabelUser.Text = "用户名长度请设置在3～20位。";
            }
            else
            {
                LabelUser.Text = "";
                errorProvideruser.SetError(TextUser, "");
            }
        
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            if (LabelUser.Text != "")
            {
                MessageBox.Show(LabelUser.Text,"系统提示",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
                TextUser.Clear();
                TextUser.Focus();
            }
            else if (Labelpwd.Text != "")
            {
                MessageBox.Show(Labelpwd.Text, "系统提示", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Textpwd.Clear();
                TextEntpwd.Clear();
                Textpwd.Focus();
            }
            else if (LabelEntpwd.Text != "")
            {
                MessageBox.Show(LabelEntpwd.Text, "系统提示", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Textpwd.Clear();
                TextEntpwd.Clear();
                Textpwd.Focus();
            }
            else
            {
                string comstr = "insert users([user],pwd,name,[admin])values('"+
                    TextUser.Text+"','"+Textpwd.Text+"','"+TextName.Text+"','0')";
               string error= Classsql.Insert(comstr);
                if (error==null)
                {
                    MessageBox.Show("用户注册成功，请使用新用户登录。","系统提示",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                
                
            }
        }

        private void TextUser_Leave(object sender, EventArgs e)
        {
            string datavalue = (string)Classsql.SelectValue("users", "[user]", TextUser.Text, 1);
            if (datavalue == TextUser.Text)
            {
                LabelUser.Text = "该账户已存在";
                errorProvideruser.SetError(TextUser, "该账户已经存在");
            }
            else
            {
                errorProvideruser.SetError(TextUser, "");
            }
        }
    }
}
