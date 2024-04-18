namespace Bandits
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            BtnCancel = new Button();
            BtnDelete = new Button();
            TxtDelProdId = new TextBox();
            TabDeleteProduct = new TabPage();
            LblDelProdId = new Label();
            TabModifyProduct = new TabPage();
            DdModId = new ComboBox();
            DdModStatus = new ComboBox();
            BtnModify = new Button();
            LblModId = new Label();
            TxtModIntRate = new TextBox();
            TxtModProdName = new TextBox();
            LblModIntRate = new Label();
            LblModStatus = new Label();
            LblModProdName = new Label();
            LblNewIntRate = new Label();
            LblNewStatus = new Label();
            LblNewProdName = new Label();
            TabControl = new TabControl();
            TabNewProduct = new TabPage();
            DdStatus = new ComboBox();
            BtnAddProduct = new Button();
            TxtNewIntRate = new TextBox();
            TxtNewProdName = new TextBox();
            TabDeleteProduct.SuspendLayout();
            TabModifyProduct.SuspendLayout();
            TabControl.SuspendLayout();
            TabNewProduct.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(277, 330);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(128, 34);
            BtnCancel.TabIndex = 1001;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(14, 92);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 34);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete Product";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtDelProdId
            // 
            TxtDelProdId.Location = new Point(145, 13);
            TxtDelProdId.Name = "TxtDelProdId";
            TxtDelProdId.Size = new Size(150, 31);
            TxtDelProdId.TabIndex = 0;
            // 
            // TabDeleteProduct
            // 
            TabDeleteProduct.Controls.Add(BtnDelete);
            TabDeleteProduct.Controls.Add(TxtDelProdId);
            TabDeleteProduct.Controls.Add(LblDelProdId);
            TabDeleteProduct.Location = new Point(4, 34);
            TabDeleteProduct.Name = "TabDeleteProduct";
            TabDeleteProduct.Padding = new Padding(3);
            TabDeleteProduct.Size = new Size(389, 259);
            TabDeleteProduct.TabIndex = 2;
            TabDeleteProduct.Text = "Delete Product";
            TabDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // LblDelProdId
            // 
            LblDelProdId.AutoSize = true;
            LblDelProdId.Location = new Point(14, 22);
            LblDelProdId.Name = "LblDelProdId";
            LblDelProdId.Size = new Size(97, 25);
            LblDelProdId.TabIndex = 0;
            LblDelProdId.Text = "Product ID";
            // 
            // TabModifyProduct
            // 
            TabModifyProduct.Controls.Add(DdModId);
            TabModifyProduct.Controls.Add(DdModStatus);
            TabModifyProduct.Controls.Add(BtnModify);
            TabModifyProduct.Controls.Add(LblModId);
            TabModifyProduct.Controls.Add(TxtModIntRate);
            TabModifyProduct.Controls.Add(TxtModProdName);
            TabModifyProduct.Controls.Add(LblModIntRate);
            TabModifyProduct.Controls.Add(LblModStatus);
            TabModifyProduct.Controls.Add(LblModProdName);
            TabModifyProduct.Location = new Point(4, 34);
            TabModifyProduct.Name = "TabModifyProduct";
            TabModifyProduct.Padding = new Padding(3);
            TabModifyProduct.Size = new Size(389, 259);
            TabModifyProduct.TabIndex = 1;
            TabModifyProduct.Text = "Modify Product";
            TabModifyProduct.UseVisualStyleBackColor = true;
            // 
            // DdModId
            // 
            DdModId.DropDownStyle = ComboBoxStyle.DropDownList;
            DdModId.FormattingEnabled = true;
            DdModId.Location = new Point(203, 26);
            DdModId.Name = "DdModId";
            DdModId.Size = new Size(146, 33);
            DdModId.TabIndex = 34;
            // 
            // DdModStatus
            // 
            DdModStatus.FormattingEnabled = true;
            DdModStatus.Items.AddRange(new object[] { "open", "closed" });
            DdModStatus.Location = new Point(203, 117);
            DdModStatus.Name = "DdModStatus";
            DdModStatus.Size = new Size(150, 33);
            DdModStatus.TabIndex = 33;
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(18, 205);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(148, 34);
            BtnModify.TabIndex = 9;
            BtnModify.Text = "Modify Product";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // LblModId
            // 
            LblModId.AutoSize = true;
            LblModId.Location = new Point(18, 26);
            LblModId.Name = "LblModId";
            LblModId.Size = new Size(97, 25);
            LblModId.TabIndex = 32;
            LblModId.Text = "Product ID";
            // 
            // TxtModIntRate
            // 
            TxtModIntRate.Location = new Point(203, 153);
            TxtModIntRate.Name = "TxtModIntRate";
            TxtModIntRate.Size = new Size(150, 31);
            TxtModIntRate.TabIndex = 3;
            TxtModIntRate.Text = "0.0";
            // 
            // TxtModProdName
            // 
            TxtModProdName.Location = new Point(203, 79);
            TxtModProdName.Name = "TxtModProdName";
            TxtModProdName.Size = new Size(150, 31);
            TxtModProdName.TabIndex = 1;
            // 
            // LblModIntRate
            // 
            LblModIntRate.AutoSize = true;
            LblModIntRate.Location = new Point(18, 156);
            LblModIntRate.Name = "LblModIntRate";
            LblModIntRate.Size = new Size(111, 25);
            LblModIntRate.TabIndex = 18;
            LblModIntRate.Text = "Interest Rate";
            // 
            // LblModStatus
            // 
            LblModStatus.AutoSize = true;
            LblModStatus.Location = new Point(18, 117);
            LblModStatus.Name = "LblModStatus";
            LblModStatus.Size = new Size(60, 25);
            LblModStatus.TabIndex = 17;
            LblModStatus.Text = "Status";
            // 
            // LblModProdName
            // 
            LblModProdName.AutoSize = true;
            LblModProdName.Location = new Point(18, 82);
            LblModProdName.Name = "LblModProdName";
            LblModProdName.Size = new Size(126, 25);
            LblModProdName.TabIndex = 16;
            LblModProdName.Text = "Product Name";
            // 
            // LblNewIntRate
            // 
            LblNewIntRate.AutoSize = true;
            LblNewIntRate.Location = new Point(11, 95);
            LblNewIntRate.Name = "LblNewIntRate";
            LblNewIntRate.Size = new Size(111, 25);
            LblNewIntRate.TabIndex = 2;
            LblNewIntRate.Text = "Interest Rate";
            // 
            // LblNewStatus
            // 
            LblNewStatus.AutoSize = true;
            LblNewStatus.Location = new Point(11, 56);
            LblNewStatus.Name = "LblNewStatus";
            LblNewStatus.Size = new Size(60, 25);
            LblNewStatus.TabIndex = 1;
            LblNewStatus.Text = "Status";
            // 
            // LblNewProdName
            // 
            LblNewProdName.AutoSize = true;
            LblNewProdName.Location = new Point(11, 21);
            LblNewProdName.Name = "LblNewProdName";
            LblNewProdName.Size = new Size(126, 25);
            LblNewProdName.TabIndex = 0;
            LblNewProdName.Text = "Product Name";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabNewProduct);
            TabControl.Controls.Add(TabModifyProduct);
            TabControl.Controls.Add(TabDeleteProduct);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(397, 297);
            TabControl.TabIndex = 1000;
            // 
            // TabNewProduct
            // 
            TabNewProduct.Controls.Add(DdStatus);
            TabNewProduct.Controls.Add(BtnAddProduct);
            TabNewProduct.Controls.Add(TxtNewIntRate);
            TabNewProduct.Controls.Add(TxtNewProdName);
            TabNewProduct.Controls.Add(LblNewIntRate);
            TabNewProduct.Controls.Add(LblNewStatus);
            TabNewProduct.Controls.Add(LblNewProdName);
            TabNewProduct.Location = new Point(4, 34);
            TabNewProduct.Name = "TabNewProduct";
            TabNewProduct.Padding = new Padding(3);
            TabNewProduct.Size = new Size(389, 259);
            TabNewProduct.TabIndex = 0;
            TabNewProduct.Text = "New Product";
            TabNewProduct.UseVisualStyleBackColor = true;
            // 
            // DdStatus
            // 
            DdStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            DdStatus.Enabled = false;
            DdStatus.FormattingEnabled = true;
            DdStatus.Items.AddRange(new object[] { "open", "closed" });
            DdStatus.Location = new Point(196, 56);
            DdStatus.Name = "DdStatus";
            DdStatus.Size = new Size(150, 33);
            DdStatus.TabIndex = 9;
            // 
            // BtnAddProduct
            // 
            BtnAddProduct.Location = new Point(11, 152);
            BtnAddProduct.Name = "BtnAddProduct";
            BtnAddProduct.Size = new Size(128, 34);
            BtnAddProduct.TabIndex = 8;
            BtnAddProduct.Text = "Add Product";
            BtnAddProduct.UseVisualStyleBackColor = true;
            BtnAddProduct.Click += BtnAddProduct_Click;
            // 
            // TxtNewIntRate
            // 
            TxtNewIntRate.Location = new Point(196, 92);
            TxtNewIntRate.MaxLength = 9;
            TxtNewIntRate.Name = "TxtNewIntRate";
            TxtNewIntRate.Size = new Size(150, 31);
            TxtNewIntRate.TabIndex = 2;
            TxtNewIntRate.Text = "0.0";
            TxtNewIntRate.KeyPress += TxtNewIntRate_KeyPress;
            // 
            // TxtNewProdName
            // 
            TxtNewProdName.Location = new Point(196, 18);
            TxtNewProdName.Name = "TxtNewProdName";
            TxtNewProdName.Size = new Size(150, 31);
            TxtNewProdName.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 392);
            Controls.Add(BtnCancel);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Modify Product Details";
            Load += Form3_Load;
            TabDeleteProduct.ResumeLayout(false);
            TabDeleteProduct.PerformLayout();
            TabModifyProduct.ResumeLayout(false);
            TabModifyProduct.PerformLayout();
            TabControl.ResumeLayout(false);
            TabNewProduct.ResumeLayout(false);
            TabNewProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCancel;
        private Button BtnDelete;
        private TextBox TxtDelProdId;
        private TabPage TabDeleteProduct;
        private Label LblDelProdId;
        private TabPage TabModifyProduct;
        private Button BtnModify;
        private Label LblModId;
        private TextBox TxtModIntRate;
        private TextBox TxtModProdName;
        private Label LblModIntRate;
        private Label LblModStatus;
        private Label LblModProdName;
        private Label LblNewIntRate;
        private Label LblNewStatus;
        private Label LblNewProdName;
        private TabControl TabControl;
        private TabPage TabNewProduct;
        private Button BtnAddProduct;
        private TextBox TxtNewIntRate;
        private TextBox TxtNewProdName;
        private ComboBox DdStatus;
        private ComboBox DdModStatus;
        private ComboBox DdModId;
    }
}