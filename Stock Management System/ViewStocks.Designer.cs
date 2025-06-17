namespace Stock_Management_System
{
    partial class ViewStocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.StockDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Stocks";
            // 
            // StockDataGrid
            // 
            this.StockDataGrid.AllowUserToAddRows = false;
            this.StockDataGrid.AllowUserToDeleteRows = false;
            this.StockDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.StockDataGrid.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.StockDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataGrid.GridColor = System.Drawing.Color.Black;
            this.StockDataGrid.Location = new System.Drawing.Point(12, 85);
            this.StockDataGrid.Name = "StockDataGrid";
            this.StockDataGrid.ReadOnly = true;
            this.StockDataGrid.RowHeadersWidth = 62;
            this.StockDataGrid.RowTemplate.Height = 28;
            this.StockDataGrid.Size = new System.Drawing.Size(1157, 353);
            this.StockDataGrid.TabIndex = 2;
            // 
            // ViewStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1181, 462);
            this.Controls.Add(this.StockDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "ViewStocks";
            this.Text = "View Stocks";
            this.Load += new System.EventHandler(this.ViewStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StockDataGrid;
    }
}