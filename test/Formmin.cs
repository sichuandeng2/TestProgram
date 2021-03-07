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
    public partial class Formmin : Form
    {
        public Formmin()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Main main = new Form2Main();
            main.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            myinfo._Myform1.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


        }
    }
}
