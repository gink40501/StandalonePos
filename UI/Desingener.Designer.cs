namespace 一盒蛋玩具店.表單
{
    partial class Desingener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desingener));
            panel1 = new System.Windows.Forms.Panel();
            BtnPrice = new System.Windows.Forms.Button();
            Report = new System.Windows.Forms.Button();
            BtnInventory = new System.Windows.Forms.Button();
            Sale = new System.Windows.Forms.Button();
            BtnPurchase = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            關閉系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            讀取logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(BtnPrice);
            panel1.Controls.Add(Report);
            panel1.Controls.Add(BtnInventory);
            panel1.Controls.Add(Sale);
            panel1.Controls.Add(BtnPurchase);
            panel1.Location = new System.Drawing.Point(568, 47);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(253, 668);
            panel1.TabIndex = 11;
            // 
            // BtnPrice
            // 
            BtnPrice.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnPrice.Location = new System.Drawing.Point(0, 149);
            BtnPrice.Name = "BtnPrice";
            BtnPrice.Size = new System.Drawing.Size(215, 98);
            BtnPrice.TabIndex = 8;
            BtnPrice.Text = "價格";
            BtnPrice.UseVisualStyleBackColor = true;
            BtnPrice.Click += BtnPrice_Click;
            // 
            // Report
            // 
            Report.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Report.ForeColor = System.Drawing.SystemColors.ControlText;
            Report.Location = new System.Drawing.Point(0, 563);
            Report.Margin = new System.Windows.Forms.Padding(20);
            Report.Name = "Report";
            Report.Size = new System.Drawing.Size(218, 98);
            Report.TabIndex = 7;
            Report.Text = "報表";
            Report.UseVisualStyleBackColor = true;
            // 
            // BtnInventory
            // 
            BtnInventory.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnInventory.Location = new System.Drawing.Point(0, 287);
            BtnInventory.Margin = new System.Windows.Forms.Padding(20);
            BtnInventory.Name = "BtnInventory";
            BtnInventory.Size = new System.Drawing.Size(218, 98);
            BtnInventory.TabIndex = 6;
            BtnInventory.Text = "庫存";
            BtnInventory.UseVisualStyleBackColor = true;
            BtnInventory.Click += BtnInventory_Click;
            // 
            // Sale
            // 
            Sale.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Sale.Location = new System.Drawing.Point(0, 425);
            Sale.Margin = new System.Windows.Forms.Padding(20);
            Sale.Name = "Sale";
            Sale.Size = new System.Drawing.Size(218, 98);
            Sale.TabIndex = 5;
            Sale.Text = "銷售";
            Sale.UseVisualStyleBackColor = true;
            Sale.Click += Sale_Click;
            // 
            // BtnPurchase
            // 
            BtnPurchase.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnPurchase.Location = new System.Drawing.Point(0, 28);
            BtnPurchase.Margin = new System.Windows.Forms.Padding(20);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new System.Drawing.Size(218, 98);
            BtnPurchase.TabIndex = 4;
            BtnPurchase.Text = "進貨";
            BtnPurchase.UseVisualStyleBackColor = true;
            BtnPurchase.Click += BtnPurchase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(11, 45);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(535, 631);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 關閉系統ToolStripMenuItem, 讀取logToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(821, 43);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // 關閉系統ToolStripMenuItem
            // 
            關閉系統ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            關閉系統ToolStripMenuItem.Name = "關閉系統ToolStripMenuItem";
            關閉系統ToolStripMenuItem.Size = new System.Drawing.Size(135, 39);
            關閉系統ToolStripMenuItem.Text = "關閉系統";
            // 
            // 讀取logToolStripMenuItem
            // 
            讀取logToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            讀取logToolStripMenuItem.Name = "讀取logToolStripMenuItem";
            讀取logToolStripMenuItem.Size = new System.Drawing.Size(122, 39);
            讀取logToolStripMenuItem.Text = "讀取log";
            // 
            // Desingener
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 728);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Desingener";
            StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            Text = "首頁";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 關閉系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 讀取logToolStripMenuItem;
        private System.Windows.Forms.Button BtnPrice;
    }
}