﻿namespace Stock_Management_System
{
    partial class EmployeeDashboard
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
            this.IssueStockBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewStocksBtn = new System.Windows.Forms.Button();
            this.AddQuantityBtn = new System.Windows.Forms.Button();
            this.AddNewStockBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(307, 538);
            this.panel1.TabIndex = 1;
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
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
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
            // IssueStockBtn
            // 
            this.IssueStockBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IssueStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueStockBtn.ForeColor = System.Drawing.Color.White;
            this.IssueStockBtn.Location = new System.Drawing.Point(379, 284);
            this.IssueStockBtn.Name = "IssueStockBtn";
            this.IssueStockBtn.Size = new System.Drawing.Size(271, 74);
            this.IssueStockBtn.TabIndex = 19;
            this.IssueStockBtn.Text = "Issue Stock";
            this.IssueStockBtn.UseVisualStyleBackColor = false;
            this.IssueStockBtn.Click += new System.EventHandler(this.IssueStockBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "All Rights Reserved";
            // 
            // ViewStocksBtn
            // 
            this.ViewStocksBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewStocksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStocksBtn.ForeColor = System.Drawing.Color.White;
            this.ViewStocksBtn.Location = new System.Drawing.Point(379, 364);
            this.ViewStocksBtn.Name = "ViewStocksBtn";
            this.ViewStocksBtn.Size = new System.Drawing.Size(271, 74);
            this.ViewStocksBtn.TabIndex = 17;
            this.ViewStocksBtn.Text = "Available Stocks";
            this.ViewStocksBtn.UseVisualStyleBackColor = false;
            this.ViewStocksBtn.Click += new System.EventHandler(this.ViewStocksBtn_Click);
            // 
            // AddQuantityBtn
            // 
            this.AddQuantityBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddQuantityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQuantityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuantityBtn.ForeColor = System.Drawing.Color.White;
            this.AddQuantityBtn.Location = new System.Drawing.Point(379, 208);
            this.AddQuantityBtn.Name = "AddQuantityBtn";
            this.AddQuantityBtn.Size = new System.Drawing.Size(271, 70);
            this.AddQuantityBtn.TabIndex = 16;
            this.AddQuantityBtn.Text = "Add Quantity";
            this.AddQuantityBtn.UseVisualStyleBackColor = false;
            this.AddQuantityBtn.Click += new System.EventHandler(this.AddQuantityBtn_Click);
            // 
            // AddNewStockBtn
            // 
            this.AddNewStockBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddNewStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewStockBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewStockBtn.Location = new System.Drawing.Point(379, 130);
            this.AddNewStockBtn.Name = "AddNewStockBtn";
            this.AddNewStockBtn.Size = new System.Drawing.Size(271, 72);
            this.AddNewStockBtn.TabIndex = 15;
            this.AddNewStockBtn.Text = "Add New Stock";
            this.AddNewStockBtn.UseVisualStyleBackColor = false;
            this.AddNewStockBtn.Click += new System.EventHandler(this.AddNewStockBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 538);
            this.Controls.Add(this.IssueStockBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewStocksBtn);
            this.Controls.Add(this.AddQuantityBtn);
            this.Controls.Add(this.AddNewStockBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IssueStockBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewStocksBtn;
        private System.Windows.Forms.Button AddQuantityBtn;
        private System.Windows.Forms.Button AddNewStockBtn;
        private System.Windows.Forms.Label label1;
    }
}