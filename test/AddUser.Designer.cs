namespace TestApp

{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.Textpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextEntpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelUser = new System.Windows.Forms.Label();
            this.Labelpwd = new System.Windows.Forms.Label();
            this.LabelEntpwd = new System.Windows.Forms.Label();
            this.errorProvideruser = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideruser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(145, 59);
            this.TextUser.MaxLength = 20;
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(148, 21);
            this.TextUser.TabIndex = 0;
            this.TextUser.TextChanged += new System.EventHandler(this.TextUser_TextChanged);
            this.TextUser.Leave += new System.EventHandler(this.TextUser_Leave);
            // 
            // Textpwd
            // 
            this.Textpwd.Location = new System.Drawing.Point(146, 105);
            this.Textpwd.MaxLength = 20;
            this.Textpwd.Name = "Textpwd";
            this.Textpwd.Size = new System.Drawing.Size(148, 21);
            this.Textpwd.TabIndex = 1;
            this.Textpwd.UseSystemPasswordChar = true;
            this.Textpwd.TextChanged += new System.EventHandler(this.Textpwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // TextEntpwd
            // 
            this.TextEntpwd.Location = new System.Drawing.Point(146, 153);
            this.TextEntpwd.MaxLength = 20;
            this.TextEntpwd.Name = "TextEntpwd";
            this.TextEntpwd.Size = new System.Drawing.Size(148, 21);
            this.TextEntpwd.TabIndex = 2;
            this.TextEntpwd.UseSystemPasswordChar = true;
            this.TextEntpwd.TextChanged += new System.EventHandler(this.TextEntpwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(145, 198);
            this.TextName.MaxLength = 20;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(148, 21);
            this.TextName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "网络授权名：";
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Location = new System.Drawing.Point(98, 332);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(98, 30);
            this.ButtonAddUser.TabIndex = 4;
            this.ButtonAddUser.Text = "注 册";
            this.ButtonAddUser.UseVisualStyleBackColor = true;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "取 消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(144, 83);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(0, 12);
            this.LabelUser.TabIndex = 10;
            // 
            // Labelpwd
            // 
            this.Labelpwd.AutoSize = true;
            this.Labelpwd.Location = new System.Drawing.Point(145, 129);
            this.Labelpwd.Name = "Labelpwd";
            this.Labelpwd.Size = new System.Drawing.Size(0, 12);
            this.Labelpwd.TabIndex = 11;
            // 
            // LabelEntpwd
            // 
            this.LabelEntpwd.AutoSize = true;
            this.LabelEntpwd.Location = new System.Drawing.Point(145, 177);
            this.LabelEntpwd.Name = "LabelEntpwd";
            this.LabelEntpwd.Size = new System.Drawing.Size(0, 12);
            this.LabelEntpwd.TabIndex = 12;
            // 
            // errorProvideruser
            // 
            this.errorProvideruser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvideruser.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 439);
            this.ControlBox = false;
            this.Controls.Add(this.LabelEntpwd);
            this.Controls.Add(this.Labelpwd);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonAddUser);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextEntpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Textpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvideruser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.TextBox Textpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextEntpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label Labelpwd;
        private System.Windows.Forms.Label LabelEntpwd;
        private System.Windows.Forms.ErrorProvider errorProvideruser;
    }
}