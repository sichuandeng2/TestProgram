using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp

{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {

            getusers();
            resize();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        #region 自定义函数
        /// <summary>
        /// 生成用户数据表
        /// </summary>
        void getusers()
        {
        
            DataSet myData = new DataSet("mydata");
            myData = Classsql.getDataSet( "users");
            dataGridViewusers.EditMode = DataGridViewEditMode.EditOnEnter;
            bindingSourceusers.DataSource = myData.Tables[0];
            dataGridViewusers.DataSource = bindingSourceusers; 
        }
        /// <summary>
        /// 调整行宽
        /// </summary>
        void resize()
        {
            int length = dataGridViewusers.Columns.Count;
            for (int i = 0; i < length; i++)
            {
                dataGridViewusers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewusers.Sort(dataGridViewusers.Columns[0], ListSortDirection.Descending);
        }


        #endregion

        private void dataGridViewusers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            string str = dataGridViewusers.Columns[e.ColumnIndex].HeaderText;
            string str1 = dataGridViewusers.Rows[e.RowIndex].Cells[0].Value.ToString();
            string str2 = dataGridViewusers.CurrentCell.Value.ToString();
            string updatestr = "update users set "+str+"='"+str2+"' where id='"+str1+"'";
            Classsql.Insert(updatestr);
        }
    }
}
