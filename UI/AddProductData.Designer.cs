namespace 一盒蛋玩具店.UI
{
    partial class AddProductData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductData));
            LstCategory = new System.Windows.Forms.ListBox();
            TxtBarcode = new System.Windows.Forms.TextBox();
            TxtName = new System.Windows.Forms.TextBox();
            BtnCheck = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            BtnAdd = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            LblLastPage = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            DgvProduct = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            TpSet = new System.Windows.Forms.TabPage();
            PnlSet = new System.Windows.Forms.Panel();
            TpSelect = new System.Windows.Forms.TabPage();
            PnlSelect = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).BeginInit();
            tabControl1.SuspendLayout();
            TpSet.SuspendLayout();
            PnlSet.SuspendLayout();
            TpSelect.SuspendLayout();
            PnlSelect.SuspendLayout();
            SuspendLayout();
            // 
            // LstCategory
            // 
            LstCategory.AllowDrop = true;
            LstCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LstCategory.FormattingEnabled = true;
            LstCategory.ItemHeight = 30;
            LstCategory.Location = new System.Drawing.Point(12, 162);
            LstCategory.Name = "LstCategory";
            LstCategory.Size = new System.Drawing.Size(564, 154);
            LstCategory.TabIndex = 0;
            LstCategory.SelectedIndexChanged += LstCategory_SelectedIndexChanged;
            LstCategory.Format += LstCategory_Format;
            // 
            // TxtBarcode
            // 
            TxtBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBarcode.Location = new System.Drawing.Point(12, 42);
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new System.Drawing.Size(371, 38);
            TxtBarcode.TabIndex = 1;
            TxtBarcode.KeyPress += TxtBarcode_KeyPress;
            // 
            // TxtName
            // 
            TxtName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtName.Location = new System.Drawing.Point(12, 55);
            TxtName.Name = "TxtName";
            TxtName.Size = new System.Drawing.Size(564, 38);
            TxtName.TabIndex = 2;
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCheck.Location = new System.Drawing.Point(410, 568);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new System.Drawing.Size(211, 53);
            BtnCheck.TabIndex = 3;
            BtnCheck.Text = "確認";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 30);
            label1.TabIndex = 4;
            label1.Text = "條碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 30);
            label2.TabIndex = 5;
            label2.Text = "名稱";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 129);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 30);
            label3.TabIndex = 6;
            label3.Text = "商品種類";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnAdd.Location = new System.Drawing.Point(365, 105);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(211, 54);
            BtnAdd.TabIndex = 7;
            BtnAdd.Text = "新增";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(135, 337);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 30);
            label4.TabIndex = 8;
            label4.Text = "/";
            // 
            // LblLastPage
            // 
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(164, 337);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(81, 30);
            LblLastPage.TabIndex = 9;
            LblLastPage.Text = "label5";
            // 
            // NudPage
            // 
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(12, 337);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(120, 34);
            NudPage.TabIndex = 10;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // DgvProduct
            // 
            DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProduct.Location = new System.Drawing.Point(3, 47);
            DgvProduct.Name = "DgvProduct";
            DgvProduct.RowTemplate.Height = 25;
            DgvProduct.Size = new System.Drawing.Size(569, 306);
            DgvProduct.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TpSet);
            tabControl1.Controls.Add(TpSelect);
            tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(12, 86);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(605, 476);
            tabControl1.TabIndex = 12;
            // 
            // TpSet
            // 
            TpSet.Controls.Add(PnlSet);
            TpSet.Location = new System.Drawing.Point(4, 35);
            TpSet.Name = "TpSet";
            TpSet.Padding = new System.Windows.Forms.Padding(3);
            TpSet.Size = new System.Drawing.Size(597, 437);
            TpSet.TabIndex = 0;
            TpSet.Text = "商品設定";
            TpSet.UseVisualStyleBackColor = true;
            // 
            // PnlSet
            // 
            PnlSet.Controls.Add(label2);
            PnlSet.Controls.Add(LstCategory);
            PnlSet.Controls.Add(BtnAdd);
            PnlSet.Controls.Add(TxtName);
            PnlSet.Controls.Add(label4);
            PnlSet.Controls.Add(NudPage);
            PnlSet.Controls.Add(label3);
            PnlSet.Controls.Add(LblLastPage);
            PnlSet.Location = new System.Drawing.Point(6, 6);
            PnlSet.Name = "PnlSet";
            PnlSet.Size = new System.Drawing.Size(585, 436);
            PnlSet.TabIndex = 11;
            // 
            // TpSelect
            // 
            TpSelect.Controls.Add(PnlSelect);
            TpSelect.Location = new System.Drawing.Point(4, 35);
            TpSelect.Name = "TpSelect";
            TpSelect.Padding = new System.Windows.Forms.Padding(3);
            TpSelect.Size = new System.Drawing.Size(597, 437);
            TpSelect.TabIndex = 1;
            TpSelect.Text = "選取商品";
            TpSelect.UseVisualStyleBackColor = true;
            // 
            // PnlSelect
            // 
            PnlSelect.Controls.Add(label5);
            PnlSelect.Controls.Add(DgvProduct);
            PnlSelect.Location = new System.Drawing.Point(6, 6);
            PnlSelect.Name = "PnlSelect";
            PnlSelect.Size = new System.Drawing.Size(585, 387);
            PnlSelect.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 30);
            label5.TabIndex = 12;
            label5.Text = "商品";
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSearch.Location = new System.Drawing.Point(387, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new System.Drawing.Size(210, 54);
            BtnSearch.TabIndex = 11;
            BtnSearch.Text = "搜尋／新增";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // AddProductData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(623, 633);
            Controls.Add(BtnSearch);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Controls.Add(TxtBarcode);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "AddProductData";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AddProductData";
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).EndInit();
            tabControl1.ResumeLayout(false);
            TpSet.ResumeLayout(false);
            PnlSet.ResumeLayout(false);
            PnlSet.PerformLayout();
            TpSelect.ResumeLayout(false);
            PnlSelect.ResumeLayout(false);
            PnlSelect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox LstCategory;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpSet;
        private System.Windows.Forms.TabPage TpSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnlSet;
        private System.Windows.Forms.Panel PnlSelect;
        private System.Windows.Forms.Button BtnSearch;
    }
}