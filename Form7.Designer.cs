namespace Bandits
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            BtnOK = new Button();
            ListCustTranx = new ListView();
            label1 = new Label();
            DdCustId = new ComboBox();
            SuspendLayout();
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(12, 404);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(112, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // ListCustTranx
            // 
            ListCustTranx.Location = new Point(213, 12);
            ListCustTranx.Name = "ListCustTranx";
            ListCustTranx.Size = new Size(575, 426);
            ListCustTranx.TabIndex = 2;
            ListCustTranx.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Customer ID:";
            // 
            // DdCustId
            // 
            DdCustId.DropDownStyle = ComboBoxStyle.DropDownList;
            DdCustId.FormattingEnabled = true;
            DdCustId.Location = new Point(12, 49);
            DdCustId.Name = "DdCustId";
            DdCustId.Size = new Size(167, 33);
            DdCustId.TabIndex = 0;
            DdCustId.SelectedValueChanged += DdCustId_OnValueChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DdCustId);
            Controls.Add(label1);
            Controls.Add(BtnOK);
            Controls.Add(ListCustTranx);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "View Transactions by Customer";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOK;
        private ListView ListCustTranx;
        private Label label1;
        private ComboBox DdCustId;
    }
}