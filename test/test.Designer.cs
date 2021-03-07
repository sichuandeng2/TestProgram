namespace TestApp

{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mydataDataSet = new TestApp.mydataDataSet();
            this.mydataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydataDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myuserTableAdapter = new TestApp.mydataDataSetTableAdapters.myuserTableAdapter();
            this.myuserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myqdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.butre = new System.Windows.Forms.Button();
            this.textBoxmini = new System.Windows.Forms.TextBox();
            this.textBoxmid = new System.Windows.Forms.TextBox();
            this.textBoxmax = new System.Windows.Forms.TextBox();
            this.textbl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myuserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myqdBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "28天强度",
            "7天强度"});
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "7天强度";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.CausesValidation = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(213, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 20);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "PH-12",
            "J4"});
            this.comboBox3.Location = new System.Drawing.Point(116, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(91, 20);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Text = "PH-12";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(292, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "关闭(&q)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出(&e)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "生成(&a)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "查看记录(&v)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mydataDataSet
            // 
            this.mydataDataSet.DataSetName = "mydataDataSet";
            this.mydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mydataDataSetBindingSource
            // 
            this.mydataDataSetBindingSource.DataSource = this.mydataDataSet;
            this.mydataDataSetBindingSource.Position = 0;
            // 
            // mydataDataSetBindingSource1
            // 
            this.mydataDataSetBindingSource1.DataSource = this.mydataDataSet;
            this.mydataDataSetBindingSource1.Position = 0;
            // 
            // myuserBindingSource
            // 
            this.myuserBindingSource.DataMember = "myuser";
            this.myuserBindingSource.DataSource = this.mydataDataSetBindingSource;
            // 
            // myuserTableAdapter
            // 
            this.myuserTableAdapter.ClearBeforeFill = true;
            // 
            // myuserBindingSource1
            // 
            this.myuserBindingSource1.DataMember = "myuser";
            this.myuserBindingSource1.DataSource = this.mydataDataSetBindingSource;
            // 
            // myqdBindingSource
            // 
            this.myqdBindingSource.DataMember = "myqd";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butre);
            this.panel1.Controls.Add(this.textBoxmini);
            this.panel1.Controls.Add(this.textBoxmid);
            this.panel1.Controls.Add(this.textBoxmax);
            this.panel1.Controls.Add(this.textbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 61);
            this.panel1.TabIndex = 8;
            // 
            // butre
            // 
            this.butre.Location = new System.Drawing.Point(322, 24);
            this.butre.Name = "butre";
            this.butre.Size = new System.Drawing.Size(91, 23);
            this.butre.TabIndex = 12;
            this.butre.Text = "默认值";
            this.butre.UseVisualStyleBackColor = true;
            this.butre.Click += new System.EventHandler(this.butre_Click);
            // 
            // textBoxmini
            // 
            this.textBoxmini.Location = new System.Drawing.Point(239, 27);
            this.textBoxmini.Name = "textBoxmini";
            this.textBoxmini.Size = new System.Drawing.Size(47, 21);
            this.textBoxmini.TabIndex = 15;
            this.textBoxmini.TextChanged += new System.EventHandler(this.textBoxmini_TextChanged);
            // 
            // textBoxmid
            // 
            this.textBoxmid.Location = new System.Drawing.Point(157, 27);
            this.textBoxmid.Name = "textBoxmid";
            this.textBoxmid.Size = new System.Drawing.Size(47, 21);
            this.textBoxmid.TabIndex = 15;
            this.textBoxmid.TextChanged += new System.EventHandler(this.textBoxmid_TextChanged);
            // 
            // textBoxmax
            // 
            this.textBoxmax.Location = new System.Drawing.Point(75, 27);
            this.textBoxmax.Name = "textBoxmax";
            this.textBoxmax.Size = new System.Drawing.Size(47, 21);
            this.textBoxmax.TabIndex = 15;
            this.textBoxmax.TextChanged += new System.EventHandler(this.textBoxmax_TextChanged);
            // 
            // textbl
            // 
            this.textbl.Location = new System.Drawing.Point(3, 26);
            this.textbl.Name = "textbl";
            this.textbl.Size = new System.Drawing.Size(47, 21);
            this.textbl.TabIndex = 14;
            this.textbl.TextChanged += new System.EventHandler(this.textbl_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "最小系数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "中间系数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "最大系数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "比例值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "试验日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "试验机构";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "强度等级";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 315);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "28天强度";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.test_FormClosing);
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydataDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myuserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myqdBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private mydataDataSet mydataDataSet;
        private System.Windows.Forms.BindingSource mydataDataSetBindingSource;
        private System.Windows.Forms.BindingSource mydataDataSetBindingSource1;
        private System.Windows.Forms.BindingSource myuserBindingSource;
        private mydataDataSetTableAdapters.myuserTableAdapter myuserTableAdapter;
        private System.Windows.Forms.BindingSource myuserBindingSource1;
       
        private System.Windows.Forms.BindingSource myqdBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbl;
        private System.Windows.Forms.TextBox textBoxmini;
        private System.Windows.Forms.TextBox textBoxmid;
        private System.Windows.Forms.TextBox textBoxmax;
        private System.Windows.Forms.Button butre;
    }
}