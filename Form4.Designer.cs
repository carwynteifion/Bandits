namespace Bandits
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            LblAccId = new Label();
            LblTranxType = new Label();
            LblTranxAmt = new Label();
            BtnCreateTranx = new Button();
            BtnCancel = new Button();
            TxtTranxAmt = new TextBox();
            DdTranxType = new ComboBox();
            DdAccId = new ComboBox();
            SuspendLayout();
            // 
            // LblAccId
            // 
            LblAccId.AutoSize = true;
            LblAccId.Location = new Point(35, 34);
            LblAccId.Name = "LblAccId";
            LblAccId.Size = new Size(100, 25);
            LblAccId.TabIndex = 0;
            LblAccId.Text = "Account ID";
            // 
            // LblTranxType
            // 
            LblTranxType.AutoSize = true;
            LblTranxType.Location = new Point(35, 78);
            LblTranxType.Name = "LblTranxType";
            LblTranxType.Size = new Size(142, 25);
            LblTranxType.TabIndex = 1;
            LblTranxType.Text = "Transaction Type";
            // 
            // LblTranxAmt
            // 
            LblTranxAmt.AutoSize = true;
            LblTranxAmt.Location = new Point(35, 125);
            LblTranxAmt.Name = "LblTranxAmt";
            LblTranxAmt.Size = new Size(170, 25);
            LblTranxAmt.TabIndex = 2;
            LblTranxAmt.Text = "Transaction Amount";
            // 
            // BtnCreateTranx
            // 
            BtnCreateTranx.Enabled = false;
            BtnCreateTranx.Location = new Point(164, 177);
            BtnCreateTranx.Name = "BtnCreateTranx";
            BtnCreateTranx.Size = new Size(112, 34);
            BtnCreateTranx.TabIndex = 3;
            BtnCreateTranx.Text = "Create";
            BtnCreateTranx.UseVisualStyleBackColor = true;
            BtnCreateTranx.Click += BtnCreateTranx_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(282, 177);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(112, 34);
            BtnCancel.TabIndex = 4;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtTranxAmt
            // 
            TxtTranxAmt.Location = new Point(241, 125);
            TxtTranxAmt.Name = "TxtTranxAmt";
            TxtTranxAmt.Size = new Size(153, 31);
            TxtTranxAmt.TabIndex = 2;
            TxtTranxAmt.TextChanged += EnableCreate;
            TxtTranxAmt.KeyPress += TxtTranxAmt_KeyPress;
            // 
            // DdTranxType
            // 
            DdTranxType.DropDownStyle = ComboBoxStyle.DropDownList;
            DdTranxType.FormattingEnabled = true;
            DdTranxType.Items.AddRange(new object[] { "deposit", "withdrw" });
            DdTranxType.Location = new Point(241, 78);
            DdTranxType.Name = "DdTranxType";
            DdTranxType.Size = new Size(153, 33);
            DdTranxType.TabIndex = 1;
            DdTranxType.SelectedValueChanged += EnableCreate;
            // 
            // DdAccId
            // 
            DdAccId.DropDownStyle = ComboBoxStyle.DropDownList;
            DdAccId.FormattingEnabled = true;
            DdAccId.Location = new Point(241, 34);
            DdAccId.Name = "DdAccId";
            DdAccId.Size = new Size(153, 33);
            DdAccId.TabIndex = 0;
            DdAccId.SelectedValueChanged += EnableCreate;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 231);
            Controls.Add(DdAccId);
            Controls.Add(DdTranxType);
            Controls.Add(TxtTranxAmt);
            Controls.Add(BtnCancel);
            Controls.Add(BtnCreateTranx);
            Controls.Add(LblTranxAmt);
            Controls.Add(LblTranxType);
            Controls.Add(LblAccId);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "New Transaction";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAccId;
        private Label LblTranxType;
        private Label LblTranxAmt;
        private Button BtnCreateTranx;
        private Button BtnCancel;
        private TextBox TxtTranxAmt;
        private ComboBox DdTranxType;
        private ComboBox DdAccId;
    }
}