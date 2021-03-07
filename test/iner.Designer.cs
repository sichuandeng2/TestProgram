namespace TestApp
{
    partial class iner
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
            this.labisername = new System.Windows.Forms.Label();
            this.tbiserinfo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labisername
            // 
            this.labisername.AutoSize = true;
            this.labisername.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labisername.Location = new System.Drawing.Point(102, 28);
            this.labisername.Name = "labisername";
            this.labisername.Size = new System.Drawing.Size(82, 24);
            this.labisername.TabIndex = 0;
            this.labisername.Text = "label1";
            // 
            // tbiserinfo
            // 
            this.tbiserinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbiserinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbiserinfo.ForeColor = System.Drawing.Color.White;
            this.tbiserinfo.Location = new System.Drawing.Point(29, 65);
            this.tbiserinfo.Multiline = true;
            this.tbiserinfo.Name = "tbiserinfo";
            this.tbiserinfo.ReadOnly = true;
            this.tbiserinfo.Size = new System.Drawing.Size(229, 153);
            this.tbiserinfo.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(106, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "我知道了";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbiserinfo);
            this.Controls.Add(this.labisername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iner";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.iner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labisername;
        private System.Windows.Forms.TextBox tbiserinfo;
        private System.Windows.Forms.Button button2;
    }
}