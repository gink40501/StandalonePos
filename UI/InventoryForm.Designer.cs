namespace 一盒蛋玩具店.UI
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            DgvInventory = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            LblLastPage = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            BtnUpdate = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            BtnBarcode = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TxtBarcode = new System.Windows.Forms.TextBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            DgvCategory = new System.Windows.Forms.DataGridView();
            BtnCategory = new System.Windows.Forms.Button();
            PnlPahe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)DgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategory).BeginInit();
            PnlPahe.SuspendLayout();
            SuspendLayout();
            // 
            // DgvInventory
            // 
            DgvInventory.AllowDrop = true;
            DgvInventory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInventory.Location = new System.Drawing.Point(12, 222);
            DgvInventory.Name = "DgvInventory";
            DgvInventory.RowTemplate.Height = 25;
            DgvInventory.Size = new System.Drawing.Size(726, 360);
            DgvInventory.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(132, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 30);
            label4.TabIndex = 11;
            label4.Text = "/";
            // 
            // NudPage
            // 
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(9, 15);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(120, 34);
            NudPage.TabIndex = 13;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // LblLastPage
            // 
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(161, 19);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(81, 30);
            LblLastPage.TabIndex = 12;
            LblLastPage.Text = "label5";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(736, 204);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnUpdate);
            tabPage1.Location = new System.Drawing.Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(728, 167);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "全部紀錄";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnUpdate.Location = new System.Drawing.Point(3, 56);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new System.Drawing.Size(719, 69);
            BtnUpdate.TabIndex = 2;
            BtnUpdate.Text = "全部紀錄";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnBarcode);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(TxtBarcode);
            tabPage2.Location = new System.Drawing.Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(728, 167);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "條碼";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnBarcode
            // 
            BtnBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnBarcode.Location = new System.Drawing.Point(437, 6);
            BtnBarcode.Name = "BtnBarcode";
            BtnBarcode.Size = new System.Drawing.Size(285, 155);
            BtnBarcode.TabIndex = 6;
            BtnBarcode.Text = "確認";
            BtnBarcode.UseVisualStyleBackColor = true;
            BtnBarcode.Click += BtnBarcode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(6, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 30);
            label1.TabIndex = 5;
            label1.Text = "條碼";
            label1.UseWaitCursor = true;
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBarcode.Location = new System.Drawing.Point(6, 66);
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new System.Drawing.Size(425, 38);
            TxtBarcode.TabIndex = 4;
            TxtBarcode.KeyPress += TxtBarcode_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DgvCategory);
            tabPage3.Controls.Add(BtnCategory);
            tabPage3.Location = new System.Drawing.Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(728, 167);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "產品類型";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DgvCategory
            // 
            DgvCategory.AllowDrop = true;
            DgvCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategory.Location = new System.Drawing.Point(5, 6);
            DgvCategory.MultiSelect = false;
            DgvCategory.Name = "DgvCategory";
            DgvCategory.RowTemplate.Height = 25;
            DgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvCategory.Size = new System.Drawing.Size(424, 155);
            DgvCategory.TabIndex = 10;
            // 
            // BtnCategory
            // 
            BtnCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCategory.Location = new System.Drawing.Point(436, 6);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new System.Drawing.Size(286, 155);
            BtnCategory.TabIndex = 9;
            BtnCategory.Text = "確認";
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // PnlPahe
            // 
            PnlPahe.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            PnlPahe.Controls.Add(label4);
            PnlPahe.Controls.Add(LblLastPage);
            PnlPahe.Controls.Add(NudPage);
            PnlPahe.Location = new System.Drawing.Point(12, 588);
            PnlPahe.Name = "PnlPahe";
            PnlPahe.Size = new System.Drawing.Size(410, 61);
            PnlPahe.TabIndex = 15;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(758, 669);
            Controls.Add(PnlPahe);
            Controls.Add(tabControl1);
            Controls.Add(DgvInventory);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "InventoryForm";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)DgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvCategory).EndInit();
            PnlPahe.ResumeLayout(false);
            PnlPahe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DgvCategory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Panel PnlPahe;
    }
}