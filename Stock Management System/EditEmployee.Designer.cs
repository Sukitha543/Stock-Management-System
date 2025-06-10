namespace Stock_Management_System
{
    partial class EditEmployee
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
            this.EmployeeId = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.ContactNumber = new System.Windows.Forms.RichTextBox();
            this.Email = new System.Windows.Forms.RichTextBox();
            this.LastName = new System.Windows.Forms.RichTextBox();
            this.FirstName = new System.Windows.Forms.RichTextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.EmployeeId);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.ContactNumber);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 538);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmployeeId
            // 
            this.EmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeId.Location = new System.Drawing.Point(372, 39);
            this.EmployeeId.Multiline = true;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(231, 36);
            this.EmployeeId.TabIndex = 0;
            this.EmployeeId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(509, 459);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(145, 61);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Lime;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(659, 30);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(135, 60);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // Address
            // 
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(438, 346);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(310, 94);
            this.Address.TabIndex = 7;
            this.Address.Text = "";
            // 
            // ContactNumber
            // 
            this.ContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumber.Location = new System.Drawing.Point(438, 291);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(310, 36);
            this.ContactNumber.TabIndex = 6;
            this.ContactNumber.Text = "";
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(438, 237);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(310, 36);
            this.Email.TabIndex = 5;
            this.Email.Text = "";
            // 
            // LastName
            // 
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(438, 183);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(310, 36);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "";
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(438, 131);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(310, 32);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stock_Management_System.Properties.Resources._6823086;
            this.pictureBox1.Location = new System.Drawing.Point(32, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Employee ID :";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 538);
            this.Controls.Add(this.panel1);
            this.Name = "EditEmployee";
            this.Text = "Edit Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.RichTextBox ContactNumber;
        private System.Windows.Forms.RichTextBox Email;
        private System.Windows.Forms.RichTextBox LastName;
        private System.Windows.Forms.RichTextBox FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmployeeId;
        private System.Windows.Forms.Button EditBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
    }
}