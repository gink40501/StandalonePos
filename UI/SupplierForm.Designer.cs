namespace 一盒蛋玩具店.UI
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            Lbl2 = new System.Windows.Forms.Label();
            Lbl1 = new System.Windows.Forms.Label();
            LblLastPage = new System.Windows.Forms.Label();
            Lbl = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            LblCurrentPage = new System.Windows.Forms.Label();
            LstData = new System.Windows.Forms.ListBox();
            BtnAdd = new System.Windows.Forms.Button();
            BtnCheck = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            SuspendLayout();
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl2.Location = new System.Drawing.Point(274, 201);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new System.Drawing.Size(47, 35);
            Lbl2.TabIndex = 20;
            Lbl2.Text = "10";
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl1.Location = new System.Drawing.Point(274, 166);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new System.Drawing.Size(177, 35);
            Lbl1.TabIndex = 19;
            Lbl1.Text = "顯示項目數量";
            // 
            // LblLastPage
            // 
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(274, 131);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(92, 35);
            LblLastPage.TabIndex = 18;
            LblLastPage.Text = "label1";
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl.Location = new System.Drawing.Point(274, 96);
            Lbl.Name = "Lbl";
            Lbl.Size = new System.Drawing.Size(96, 35);
            Lbl.TabIndex = 17;
            Lbl.Text = "最末頁";
            // 
            // NudPage
            // 
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(274, 51);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(269, 42);
            NudPage.TabIndex = 16;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // LblCurrentPage
            // 
            LblCurrentPage.AutoSize = true;
            LblCurrentPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCurrentPage.Location = new System.Drawing.Point(274, 13);
            LblCurrentPage.Name = "LblCurrentPage";
            LblCurrentPage.Size = new System.Drawing.Size(123, 35);
            LblCurrentPage.TabIndex = 15;
            LblCurrentPage.Text = "目前頁數";
            // 
            // LstData
            // 
            LstData.AllowDrop = true;
            LstData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LstData.FormattingEnabled = true;
            LstData.ItemHeight = 26;
            LstData.Location = new System.Drawing.Point(13, 48);
            LstData.Margin = new System.Windows.Forms.Padding(4);
            LstData.Name = "LstData";
            LstData.Size = new System.Drawing.Size(254, 264);
            LstData.TabIndex = 14;
            LstData.SelectedIndexChanged += LstData_SelectedIndexChanged;
            LstData.Format += LstData_Format;
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnAdd.Location = new System.Drawing.Point(14, 346);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(254, 56);
            BtnAdd.TabIndex = 21;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCheck.Location = new System.Drawing.Point(274, 346);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new System.Drawing.Size(269, 56);
            BtnCheck.TabIndex = 23;
            BtnCheck.Text = "確認";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 35);
            label1.TabIndex = 24;
            label1.Text = "廠商";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(561, 423);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Controls.Add(BtnAdd);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Controls.Add(LblLastPage);
            Controls.Add(Lbl);
            Controls.Add(NudPage);
            Controls.Add(LblCurrentPage);
            Controls.Add(LstData);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SupplierForm";
            Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.Label LblCurrentPage;
        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label label1;
    }
}