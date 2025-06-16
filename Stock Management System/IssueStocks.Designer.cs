namespace Stock_Management_System
{
    partial class IssueStocks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stock_Management_System.Properties.Resources.stock;
            this.pictureBox1.Location = new System.Drawing.Point(14, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // IssueBtn
            // 
            this.IssueBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.IssueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IssueBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.ForeColor = System.Drawing.Color.Black;
            this.IssueBtn.Location = new System.Drawing.Point(535, 274);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(164, 59);
            this.IssueBtn.TabIndex = 16;
            this.IssueBtn.Text = "Issue";
            this.IssueBtn.UseVisualStyleBackColor = false;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Quantity";
            // 
            // Quantity
            // 
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(507, 194);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(244, 40);
            this.Quantity.TabIndex = 14;
            this.Quantity.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Stock ID";
            // 
            // Id
            // 
            this.Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id.Location = new System.Drawing.Point(507, 124);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(244, 40);
            this.Id.TabIndex = 12;
            this.Id.Text = "";
            // 
            // IssueStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.panel1);
            this.Name = "IssueStocks";
            this.Text = "Issue Stocks";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Id;
    }
}