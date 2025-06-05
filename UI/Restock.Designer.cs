namespace 一盒蛋玩具店.表單
{
    partial class Restock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restock));
            panel2 = new System.Windows.Forms.Panel();
            BtnSwitchForm = new System.Windows.Forms.Button();
            Lbl2 = new System.Windows.Forms.Label();
            Lbl1 = new System.Windows.Forms.Label();
            LblCurrentPage = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            Lbl = new System.Windows.Forms.Label();
            LblLastPage = new System.Windows.Forms.Label();
            LstData = new System.Windows.Forms.ListBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            BtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            BtnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel2.Controls.Add(BtnSwitchForm);
            panel2.Controls.Add(Lbl2);
            panel2.Controls.Add(Lbl1);
            panel2.Controls.Add(LblCurrentPage);
            panel2.Controls.Add(NudPage);
            panel2.Controls.Add(Lbl);
            panel2.Controls.Add(LblLastPage);
            panel2.Controls.Add(LstData);
            panel2.Location = new System.Drawing.Point(14, 57);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(619, 476);
            panel2.TabIndex = 7;
            // 
            // BtnSwitchForm
            // 
            BtnSwitchForm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSwitchForm.Location = new System.Drawing.Point(344, 394);
            BtnSwitchForm.Name = "BtnSwitchForm";
            BtnSwitchForm.Size = new System.Drawing.Size(272, 68);
            BtnSwitchForm.TabIndex = 11;
            BtnSwitchForm.Text = "確認";
            BtnSwitchForm.UseVisualStyleBackColor = true;
            BtnSwitchForm.Click += BtnSwitchForm_Click;
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl2.Location = new System.Drawing.Point(344, 191);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new System.Drawing.Size(47, 35);
            Lbl2.TabIndex = 8;
            Lbl2.Text = "10";
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl1.Location = new System.Drawing.Point(344, 156);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new System.Drawing.Size(177, 35);
            Lbl1.TabIndex = 7;
            Lbl1.Text = "顯示項目數量";
            // 
            // LblCurrentPage
            // 
            LblCurrentPage.AutoSize = true;
            LblCurrentPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCurrentPage.Location = new System.Drawing.Point(344, 3);
            LblCurrentPage.Name = "LblCurrentPage";
            LblCurrentPage.Size = new System.Drawing.Size(123, 35);
            LblCurrentPage.TabIndex = 6;
            LblCurrentPage.Text = "目前頁數";
            // 
            // NudPage
            // 
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(344, 41);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(272, 42);
            NudPage.TabIndex = 5;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Lbl.Location = new System.Drawing.Point(344, 86);
            Lbl.Name = "Lbl";
            Lbl.Size = new System.Drawing.Size(96, 35);
            Lbl.TabIndex = 4;
            Lbl.Text = "最末頁";
            // 
            // LblLastPage
            // 
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(344, 121);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(92, 35);
            LblLastPage.TabIndex = 3;
            LblLastPage.Text = "label1";
            // 
            // LstData
            // 
            LstData.AllowDrop = true;
            LstData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LstData.FormattingEnabled = true;
            LstData.ItemHeight = 35;
            LstData.Location = new System.Drawing.Point(10, 3);
            LstData.Name = "LstData";
            LstData.Size = new System.Drawing.Size(328, 459);
            LstData.TabIndex = 0;
            LstData.Format += LstData_Format;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 設定ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(645, 43);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { BtnAdd, BtnUpdate });
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new System.Drawing.Size(81, 39);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // BtnAdd
            // 
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(144, 40);
            BtnAdd.Text = "新增";
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new System.Drawing.Size(144, 40);
            BtnUpdate.Text = "修改";
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // Restock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(645, 561);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Restock";
            Text = "Restock";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnAdd;
        private System.Windows.Forms.ToolStripMenuItem BtnUpdate;
        private System.Windows.Forms.ListBox LstData;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.Label LblCurrentPage;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button BtnSwitchForm;
    }
}