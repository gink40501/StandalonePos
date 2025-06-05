namespace 一盒蛋玩具店.UI
{
    partial class PurchaseSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseSettingsForm));
            BtnProductData = new System.Windows.Forms.Button();
            BtnCheck = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            LblCategoryName = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            LblProductName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            LblBarcode = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            NudUnitPrice = new System.Windows.Forms.NumericUpDown();
            NudQuantity = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantity).BeginInit();
            SuspendLayout();
            // 
            // BtnProductData
            // 
            BtnProductData.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnProductData.Location = new System.Drawing.Point(398, 63);
            BtnProductData.Name = "BtnProductData";
            BtnProductData.Size = new System.Drawing.Size(137, 37);
            BtnProductData.TabIndex = 0;
            BtnProductData.Text = "商品資料";
            BtnProductData.UseVisualStyleBackColor = true;
            BtnProductData.Click += BtnProductData_Click;
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCheck.Location = new System.Drawing.Point(12, 238);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new System.Drawing.Size(535, 72);
            BtnCheck.TabIndex = 8;
            BtnCheck.Text = "確認";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 30);
            label1.TabIndex = 9;
            label1.Text = "商品條碼";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Linen;
            panel1.Controls.Add(LblCategoryName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LblProductName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(LblBarcode);
            panel1.Controls.Add(BtnProductData);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(535, 105);
            panel1.TabIndex = 10;
            // 
            // LblCategoryName
            // 
            LblCategoryName.AutoSize = true;
            LblCategoryName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblCategoryName.Location = new System.Drawing.Point(118, 70);
            LblCategoryName.Name = "LblCategoryName";
            LblCategoryName.Size = new System.Drawing.Size(81, 30);
            LblCategoryName.TabIndex = 14;
            LblCategoryName.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 70);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 30);
            label5.TabIndex = 13;
            label5.Text = "種類";
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblProductName.Location = new System.Drawing.Point(118, 40);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new System.Drawing.Size(81, 30);
            LblProductName.TabIndex = 12;
            LblProductName.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 40);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 30);
            label3.TabIndex = 11;
            label3.Text = "名稱";
            // 
            // LblBarcode
            // 
            LblBarcode.AutoSize = true;
            LblBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblBarcode.Location = new System.Drawing.Point(118, 10);
            LblBarcode.Name = "LblBarcode";
            LblBarcode.Size = new System.Drawing.Size(81, 30);
            LblBarcode.TabIndex = 10;
            LblBarcode.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Linen;
            panel2.Controls.Add(NudUnitPrice);
            panel2.Controls.Add(NudQuantity);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Location = new System.Drawing.Point(12, 123);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(535, 109);
            panel2.TabIndex = 11;
            // 
            // NudUnitPrice
            // 
            NudUnitPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudUnitPrice.Location = new System.Drawing.Point(118, 50);
            NudUnitPrice.Maximum = new decimal(new int[] { -559939584, 902409669, 54, 0 });
            NudUnitPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudUnitPrice.Name = "NudUnitPrice";
            NudUnitPrice.Size = new System.Drawing.Size(414, 38);
            NudUnitPrice.TabIndex = 19;
            NudUnitPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NudQuantity
            // 
            NudQuantity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudQuantity.Location = new System.Drawing.Point(118, 6);
            NudQuantity.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            NudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudQuantity.Name = "NudQuantity";
            NudQuantity.Size = new System.Drawing.Size(414, 38);
            NudQuantity.TabIndex = 18;
            NudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(3, 52);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(109, 30);
            label9.TabIndex = 17;
            label9.Text = "進貨單價";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(3, 8);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 30);
            label7.TabIndex = 15;
            label7.Text = "進貨數量";
            // 
            // PurchaseSettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 317);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BtnCheck);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "PurchaseSettingsForm";
            Text = "PurchaseSettingsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button BtnProductData;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblBarcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudUnitPrice;
        private System.Windows.Forms.NumericUpDown NudQuantity;
    }
}