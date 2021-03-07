using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admini
{
    public partial class Form1 : Form
    {
        //自定义函数
        #region
            /// <summary>
            /// 调整表格
            /// </summary>
        void resize() {
            int length = dataGridViewadmini.Columns.Count;
            for (int i = 0; i < length; i++)
            {
                dataGridViewadmini.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridViewadmini.Sort(dataGridViewadmini.Columns[0], ListSortDirection.Ascending);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        void bindingdata()
        {
            labweb.Text = (string)ClassSql.GetValue("iser", "id", "1", "http");
            labsql.Text = (string)ClassSql.GetValue("iser", "id", "1", "constr");

            BindingSource binding = new BindingSource();
            binding.DataSource = ClassSql.Getadapter("T_Constr").Tables[0];
            dataGridViewadmini.DataSource = binding;
        }

        void testdaata() {
           

            

        }

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingdata();
            resize();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {



        }


    }
}
