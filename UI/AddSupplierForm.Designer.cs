namespace 一盒蛋玩具店.UI
{
    partial class AddSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierForm));
            TxtName = new System.Windows.Forms.TextBox();
            MtxPhone = new System.Windows.Forms.MaskedTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            BtnCheck = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtName.Location = new System.Drawing.Point(16, 47);
            TxtName.Name = "TxtName";
            TxtName.Size = new System.Drawing.Size(376, 42);
            TxtName.TabIndex = 0;
            // 
            // MtxPhone
            // 
            MtxPhone.Culture = new System.Globalization.CultureInfo("zh-Hant-TW");
            MtxPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MtxPhone.Location = new System.Drawing.Point(16, 130);
            MtxPhone.Mask = "(00)9000-0000";
            MtxPhone.Name = "MtxPhone";
            MtxPhone.Size = new System.Drawing.Size(376, 42);
            MtxPhone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 35);
            label1.TabIndex = 3;
            label1.Text = "電話";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 35);
            label2.TabIndex = 4;
            label2.Text = "名稱";
            // 
            // BtnCheck
            // 
            BtnCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCheck.Location = new System.Drawing.Point(16, 196);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new System.Drawing.Size(376, 52);
            BtnCheck.TabIndex = 5;
            BtnCheck.Text = "確定";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // AddSupplierForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 278);
            Controls.Add(BtnCheck);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MtxPhone);
            Controls.Add(TxtName);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSupplierForm";
            Text = "新增廠商";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MtxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCheck;
    }
}