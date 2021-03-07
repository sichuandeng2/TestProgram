using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
namespace longding
{
    public partial class Form1 : Form
    {
        private int add;
        private Boolean er=false;
        Process por = new Process();
        
        public int Add
        {
            get
            {
                return add;
            }
            set
            {
                add = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Add = 50;
            label1.Text = "系统加载中......("+add+"%)";
            bar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Add += 10;
            if (Add == 60)
            {
                label1.Text = "正在访问服务器......(" + Add + "%)";
                if (ClassCheck.IsdbPath)
                    ClassCheck.update();
            }
            if (er)
            {
                Add -= 5;
            }
            else
            {
                bar();
            }
            if (Add == 70)
            {
                ClassCheck.updatestr();
                label1.Text = "正在检测端口......(" + Add + "%)";
                check();
            }

            if (Add >= 100)
            {
               
                this.Close();
            }
                
        }
        void check()
        {
            if (ClassCheck.IsdbPath)
            {
                if (!ClassCheck.IsTestPath)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "试验文件不存在";
                    er = true;
                }
                else
                {
                    try
                    {
                        ClassCheck.open();
                    }
                    catch
                    {
                        MessageBox.Show("数据库连接失败");
                    }
                }
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = ClassCheck._link;
                er = true;
            }
        }
        void bar()
        {
            if(Add<=100)
            progressBar1.Value = Add;
        }

    }
}
