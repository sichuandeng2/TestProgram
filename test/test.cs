using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace TestApp

{
    public partial class test : Form
    {
        int qd;
        private static int num = 0;
        private static double[] hz = new double[8];
        private static string myqd;
        private static string today;
        
        public test()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test_Load(object sender, EventArgs e)
        {
            myinfo._MyTest = this;
            //绑定强度等级数据源
            comboBox2.DataSource = getmyqd().Tables[0];
            comboBox2.ValueMember = getmyqd().Tables[0].Columns[0].ColumnName.ToString();
            comboBox2.DisplayMember = getmyqd().Tables[0].Columns[1].ColumnName.ToString();
            comboBox2.SelectedValue = 2;

            //绑定设置参数
            getset();
          
        }
   
        /// <summary>
        /// 返回接口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            myinfo._Myform1.Close();
        }
        /// <summary>
        /// 生成数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button3_Click(object sender, EventArgs e)
        {
            string setid = ifid();
            if (double.Parse(textBoxmax.Text) < double.Parse(textBoxmid.Text))
            {
                MessageBox.Show("最大值不能小于中间值", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (double.Parse(textBoxmid.Text) < double.Parse(textBoxmini.Text) || double.Parse(textBoxmid.Text) > double.Parse(textBoxmax.Text))
                MessageBox.Show("中间值不能小于最小值且不应大于最大值", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (double.Parse(textBoxmini.Text) > double.Parse(textBoxmid.Text))
                MessageBox.Show("中间值不能小于最小值", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int i = 0; i < 8; i++) hz[i] = 0;
                //生成数据
                if (this.comboBox1.Text == "7天强度" || this.comboBox3.Text == "J4") num = 3;
                else num = 6;
                today = comboBox1.Text;
                myqd = comboBox2.Text;
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                {
                    if (comboBox1.Text == "")
                    {
                        MessageBox.Show("试验日期不能为空", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox1.Focus();
                        return;
                    }
                    else if (comboBox2.Text == "")
                    {
                        MessageBox.Show("强度等级不能为空", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox2.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("实验项目不能为空", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBox3.Focus();
                        return;
                    }
                }
                else
                {
                    Random re = new Random();
                    if (comboBox1.Text == "28天强度")
                    {
                        if (comboBox3.Text == "PH-12")
                        {
                            if (comboBox2.Text == "C50") getqd();
                            else if (comboBox2.Text == "C40") getqd();
                            else if (comboBox2.Text == "C30") getqd();
                            else if (comboBox2.Text == "C20") getqd();
                            else if (comboBox2.Text == "C25") getqd();
                            else if (comboBox2.Text == "C15") getqd();
                            else if (comboBox2.Text == "M30") getqd();
                            else if (comboBox2.Text == "M10") getqd();
                            else
                            {
                                MessageBox.Show("混凝土强度等级选择错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (comboBox3.Text == "J4")
                        {
                            if (comboBox2.Text == "C50") getqd();
                            else if (comboBox2.Text == "C40") getqd();
                            else if (comboBox2.Text == "C30") getqd();
                            else if (comboBox2.Text == "C25") getqd();
                            else if (comboBox2.Text == "C20") getqd();
                            else if (comboBox2.Text == "C15") getqd();
                            else if (comboBox2.Text == "M30") getqd();
                            else if (comboBox2.Text == "M10") getqd();
                            else
                            {
                                MessageBox.Show("混凝土强度等级选择错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("项目选择错误");
                        }
                    }
                    else if (comboBox1.Text == "7天强度")
                    {
                        if (comboBox3.Text == "PH-12")
                        {
                            if (comboBox2.Text == "C50") getqd();
                            else
                            {
                                MessageBox.Show("7天强度目前只有C50", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("J4驻地办暂未提供7天数据", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                //数据写入datagridview                         
                dataGridView1.DataSource = MyTable();

                getdata();

            }

            Classdata mydata = new Classdata();
            mydata.UpDate("var", "[比例]", textbl.Text, "[id]", setid);
            mydata.UpDate("var", "[最大值]", textBoxmax.Text, "[id]", setid);
            mydata.UpDate("var", "[中间值]", textBoxmid.Text, "[id]", setid);
            mydata.UpDate("var", "[最小值]", textBoxmini.Text, "[id]", setid);
            
        }
        /// <summary>
        /// 打开强度窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            myqd qdlj = new myqd();
            qdlj.Show();
        }
        /// <summary>
        /// 重载掺配系数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butre_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "28天强度")
            {
                if (comboBox2.Text == "C50")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "C40")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "C30")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "C20")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "C15")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "M30")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
                else if (comboBox2.Text == "M10")
                {
                    textbl.Text = "0.618";
                    textBoxmax.Text = "1.23";
                    textBoxmid.Text = "1.20";
                    textBoxmini.Text = "1.17";
                }
            }
            else if(comboBox1.Text =="7天强度")
            {
                textbl.Text = "0.618";
                textBoxmax.Text = "1.05";
                textBoxmid.Text = "1.02";
                textBoxmini.Text = "0.98";
            }
     
        }
        private void textbl_TextChanged(object sender, EventArgs e)
        {
            myinfo.Textbl = textbl.Text; 
           
        }
        private void textBoxmax_TextChanged(object sender, EventArgs e)
        {
            myinfo.Max = textBoxmax.Text;
            //Classdata mydata = new Classdata();
           
        }
        private void textBoxmid_TextChanged(object sender, EventArgs e)
        {
            myinfo.Mid = textBoxmid.Text;
            //Classdata mydata = new Classdata();
           
        }
        private void textBoxmini_TextChanged(object sender, EventArgs e)
        {
            myinfo.Mini = textBoxmini.Text;
            //Classdata mydata = new Classdata();
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "7天强度")
            {
                comboBox2.Text = "C50";
                comboBox3.Text = "PH-12";
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                getset();
            }
            else if (comboBox1.Text == "28天强度")
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                getset();
            }
            else
            {
                MessageBox.Show("试验日期选择错误","系统提示",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "7天强度")
            {
                comboBox2.Text = "C50";
                comboBox3.Text = "PH-12";
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                getset();
            }
            else if (comboBox1.Text == "28天强度")
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                getset();
            }
            else
            {
                MessageBox.Show("试验日期选择错误", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "C50")
            {
                comboBox1.Text = "28天强度";
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
            getset();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "J4")
            {
                comboBox1.Text = "28天强度";
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }


        #region 自定义函数体
        /// <summary>
        /// 获取数据库设置
        /// </summary>
        private void getset()
        {
            string constr = "provider=microsoft.jet.oledb.4.0;data source=" +Classdata.rePath();
            //string constr = "provider=microsoft.jet.oledb.4.0;data source=" +
            //                Application.StartupPath + @"/data/mydata.mdb";
            string setid = ifid();
            string sql = "select * from var where [id]=" + setid;

            OleDbConnection con = new OleDbConnection(constr);
            try
            {
                con.Open();
                OleDbCommand com = new OleDbCommand(sql, con);
                OleDbDataReader rd;
                rd = com.ExecuteReader();
                if (rd.Read())
                {
                    myinfo.Textbl = (string)rd.GetValue(1);
                    myinfo.Max = (string)rd.GetValue(2);
                    myinfo.Mid = (string)rd.GetValue(3);
                    myinfo.Mini = (string)rd.GetValue(4);
                }
                textbl.Text = myinfo.Textbl;
                textBoxmax.Text = myinfo.Max;
                textBoxmid.Text = myinfo.Mid;
                textBoxmini.Text = myinfo.Mini;

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }

            if (myinfo._isadmini)
            {
                panel1.Enabled = true;
                //panel1.Visible = true;
            }
            else
            {
                panel1.Enabled = false;
                //panel1.Visible = false;
            }


            //this.dataGridView1.Rows[1].Selected = true;
        }
        /// <summary>
        /// 强度生成器
        /// </summary>
        private void getqd()
        {
            double getmin = double.Parse(textBoxmini.Text);
            double getmid = double.Parse(textBoxmid.Text);
            double getmax = double.Parse(textBoxmax.Text);
            int min = (int)(getmin * 100);
            int mid = (int)(getmid * 100);
            int max = (int)(getmax * 100);
            int round;
            Random re = new Random();
            qd = int.Parse(comboBox2.Text.Substring(1));
            for (int i = 0; i < num; i++)
            {
                double she = re.NextDouble();
                double thisdouble = re.NextDouble();
                if (she < double.Parse(textbl.Text))
                {
                    round = re.Next(min, mid);
                }
                else
                {
                    round = re.Next(mid, max);
                }
                hz[i] = (round * qd / 100 + thisdouble) * 22.5;
                double q = hz[i] / 22.5;
            }
        }
        /// <summary>
        /// 生成数据集写入dataset
        /// </summary>
        /// <returns></returns>
        private DataTable MyTable()
        {
            DataTable mytb = new DataTable("myqdtable");
            DataColumn col1 = new DataColumn("荷载", Type.GetType("System.String"));
            DataColumn col2 = new DataColumn("强度", Type.GetType("System.String"));
            mytb.Columns.Add(col1);
            mytb.Columns.Add(col2);

            double[] datastr = new double[]
            {
                hz[0],hz[1],hz[2],hz[3], hz[4], hz[5]
            };

            for (int i = 0; i < num; i++)
            {
                DataRow ro = mytb.NewRow();
                ro["荷载"] = Math.Round(datastr[i], 2).ToString("0.00");
                ro["强度"] = Math.Round(datastr[i] / 22.5, 1).ToString("0.0");
                mytb.Rows.Add(ro);
            }
            return mytb;
        }
        /// <summary>
        /// 连接数据库写入数据库
        /// </summary>
        private void getdata()
        {
            string comstr = "insert into myqd(" +
                "[试验机构],[试验有效期],[强度等级],[第1荷载值],[第2荷载值],[第3荷载值],[第4荷载值],[第5荷载值],[第6荷载值])" +
                "values('"+comboBox3.Text+"','" + today + "','" + myqd + "','" + hz[0].ToString("0.00") + "','" + hz[1].ToString("0.00") + "'," +
                "'" + hz[2].ToString("0.00") + "','" + hz[3].ToString("0.00") + "','" + hz[4].ToString("0.00") + "'," +
                "'" + hz[5].ToString("0.00") + "')";
            Classdata mydata = new Classdata();
            mydata.data(comstr);
        }
        /// <summary>
        /// 填充数据表
        /// </summary>
        /// <returns></returns>
        private DataSet getmyqd()
        {
            DataSet mydata = new DataSet();
            Classdata data = new Classdata();
            mydata = data.GetData("qdinf");
            return mydata;
        }
        /// <summary>
        /// 获取数据库id
        /// </summary>
        /// <returns></returns>
        private string ifid()
        {
            string testdate = comboBox1.Text;
            string qdstandard = comboBox2.Text;
            string testcomp = comboBox3.Text;
            string setid = "";

            if (testdate == "28天强度")
            {
                if (qdstandard == "C50")
                {
                    setid = "2";
                }
                else if (qdstandard == "C40")
                {
                    setid = "3";
                }
                else if (qdstandard == "C30")
                {
                    setid = "4";
                }
                else if (qdstandard == "C25")
                {
                    setid = "5";
                }
                else if (qdstandard == "C20")
                {
                    setid = "6";
                }
                else if (qdstandard == "C15")
                {
                    setid = "7";
                }
                else if (qdstandard == "M30")
                {
                    setid = "8";
                }
                else if (qdstandard == "M10")
                {
                    setid = "9";
                }
                else
                {
                    setid = "0";
                }

            }
            else if (testdate == "7天强度")
            {
                if (qdstandard == "C50")
                {
                    setid = "1";
                }
                else
                {
                    MessageBox.Show("目前7天仅提供C50强度", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("试验时期选择错误", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return setid;
        }

        #endregion

        private void test_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }  
                
        }
    }
}
