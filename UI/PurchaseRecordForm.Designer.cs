namespace 一盒蛋玩具店.UI
{
    partial class PurchaseRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseRecordForm));
            DgvPurchase = new System.Windows.Forms.DataGridView();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            BtnUpdate = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            BtnBarcode = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            TxtBarcode = new System.Windows.Forms.TextBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            DgvSupplier = new System.Windows.Forms.DataGridView();
            BtnSupplier = new System.Windows.Forms.Button();
            tabPage4 = new System.Windows.Forms.TabPage();
            BtnPurchase = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            TxtPurchase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvPurchase).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // DgvPurchase
            // 
            DgvPurchase.AllowDrop = true;
            DgvPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPurchase.Location = new System.Drawing.Point(12, 222);
            DgvPurchase.Name = "DgvPurchase";
            DgvPurchase.RowTemplate.Height = 25;
            DgvPurchase.Size = new System.Drawing.Size(1183, 388);
            DgvPurchase.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1183, 204);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnUpdate);
            tabPage1.Location = new System.Drawing.Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1175, 167);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "全部紀錄";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnUpdate.Location = new System.Drawing.Point(3, 56);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new System.Drawing.Size(1166, 69);
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
            tabPage2.Size = new System.Drawing.Size(1175, 167);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "條碼";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnBarcode
            // 
            BtnBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnBarcode.Location = new System.Drawing.Point(884, 7);
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
            label1.Location = new System.Drawing.Point(3, 24);
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
            TxtBarcode.Size = new System.Drawing.Size(872, 38);
            TxtBarcode.TabIndex = 4;
            TxtBarcode.KeyPress += TxtBarcode_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(DgvSupplier);
            tabPage3.Controls.Add(BtnSupplier);
            tabPage3.Location = new System.Drawing.Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1175, 167);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "廠商";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // DgvSupplier
            // 
            DgvSupplier.AllowDrop = true;
            DgvSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            DgvSupplier.Location = new System.Drawing.Point(6, 6);
            DgvSupplier.MultiSelect = false;
            DgvSupplier.Name = "DgvSupplier";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DgvSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvSupplier.RowTemplate.Height = 25;
            DgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvSupplier.Size = new System.Drawing.Size(871, 164);
            DgvSupplier.TabIndex = 10;
            // 
            // BtnSupplier
            // 
            BtnSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnSupplier.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSupplier.Location = new System.Drawing.Point(883, 6);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new System.Drawing.Size(286, 155);
            BtnSupplier.TabIndex = 9;
            BtnSupplier.Text = "確認";
            BtnSupplier.UseVisualStyleBackColor = true;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BtnPurchase);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(TxtPurchase);
            tabPage4.Location = new System.Drawing.Point(4, 33);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(1175, 167);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "進貨編號";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtnPurchase
            // 
            BtnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnPurchase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnPurchase.Location = new System.Drawing.Point(883, 9);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new System.Drawing.Size(286, 155);
            BtnPurchase.TabIndex = 9;
            BtnPurchase.Text = "確認";
            BtnPurchase.UseVisualStyleBackColor = true;
            BtnPurchase.Click += BtnPurchase_Click;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(5, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 30);
            label5.TabIndex = 8;
            label5.Text = "進貨編號";
            label5.UseWaitCursor = true;
            // 
            // TxtPurchase
            // 
            TxtPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtPurchase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtPurchase.Location = new System.Drawing.Point(8, 63);
            TxtPurchase.Name = "TxtPurchase";
            TxtPurchase.Size = new System.Drawing.Size(869, 38);
            TxtPurchase.TabIndex = 7;
            TxtPurchase.KeyPress += TxtPurchase_KeyPress;
            // 
            // PurchaseRecordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1207, 629);
            Controls.Add(tabControl1);
            Controls.Add(DgvPurchase);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "PurchaseRecordForm";
            Text = "PurchaseRecordForm";
            ((System.ComponentModel.ISupportInitialize)DgvPurchase).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPurchase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPurchase;
        private System.Windows.Forms.DataGridView DgvSupplier;
    }
}