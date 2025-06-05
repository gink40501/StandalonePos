namespace 一盒蛋玩具店.UI
{
    partial class ProductPricingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPricingForm));
            DgvProductPrice = new System.Windows.Forms.DataGridView();
            TxtBarcode = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            BtnRemove = new System.Windows.Forms.Button();
            DtpEffectiveDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            NudPrice = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            BtnAdd = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            Btnproduct = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            NudPage = new System.Windows.Forms.NumericUpDown();
            LblLastPage = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            DgvAllProduct = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            BtnBarcode = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            DgvBarcodeProduct = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            BtnSupplierCheck = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            DgvSupplierProduct = new System.Windows.Forms.DataGridView();
            BtnSupplier = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            DgvSupplier = new System.Windows.Forms.DataGridView();
            tabPage4 = new System.Windows.Forms.TabPage();
            BtnCategoryCheck = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            DgvCategoryProduct = new System.Windows.Forms.DataGridView();
            DgvCategory = new System.Windows.Forms.DataGridView();
            BtnCategory = new System.Windows.Forms.Button();
            TpProduct = new System.Windows.Forms.TabPage();
            BtnPurchase = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            DgvProduct = new System.Windows.Forms.DataGridView();
            BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DgvProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPrice).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvAllProduct).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarcodeProduct).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvSupplierProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategoryProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvCategory).BeginInit();
            TpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).BeginInit();
            SuspendLayout();
            // 
            // DgvProductPrice
            // 
            DgvProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            DgvProductPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductPrice.Location = new System.Drawing.Point(759, 42);
            DgvProductPrice.MultiSelect = false;
            DgvProductPrice.Name = "DgvProductPrice";
            DgvProductPrice.RowTemplate.Height = 25;
            DgvProductPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvProductPrice.Size = new System.Drawing.Size(461, 499);
            DgvProductPrice.TabIndex = 0;
            // 
            // TxtBarcode
            // 
            TxtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TxtBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            TxtBarcode.Location = new System.Drawing.Point(3, 44);
            TxtBarcode.Name = "TxtBarcode";
            TxtBarcode.Size = new System.Drawing.Size(493, 38);
            TxtBarcode.TabIndex = 1;
            TxtBarcode.KeyPress += TxtBarcode_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 30);
            label1.TabIndex = 2;
            label1.Text = "條碼";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(759, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 30);
            label2.TabIndex = 3;
            label2.Text = "價格列表";
            // 
            // BtnRemove
            // 
            BtnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnRemove.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnRemove.Location = new System.Drawing.Point(528, 381);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new System.Drawing.Size(225, 42);
            BtnRemove.TabIndex = 12;
            BtnRemove.Text = "刪除";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // DtpEffectiveDate
            // 
            DtpEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            DtpEffectiveDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DtpEffectiveDate.Location = new System.Drawing.Point(528, 42);
            DtpEffectiveDate.Name = "DtpEffectiveDate";
            DtpEffectiveDate.Size = new System.Drawing.Size(225, 38);
            DtpEffectiveDate.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(522, 7);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 30);
            label4.TabIndex = 8;
            label4.Text = "生效日期";
            // 
            // NudPrice
            // 
            NudPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            NudPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPrice.Location = new System.Drawing.Point(528, 162);
            NudPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPrice.Name = "NudPrice";
            NudPrice.Size = new System.Drawing.Size(225, 38);
            NudPrice.TabIndex = 7;
            NudPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(528, 129);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 30);
            label3.TabIndex = 6;
            label3.Text = "售價";
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnAdd.Location = new System.Drawing.Point(528, 254);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new System.Drawing.Size(225, 42);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "加入";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(TpProduct);
            tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(12, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(510, 532);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Btnproduct);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(NudPage);
            tabPage1.Controls.Add(LblLastPage);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(DgvAllProduct);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(502, 499);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "商品全列表";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btnproduct
            // 
            Btnproduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Btnproduct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Btnproduct.Location = new System.Drawing.Point(274, 457);
            Btnproduct.Name = "Btnproduct";
            Btnproduct.Size = new System.Drawing.Size(225, 34);
            Btnproduct.TabIndex = 15;
            Btnproduct.Text = "選取";
            Btnproduct.UseVisualStyleBackColor = true;
            Btnproduct.Click += Btnproduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(6, 4);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(61, 30);
            label8.TabIndex = 14;
            label8.Text = "商品";
            // 
            // NudPage
            // 
            NudPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            NudPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NudPage.Location = new System.Drawing.Point(15, 441);
            NudPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.Name = "NudPage";
            NudPage.Size = new System.Drawing.Size(120, 34);
            NudPage.TabIndex = 13;
            NudPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudPage.ValueChanged += NudPage_ValueChanged;
            // 
            // LblLastPage
            // 
            LblLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            LblLastPage.AutoSize = true;
            LblLastPage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblLastPage.Location = new System.Drawing.Point(161, 445);
            LblLastPage.Name = "LblLastPage";
            LblLastPage.Size = new System.Drawing.Size(81, 30);
            LblLastPage.TabIndex = 12;
            LblLastPage.Text = "label5";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(141, 445);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(23, 30);
            label7.TabIndex = 11;
            label7.Text = "/";
            // 
            // DgvAllProduct
            // 
            DgvAllProduct.AllowDrop = true;
            DgvAllProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAllProduct.Location = new System.Drawing.Point(6, 39);
            DgvAllProduct.MultiSelect = false;
            DgvAllProduct.Name = "DgvAllProduct";
            DgvAllProduct.RowTemplate.Height = 25;
            DgvAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvAllProduct.Size = new System.Drawing.Size(490, 396);
            DgvAllProduct.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnBarcode);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(DgvBarcodeProduct);
            tabPage2.Controls.Add(TxtBarcode);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(502, 499);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "條碼";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnBarcode
            // 
            BtnBarcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnBarcode.Location = new System.Drawing.Point(274, 457);
            BtnBarcode.Name = "BtnBarcode";
            BtnBarcode.Size = new System.Drawing.Size(225, 34);
            BtnBarcode.TabIndex = 16;
            BtnBarcode.Text = "選取";
            BtnBarcode.UseVisualStyleBackColor = true;
            BtnBarcode.Click += BtnBarcode_Click;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(3, 85);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 30);
            label5.TabIndex = 4;
            label5.Text = "商品";
            // 
            // DgvBarcodeProduct
            // 
            DgvBarcodeProduct.AllowDrop = true;
            DgvBarcodeProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvBarcodeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarcodeProduct.Location = new System.Drawing.Point(3, 118);
            DgvBarcodeProduct.MultiSelect = false;
            DgvBarcodeProduct.Name = "DgvBarcodeProduct";
            DgvBarcodeProduct.RowTemplate.Height = 25;
            DgvBarcodeProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvBarcodeProduct.Size = new System.Drawing.Size(493, 335);
            DgvBarcodeProduct.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BtnSupplierCheck);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(DgvSupplierProduct);
            tabPage3.Controls.Add(BtnSupplier);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(DgvSupplier);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(502, 499);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "廠商";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnSupplierCheck
            // 
            BtnSupplierCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnSupplierCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSupplierCheck.Location = new System.Drawing.Point(274, 457);
            BtnSupplierCheck.Name = "BtnSupplierCheck";
            BtnSupplierCheck.Size = new System.Drawing.Size(225, 34);
            BtnSupplierCheck.TabIndex = 16;
            BtnSupplierCheck.Text = "選取";
            BtnSupplierCheck.UseVisualStyleBackColor = true;
            BtnSupplierCheck.Click += BtnSupplierCheck_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(6, 226);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(61, 30);
            label9.TabIndex = 4;
            label9.Text = "商品";
            // 
            // DgvSupplierProduct
            // 
            DgvSupplierProduct.AllowDrop = true;
            DgvSupplierProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvSupplierProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSupplierProduct.Location = new System.Drawing.Point(6, 259);
            DgvSupplierProduct.MultiSelect = false;
            DgvSupplierProduct.Name = "DgvSupplierProduct";
            DgvSupplierProduct.RowTemplate.Height = 25;
            DgvSupplierProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvSupplierProduct.Size = new System.Drawing.Size(493, 194);
            DgvSupplierProduct.TabIndex = 3;
            // 
            // BtnSupplier
            // 
            BtnSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnSupplier.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnSupplier.Location = new System.Drawing.Point(6, 178);
            BtnSupplier.Name = "BtnSupplier";
            BtnSupplier.Size = new System.Drawing.Size(490, 45);
            BtnSupplier.TabIndex = 2;
            BtnSupplier.Text = "搜尋";
            BtnSupplier.UseVisualStyleBackColor = true;
            BtnSupplier.Click += BtnSupplier_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(6, 3);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 30);
            label6.TabIndex = 1;
            label6.Text = "廠商";
            // 
            // DgvSupplier
            // 
            DgvSupplier.AllowDrop = true;
            DgvSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSupplier.Location = new System.Drawing.Point(6, 36);
            DgvSupplier.MultiSelect = false;
            DgvSupplier.Name = "DgvSupplier";
            DgvSupplier.RowTemplate.Height = 25;
            DgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvSupplier.Size = new System.Drawing.Size(490, 140);
            DgvSupplier.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BtnCategoryCheck);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(DgvCategoryProduct);
            tabPage4.Controls.Add(DgvCategory);
            tabPage4.Controls.Add(BtnCategory);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(502, 499);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "類型";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // BtnCategoryCheck
            // 
            BtnCategoryCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnCategoryCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCategoryCheck.Location = new System.Drawing.Point(274, 457);
            BtnCategoryCheck.Name = "BtnCategoryCheck";
            BtnCategoryCheck.Size = new System.Drawing.Size(225, 34);
            BtnCategoryCheck.TabIndex = 18;
            BtnCategoryCheck.Text = "選取";
            BtnCategoryCheck.UseVisualStyleBackColor = true;
            BtnCategoryCheck.Click += BtnCategoryCheck_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(6, 226);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(61, 30);
            label10.TabIndex = 17;
            label10.Text = "商品";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(6, 3);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(61, 30);
            label11.TabIndex = 14;
            label11.Text = "類型";
            // 
            // DgvCategoryProduct
            // 
            DgvCategoryProduct.AllowDrop = true;
            DgvCategoryProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvCategoryProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategoryProduct.Location = new System.Drawing.Point(6, 259);
            DgvCategoryProduct.MultiSelect = false;
            DgvCategoryProduct.Name = "DgvCategoryProduct";
            DgvCategoryProduct.RowTemplate.Height = 25;
            DgvCategoryProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvCategoryProduct.Size = new System.Drawing.Size(493, 197);
            DgvCategoryProduct.TabIndex = 16;
            // 
            // DgvCategory
            // 
            DgvCategory.AllowDrop = true;
            DgvCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategory.Location = new System.Drawing.Point(6, 36);
            DgvCategory.Name = "DgvCategory";
            DgvCategory.RowTemplate.Height = 25;
            DgvCategory.Size = new System.Drawing.Size(490, 140);
            DgvCategory.TabIndex = 13;
            // 
            // BtnCategory
            // 
            BtnCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BtnCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCategory.Location = new System.Drawing.Point(6, 178);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new System.Drawing.Size(490, 45);
            BtnCategory.TabIndex = 15;
            BtnCategory.Text = "搜尋";
            BtnCategory.UseVisualStyleBackColor = true;
            BtnCategory.Click += BtnCategory_Click;
            // 
            // TpProduct
            // 
            TpProduct.Controls.Add(BtnPurchase);
            TpProduct.Controls.Add(label12);
            TpProduct.Controls.Add(DgvProduct);
            TpProduct.Location = new System.Drawing.Point(4, 29);
            TpProduct.Name = "TpProduct";
            TpProduct.Padding = new System.Windows.Forms.Padding(3);
            TpProduct.Size = new System.Drawing.Size(502, 499);
            TpProduct.TabIndex = 4;
            TpProduct.Text = "進貨資料";
            TpProduct.UseVisualStyleBackColor = true;
            // 
            // BtnPurchase
            // 
            BtnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnPurchase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnPurchase.Location = new System.Drawing.Point(274, 457);
            BtnPurchase.Name = "BtnPurchase";
            BtnPurchase.Size = new System.Drawing.Size(225, 36);
            BtnPurchase.TabIndex = 18;
            BtnPurchase.Text = "選取";
            BtnPurchase.UseVisualStyleBackColor = true;
            BtnPurchase.Click += BtnPurchase_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(3, 4);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(61, 30);
            label12.TabIndex = 17;
            label12.Text = "商品";
            // 
            // DgvProduct
            // 
            DgvProduct.AllowDrop = true;
            DgvProduct.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProduct.Location = new System.Drawing.Point(3, 39);
            DgvProduct.MultiSelect = false;
            DgvProduct.Name = "DgvProduct";
            DgvProduct.RowTemplate.Height = 25;
            DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvProduct.Size = new System.Drawing.Size(490, 396);
            DgvProduct.TabIndex = 15;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            BtnCancel.Location = new System.Drawing.Point(528, 495);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new System.Drawing.Size(225, 42);
            BtnCancel.TabIndex = 13;
            BtnCancel.Text = "取消選取";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // ProductPricingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1230, 574);
            Controls.Add(BtnCancel);
            Controls.Add(BtnRemove);
            Controls.Add(tabControl1);
            Controls.Add(BtnAdd);
            Controls.Add(label4);
            Controls.Add(NudPrice);
            Controls.Add(label3);
            Controls.Add(DtpEffectiveDate);
            Controls.Add(label2);
            Controls.Add(DgvProductPrice);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "ProductPricingForm";
            Text = "ProductPricingForm1";
            ((System.ComponentModel.ISupportInitialize)DgvProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPrice).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvAllProduct).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarcodeProduct).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvSupplierProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSupplier).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCategoryProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvCategory).EndInit();
            TpProduct.ResumeLayout(false);
            TpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductPrice;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private System.Windows.Forms.DateTimePicker DtpEffectiveDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvSupplierProduct;
        private System.Windows.Forms.NumericUpDown NudPage;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvBarcodeProduct;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvSupplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button BtnSupplier;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvCategoryProduct;
        private System.Windows.Forms.DataGridView DgvCategory;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.DataGridView DgvAllProduct;
        private System.Windows.Forms.Button Btnproduct;
        private System.Windows.Forms.Button BtnBarcode;
        private System.Windows.Forms.Button BtnSupplierCheck;
        private System.Windows.Forms.Button BtnCategoryCheck;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TabPage TpProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.Button BtnPurchase;
    }
}