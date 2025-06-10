using System;

namespace Stock_Management_System
{
    partial class AdminDashboard
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
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEmployeesBtn = new System.Windows.Forms.Button();
            this.RemoveEmployeesBtn = new System.Windows.Forms.Button();
            this.ViewEmployeesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeDetailsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 531);
            this.panel1.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Red;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutBtn.Location = new System.Drawing.Point(86, 406);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(139, 62);
            this.LogOutBtn.TabIndex = 11;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stock_Management_System.Properties.Resources.data_warehouse_5;
            this.pictureBox2.Location = new System.Drawing.Point(97, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Management ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeesBtn
            // 
            this.AddEmployeesBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeesBtn.ForeColor = System.Drawing.Color.White;
            this.AddEmployeesBtn.Location = new System.Drawing.Point(388, 113);
            this.AddEmployeesBtn.Name = "AddEmployeesBtn";
            this.AddEmployeesBtn.Size = new System.Drawing.Size(271, 72);
            this.AddEmployeesBtn.TabIndex = 9;
            this.AddEmployeesBtn.Text = "Add Employees";
            this.AddEmployeesBtn.UseVisualStyleBackColor = false;
            this.AddEmployeesBtn.Click += new System.EventHandler(this.AddEmployeesBtn_Click);
            // 
            // RemoveEmployeesBtn
            // 
            this.RemoveEmployeesBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RemoveEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeesBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveEmployeesBtn.Location = new System.Drawing.Point(388, 191);
            this.RemoveEmployeesBtn.Name = "RemoveEmployeesBtn";
            this.RemoveEmployeesBtn.Size = new System.Drawing.Size(271, 70);
            this.RemoveEmployeesBtn.TabIndex = 10;
            this.RemoveEmployeesBtn.Text = "Remove Employees";
            this.RemoveEmployeesBtn.UseVisualStyleBackColor = false;
            this.RemoveEmployeesBtn.Click += new System.EventHandler(this.RemoveEmployeesBtn_Click);
            // 
            // ViewEmployeesBtn
            // 
            this.ViewEmployeesBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployeesBtn.ForeColor = System.Drawing.Color.White;
            this.ViewEmployeesBtn.Location = new System.Drawing.Point(388, 347);
            this.ViewEmployeesBtn.Name = "ViewEmployeesBtn";
            this.ViewEmployeesBtn.Size = new System.Drawing.Size(271, 74);
            this.ViewEmployeesBtn.TabIndex = 11;
            this.ViewEmployeesBtn.Text = "View Employees";
            this.ViewEmployeesBtn.UseVisualStyleBackColor = false;
            this.ViewEmployeesBtn.Click += new System.EventHandler(this.ViewEmployeesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "All Rights Reserved";
            // 
            // EmployeeDetailsBtn
            // 
            this.EmployeeDetailsBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmployeeDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeDetailsBtn.Location = new System.Drawing.Point(388, 267);
            this.EmployeeDetailsBtn.Name = "EmployeeDetailsBtn";
            this.EmployeeDetailsBtn.Size = new System.Drawing.Size(271, 74);
            this.EmployeeDetailsBtn.TabIndex = 13;
            this.EmployeeDetailsBtn.Text = "Edit Employee Details";
            this.EmployeeDetailsBtn.UseVisualStyleBackColor = false;
            this.EmployeeDetailsBtn.Click += new System.EventHandler(this.EmployeeDetailsBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 531);
            this.Controls.Add(this.EmployeeDetailsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewEmployeesBtn);
            this.Controls.Add(this.RemoveEmployeesBtn);
            this.Controls.Add(this.AddEmployeesBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEmployeesBtn;
        private System.Windows.Forms.Button RemoveEmployeesBtn;
        private System.Windows.Forms.Button ViewEmployeesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button EmployeeDetailsBtn;
    }
}