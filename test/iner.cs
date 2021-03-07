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
    public partial class iner : Form
    {
        public iner()
        {
            InitializeComponent();
        }

        private void iner_Load(object sender, EventArgs e)
        {
            string name = (string)Classsql.SelectValue("iser", "[id]", "1", 3);
            string info = (string)Classsql.SelectValue("iser", "[id]", "1", 4);
            labisername.Text = name;
            tbiserinfo.Text = "    "+info;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
