namespace 一盒蛋玩具店.表單
{
    partial class Price
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Price));
            LstData = new System.Windows.Forms.ListBox();
            LblCurrentPage = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            Lbl = new System.Windows.Forms.Label();
            LblLastPage = new System.Windows.Forms.Label();
            Lbl1 = new System.Windows.Forms.Label();
            Lbl2 = new System.Windows.Forms.Label();
            BtnUpdata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            SuspendLayout();
            // 
            // LstData
            // 
            LstData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LstData.FormattingEnabled = true;
            LstData.ItemHeight = 35;
            LstData.Location = new System.Drawing.Point(13, 9);
            LstData.Margin = new System.Windows.Forms.Padding(4);
            LstData.Name = "LstData";
            LstData.Size = new System.Drawing.Size(254, 389);
            LstData.TabIndex = 0;
            LstData.SelectedIndexChanged += LstData_SelectedIndexChanged;
            LstData.Format += LstData_Format;
            // 
            // LblCurrentPage
            // 
            LblCurrentPage.AutoSize = true;
            LblCurrentPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCurrentPage.Location = new System.Drawing.Point(274, 9);
            LblCurrentPage.Name = "LblCurrentPage";
            LblCurrentPage.Size = new System.Drawing.Size(123, 35);
            LblCurrentPage.TabIndex = 7;
            LblCurrentPage.Text = "目前頁數";
            // 
            // NudPage
            // 
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(274, 47);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(269, 42);
            NudPage.TabIndex = 8;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl.Location = new System.Drawing.Point(274, 92);
            Lbl.Name = "Lbl";
            Lbl.Size = new System.Drawing.Size(96, 35);
            Lbl.TabIndex = 9;
            Lbl.Text = "最末頁";
            // 
            // LblLastPage
            // 
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(274, 127);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(92, 35);
            LblLastPage.TabIndex = 10;
            LblLastPage.Text = "label1";
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl1.Location = new System.Drawing.Point(274, 162);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new System.Drawing.Size(177, 35);
            Lbl1.TabIndex = 11;
            Lbl1.Text = "顯示項目數量";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl2.Location = new System.Drawing.Point(274, 197);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new System.Drawing.Size(47, 35);
            Lbl2.TabIndex = 12;
            Lbl2.Text = "10";
            // 
            // BtnUpdata
            // 
            BtnUpdata.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnUpdata.Location = new System.Drawing.Point(274, 345);
            BtnUpdata.Name = "BtnUpdata";
            BtnUpdata.Size = new System.Drawing.Size(269, 53);
            BtnUpdata.TabIndex = 13;
            BtnUpdata.Text = "修改";
            BtnUpdata.UseVisualStyleBackColor = true;
            BtnUpdata.Click += BtnUpdata_Click;
            // 
            // Price
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(555, 418);
            Controls.Add(BtnUpdata);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Controls.Add(LblLastPage);
            Controls.Add(Lbl);
            Controls.Add(NudPage);
            Controls.Add(LblCurrentPage);
            Controls.Add(LstData);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Price";
            Text = "Price";
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.Label LblCurrentPage;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button BtnUpdata;
    }
}