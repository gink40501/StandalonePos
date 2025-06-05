namespace 一盒蛋玩具店
{
    partial class SaleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            DgvTable = new System.Windows.Forms.DataGridView();
            TxtBarcode = new System.Windows.Forms.TextBox();
            BtnSell = new System.Windows.Forms.Button();
            LblTotalAmount = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            銷單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            補單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            DgvHistoricalData = new System.Windows.Forms.DataGridView();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DgvTable).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvHistoricalData).BeginInit();
            SuspendLayout();
            // 
            // DgvTable
            // 
            DgvTable.AllowUserToAddRows = false;
            DgvTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTable.Location = new System.Drawing.Point(13, 125);
            DgvTable.Margin = new System.Windows.Forms.Padding(4);
            DgvTable.Name = "DgvTable";
            DgvTable.RowHeadersWidth = 62;
            DgvTable.RowTemplate.Height = 24;
            DgvTable.Size = new System.Drawing.Size(1198, 209);
            DgvTable.TabIndex = 0;
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtBarcode.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBarcode.Location = new System.Drawing.Point(13, 79);
            TxtBarcode.Margin = new System.Windows.Forms.Padding(4);
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new System.Drawing.Size(969, 42);
            TxtBarcode.TabIndex = 1;
            TxtBarcode.KeyPress += TxtBarcode_KeyPress;
            // 
            // BtnSell
            // 
            BtnSell.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnSell.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSell.Location = new System.Drawing.Point(1022, 342);
            BtnSell.Margin = new System.Windows.Forms.Padding(4);
            BtnSell.Name = "BtnSell";
            BtnSell.Size = new System.Drawing.Size(189, 52);
            BtnSell.TabIndex = 2;
            BtnSell.Text = "確定";
            BtnSell.UseVisualStyleBackColor = true;
            BtnSell.Click += BtnSell_Click;
            // 
            // LblTotalAmount
            // 
            LblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LblTotalAmount.AutoSize = true;
            LblTotalAmount.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTotalAmount.Location = new System.Drawing.Point(16, 371);
            LblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblTotalAmount.Name = "LblTotalAmount";
            LblTotalAmount.Size = new System.Drawing.Size(81, 29);
            LblTotalAmount.TabIndex = 3;
            LblTotalAmount.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 342);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 29);
            label2.TabIndex = 4;
            label2.Text = "總價格";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 設定ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1224, 34);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripMenuItem, 銷單ToolStripMenuItem, 補單ToolStripMenuItem });
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new System.Drawing.Size(66, 30);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            ToolStripMenuItem.Text = "結算當日營收";
            // 
            // 銷單ToolStripMenuItem
            // 
            銷單ToolStripMenuItem.Name = "銷單ToolStripMenuItem";
            銷單ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            銷單ToolStripMenuItem.Text = "銷單";
            // 
            // 補單ToolStripMenuItem
            // 
            補單ToolStripMenuItem.Name = "補單ToolStripMenuItem";
            補單ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            補單ToolStripMenuItem.Text = "補單";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 46);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 29);
            label3.TabIndex = 8;
            label3.Text = "條碼";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DgvHistoricalData);
            panel1.Location = new System.Drawing.Point(13, 403);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1198, 228);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 30);
            label1.TabIndex = 1;
            label1.Text = "歷史資料";
            // 
            // DgvHistoricalData
            // 
            DgvHistoricalData.AllowDrop = true;
            DgvHistoricalData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvHistoricalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHistoricalData.Location = new System.Drawing.Point(3, 35);
            DgvHistoricalData.Name = "DgvHistoricalData";
            DgvHistoricalData.RowTemplate.Height = 25;
            DgvHistoricalData.Size = new System.Drawing.Size(1189, 190);
            DgvHistoricalData.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnSearch.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSearch.Location = new System.Drawing.Point(1022, 70);
            BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new System.Drawing.Size(189, 52);
            BtnSearch.TabIndex = 18;
            BtnSearch.Text = "搜尋";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1224, 643);
            Controls.Add(BtnSearch);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblTotalAmount);
            Controls.Add(BtnSell);
            Controls.Add(TxtBarcode);
            Controls.Add(DgvTable);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "SaleForm";
            Text = "販賣";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DgvTable).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvHistoricalData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTable;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 銷單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 補單ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvHistoricalData;
        private System.Windows.Forms.Button BtnSearch;
    }
}