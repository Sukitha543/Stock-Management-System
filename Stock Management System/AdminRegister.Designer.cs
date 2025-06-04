namespace Stock_Management_System
{
    partial class AdminRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.AdminId = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.ConfirmPwd = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 538);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-22, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stock_Management_System.Properties.Resources.data_warehouse_5;
            this.pictureBox1.Location = new System.Drawing.Point(54, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admin ID";
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(391, 58);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(231, 49);
            this.UserName.TabIndex = 5;
            // 
            // AdminId
            // 
            this.AdminId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminId.Location = new System.Drawing.Point(392, 164);
            this.AdminId.Multiline = true;
            this.AdminId.Name = "AdminId";
            this.AdminId.Size = new System.Drawing.Size(231, 49);
            this.AdminId.TabIndex = 6;
            // 
            // Pwd
            // 
            this.Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.Location = new System.Drawing.Point(392, 258);
            this.Pwd.Multiline = true;
            this.Pwd.Name = "Pwd";
            this.Pwd.PasswordChar = '*';
            this.Pwd.Size = new System.Drawing.Size(231, 49);
            this.Pwd.TabIndex = 7;
            this.Pwd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ConfirmPwd
            // 
            this.ConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPwd.Location = new System.Drawing.Point(391, 361);
            this.ConfirmPwd.Multiline = true;
            this.ConfirmPwd.Name = "ConfirmPwd";
            this.ConfirmPwd.PasswordChar = '*';
            this.ConfirmPwd.Size = new System.Drawing.Size(231, 49);
            this.ConfirmPwd.TabIndex = 8;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(392, 458);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(146, 56);
            this.RegisterBtn.TabIndex = 9;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(574, 458);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(143, 56);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 538);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ConfirmPwd);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.AdminId);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRegister";
            this.Text = "AdminRegister";
            this.Load += new System.EventHandler(this.AdminRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox AdminId;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox ConfirmPwd;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label6;
    }
}