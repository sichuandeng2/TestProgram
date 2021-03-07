using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace TestApp

{
    public partial class myqd : Form 
    {
        private int startnum = 0;
        private int totalnum ;
        private int pagenum = 17;
        private int totalpage;
        private int currentpage;

        public myqd()
        {
            InitializeComponent();
        }   

        private void myqd_Load(object sender, EventArgs e)
        {
            if (!myinfo._isadmini)
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            Classdata mydata = new Classdata();
            //dataGridView1.DataSource = mydata.GetData("myqd").Tables[0];
            getdata();
            int c = dataGridView1.Columns.Count;
            for (int i = 0; i < c; i++)
            {
                this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.X, e.RowBounds.Y, dataGridView1.RowHeadersWidth, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics,
                (e.RowIndex+1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                dataGridView1.RowHeadersDefaultCellStyle.BackColor,
                TextFormatFlags.VerticalCenter|TextFormatFlags.Right);
        }

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                startnum = startnum - pagenum;
                if (startnum < 0)
                {
                    startnum = 0;
                }

            }
            if (e.ClickedItem.Text == "下一页")
            {
                startnum = startnum + pagenum;
                if (startnum >= totalnum)
                {
                    startnum = startnum - pagenum;
                    return;
                }

            }

            loaddata();
        }
        #region 自定义函数借口
        /// <summary>
        /// 获取DataGridView加载页
        /// </summary>
        private void getdata()
        {
            Classdata data = new Classdata();
            data.GetData("myqd");
            totalnum = data.TotalValue;
            totalpage = (totalnum % pagenum == 0) ? totalnum / pagenum : totalnum / pagenum + 1;
            toolStripLabel1.Text = "/" + totalpage.ToString();
            loaddata();
        }
        /// <summary>
        /// 实现页码加载器
        /// </summary>
        private void loaddata()
        {
            currentpage = startnum / pagenum + 1;
            toolStripTextBox1.Text = currentpage.ToString();

            Classdata newdata = new Classdata();
            DataSet myset = newdata.GetData(startnum, pagenum, "myqd");
            bindingSource1.DataSource = myset.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }
        #endregion

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnname = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            string rowname = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string value = dataGridView1.CurrentCell.Value.ToString();
            Classdata mydata = new Classdata();
            mydata.UpDate("myqd", columnname, value, "[id]", rowname);
        }
    }
}
