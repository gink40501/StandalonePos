namespace 一盒蛋玩具店
{
    partial class ReceivingForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivingForm));
            textBox1 = new System.Windows.Forms.TextBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            panel1 = new System.Windows.Forms.Panel();
            BtnSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            PnlSupplier = new System.Windows.Forms.Panel();
            LblPhone = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            LblSupplierName = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            BtnSupplier = new System.Windows.Forms.Button();
            PnlProduct = new System.Windows.Forms.Panel();
            DgvProdict = new System.Windows.Forms.DataGridView();
            BntRemoveListBox = new System.Windows.Forms.Button();
            BtnConfirm = new System.Windows.Forms.Button();
            BtnAddListBox = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            BtnPurchaseRecords = new System.Windows.Forms.ToolStripMenuItem();
            panel5 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            PnlSupplier.SuspendLayout();
            PnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProdict).BeginInit();
            menuStrip1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(2, 48);
            textBox1.Margin = new System.Windows.Forms.Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(486, 39);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(710, 107);
            panel1.TabIndex = 5;
            // 
            // BtnSearch
            // 
            BtnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSearch.Location = new System.Drawing.Point(502, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new System.Drawing.Size(205, 70);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "確定";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(2, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 35);
            label1.TabIndex = 3;
            label1.Text = "訂單編號";
            // 
            // PnlSupplier
            // 
            PnlSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            PnlSupplier.Controls.Add(LblPhone);
            PnlSupplier.Controls.Add(label13);
            PnlSupplier.Controls.Add(LblSupplierName);
            PnlSupplier.Controls.Add(label11);
            PnlSupplier.Controls.Add(BtnSupplier);
            PnlSupplier.Location = new System.Drawing.Point(3, 116);
            PnlSupplier.Name = "PnlSupplier";
            PnlSupplier.Size = new System.Drawing.Size(710, 76);
            PnlSupplier.TabIndex = 13;
            // 
            // LblPhone
            // 
            LblPhone.AutoSize = true;
            LblPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblPhone.Location = new System.Drawing.Point(120, 33);
            LblPhone.Name = "LblPhone";
            LblPhone.Size = new System.Drawing.Size(95, 30);
            LblPhone.TabIndex = 18;
            LblPhone.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(5, 33);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(109, 30);
            label13.TabIndex = 17;
            label13.Text = "廠商電話";
            // 
            // LblSupplierName
            // 
            LblSupplierName.AutoSize = true;
            LblSupplierName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblSupplierName.Location = new System.Drawing.Point(120, 3);
            LblSupplierName.Name = "LblSupplierName";
            LblSupplierName.Size = new System.Drawing.Size(95, 30);
            LblSupplierName.TabIndex = 16;
            LblSupplierName.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(5, 3);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(109, 30);
            label11.TabIndex = 15;
            label11.Text = "廠商名稱";
            // 
            // BtnSupplier
            // 
            BtnSupplier.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSupplier.Location = new System.Drawing.Point(502, 3);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new System.Drawing.Size(205, 70);
            BtnSupplier.TabIndex = 2;
            BtnSupplier.Text = "廠商";
            BtnSupplier.UseVisualStyleBackColor = true;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // PnlProduct
            // 
            PnlProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            PnlProduct.Controls.Add(DgvProdict);
            PnlProduct.Controls.Add(BntRemoveListBox);
            PnlProduct.Controls.Add(BtnConfirm);
            PnlProduct.Controls.Add(BtnAddListBox);
            PnlProduct.Controls.Add(label3);
            PnlProduct.Location = new System.Drawing.Point(3, 198);
            PnlProduct.Name = "PnlProduct";
            PnlProduct.Size = new System.Drawing.Size(710, 368);
            PnlProduct.TabIndex = 6;
            // 
            // DgvProdict
            // 
            DgvProdict.AllowDrop = true;
            DgvProdict.AllowUserToAddRows = false;
            DgvProdict.AllowUserToDeleteRows = false;
            DgvProdict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            DgvProdict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdict.Location = new System.Drawing.Point(5, 53);
            DgvProdict.Name = "DgvProdict";
            DgvProdict.ReadOnly = true;
            DgvProdict.RowHeadersWidth = 62;
            DgvProdict.RowTemplate.Height = 25;
            DgvProdict.Size = new System.Drawing.Size(542, 312);
            DgvProdict.TabIndex = 9;
            // 
            // BntRemoveListBox
            // 
            BntRemoveListBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BntRemoveListBox.Location = new System.Drawing.Point(553, 103);
            BntRemoveListBox.Name = "BntRemoveListBox";
            BntRemoveListBox.Size = new System.Drawing.Size(154, 44);
            BntRemoveListBox.TabIndex = 7;
            BntRemoveListBox.Text = "刪除";
            BntRemoveListBox.UseVisualStyleBackColor = true;
            BntRemoveListBox.Click += BntRemoveListBox_Click;
            // 
            // BtnConfirm
            // 
            BtnConfirm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnConfirm.Location = new System.Drawing.Point(551, 321);
            BtnConfirm.Name = "BtnConfirm";
            BtnConfirm.Size = new System.Drawing.Size(154, 44);
            BtnConfirm.TabIndex = 6;
            BtnConfirm.Text = "確認";
            BtnConfirm.UseVisualStyleBackColor = true;
            BtnConfirm.Click += BtnConfirm_Click;
            // 
            // BtnAddListBox
            // 
            BtnAddListBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnAddListBox.Location = new System.Drawing.Point(553, 53);
            BtnAddListBox.Name = "BtnAddListBox";
            BtnAddListBox.Size = new System.Drawing.Size(154, 44);
            BtnAddListBox.TabIndex = 5;
            BtnAddListBox.Text = "新增";
            BtnAddListBox.UseVisualStyleBackColor = true;
            BtnAddListBox.Click += BtnAddListBox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 35);
            label3.TabIndex = 4;
            label3.Text = "商品";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 查詢ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(744, 38);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 查詢ToolStripMenuItem
            // 
            查詢ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { BtnPurchaseRecords });
            查詢ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            查詢ToolStripMenuItem.Name = "查詢ToolStripMenuItem";
            查詢ToolStripMenuItem.Size = new System.Drawing.Size(73, 34);
            查詢ToolStripMenuItem.Text = "查詢";
            // 
            // BtnPurchaseRecords
            // 
            BtnPurchaseRecords.Name = "BtnPurchaseRecords";
            BtnPurchaseRecords.Size = new System.Drawing.Size(230, 34);
            BtnPurchaseRecords.Text = "進貨歷史紀錄";
            BtnPurchaseRecords.Click += BtnPurchaseRecords_Click;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(PnlSupplier);
            panel5.Controls.Add(PnlProduct);
            panel5.Location = new System.Drawing.Point(12, 41);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(722, 583);
            panel5.TabIndex = 14;
            // 
            // ReceivingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(744, 627);
            Controls.Add(panel5);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ReceivingForm";
            Text = "入庫";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlSupplier.ResumeLayout(false);
            PnlSupplier.PerformLayout();
            PnlProduct.ResumeLayout(false);
            PnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProdict).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 識別碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 條碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進貨時間DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廠商名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 進價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 毛利DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlProduct;
        private System.Windows.Forms.Button BtnAddListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BntRemoveListBox;
        private System.Windows.Forms.DataGridView DgvProdict;
        private System.Windows.Forms.Panel PnlSupplier;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblSupplierName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnPriceConfiguration;
        private System.Windows.Forms.ToolStripMenuItem 查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnPurchaseRecords;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnSearch;
    }
}