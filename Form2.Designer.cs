namespace Bandits
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            TabControl = new TabControl();
            TabNewCustomer = new TabPage();
            TxtNewDob = new DateTimePicker();
            BtnAddRecord = new Button();
            TxtNewFirstName = new TextBox();
            TxtNewLastName = new TextBox();
            TxtNewNi = new TextBox();
            TxtNewEmail = new TextBox();
            TxtNewPassword = new TextBox();
            TxtNewAllowance = new TextBox();
            TxtNewTitle = new TextBox();
            LblNewAllowance = new Label();
            LblNewPassword = new Label();
            LblNewEmail = new Label();
            LblNewNi = new Label();
            LblNewDob = new Label();
            LblNewLastName = new Label();
            LblFirstName = new Label();
            LblNewTitle = new Label();
            TabModifyCustomer = new TabPage();
            TxtModDob = new DateTimePicker();
            BtnModify = new Button();
            TxtModID = new TextBox();
            LblModId = new Label();
            TxtModFirstName = new TextBox();
            TxtModLastName = new TextBox();
            TxtModNi = new TextBox();
            TxtModEmail = new TextBox();
            TxtModPassword = new TextBox();
            TxtModAllowance = new TextBox();
            TxtModTitle = new TextBox();
            LblModAllowance = new Label();
            LblModPassword = new Label();
            LblModEmail = new Label();
            LblModNi = new Label();
            LblModDob = new Label();
            LblModLastName = new Label();
            LblModFirstName = new Label();
            LblModTitle = new Label();
            TabDeleteCustomer = new TabPage();
            BtnDelete = new Button();
            TxtDelCustId = new TextBox();
            LblDelCustId = new Label();
            BtnCancel = new Button();
            TabControl.SuspendLayout();
            TabNewCustomer.SuspendLayout();
            TabModifyCustomer.SuspendLayout();
            TabDeleteCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabNewCustomer);
            TabControl.Controls.Add(TabModifyCustomer);
            TabControl.Controls.Add(TabDeleteCustomer);
            TabControl.Location = new Point(4, 1);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(428, 495);
            TabControl.TabIndex = 0;
            // 
            // TabNewCustomer
            // 
            TabNewCustomer.Controls.Add(TxtNewDob);
            TabNewCustomer.Controls.Add(BtnAddRecord);
            TabNewCustomer.Controls.Add(TxtNewFirstName);
            TabNewCustomer.Controls.Add(TxtNewLastName);
            TabNewCustomer.Controls.Add(TxtNewNi);
            TabNewCustomer.Controls.Add(TxtNewEmail);
            TabNewCustomer.Controls.Add(TxtNewPassword);
            TabNewCustomer.Controls.Add(TxtNewAllowance);
            TabNewCustomer.Controls.Add(TxtNewTitle);
            TabNewCustomer.Controls.Add(LblNewAllowance);
            TabNewCustomer.Controls.Add(LblNewPassword);
            TabNewCustomer.Controls.Add(LblNewEmail);
            TabNewCustomer.Controls.Add(LblNewNi);
            TabNewCustomer.Controls.Add(LblNewDob);
            TabNewCustomer.Controls.Add(LblNewLastName);
            TabNewCustomer.Controls.Add(LblFirstName);
            TabNewCustomer.Controls.Add(LblNewTitle);
            TabNewCustomer.Location = new Point(4, 34);
            TabNewCustomer.Name = "TabNewCustomer";
            TabNewCustomer.Padding = new Padding(3);
            TabNewCustomer.Size = new Size(420, 457);
            TabNewCustomer.TabIndex = 0;
            TabNewCustomer.Text = "New Customer";
            TabNewCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtNewDob
            // 
            TxtNewDob.CustomFormat = "yyyy-MM-dd";
            TxtNewDob.Format = DateTimePickerFormat.Custom;
            TxtNewDob.Location = new Point(196, 135);
            TxtNewDob.Name = "TxtNewDob";
            TxtNewDob.Size = new Size(150, 31);
            TxtNewDob.TabIndex = 9;
            TxtNewDob.Value = new DateTime(2024, 4, 14, 0, 0, 0, 0);
            // 
            // BtnAddRecord
            // 
            BtnAddRecord.Location = new Point(8, 417);
            BtnAddRecord.Name = "BtnAddRecord";
            BtnAddRecord.Size = new Size(128, 34);
            BtnAddRecord.TabIndex = 8;
            BtnAddRecord.Text = "Add Record";
            BtnAddRecord.UseVisualStyleBackColor = true;
            BtnAddRecord.Click += BtnAddRecord_Click;
            // 
            // TxtNewFirstName
            // 
            TxtNewFirstName.Location = new Point(196, 55);
            TxtNewFirstName.Name = "TxtNewFirstName";
            TxtNewFirstName.Size = new Size(150, 31);
            TxtNewFirstName.TabIndex = 1;
            // 
            // TxtNewLastName
            // 
            TxtNewLastName.Location = new Point(196, 92);
            TxtNewLastName.Name = "TxtNewLastName";
            TxtNewLastName.Size = new Size(150, 31);
            TxtNewLastName.TabIndex = 2;
            // 
            // TxtNewNi
            // 
            TxtNewNi.Location = new Point(196, 172);
            TxtNewNi.MaxLength = 9;
            TxtNewNi.Name = "TxtNewNi";
            TxtNewNi.Size = new Size(150, 31);
            TxtNewNi.TabIndex = 4;
            // 
            // TxtNewEmail
            // 
            TxtNewEmail.Location = new Point(196, 211);
            TxtNewEmail.Name = "TxtNewEmail";
            TxtNewEmail.Size = new Size(150, 31);
            TxtNewEmail.TabIndex = 5;
            // 
            // TxtNewPassword
            // 
            TxtNewPassword.Location = new Point(196, 250);
            TxtNewPassword.Name = "TxtNewPassword";
            TxtNewPassword.Size = new Size(150, 31);
            TxtNewPassword.TabIndex = 6;
            // 
            // TxtNewAllowance
            // 
            TxtNewAllowance.Location = new Point(196, 291);
            TxtNewAllowance.Name = "TxtNewAllowance";
            TxtNewAllowance.Size = new Size(150, 31);
            TxtNewAllowance.TabIndex = 7;
            // 
            // TxtNewTitle
            // 
            TxtNewTitle.Location = new Point(196, 18);
            TxtNewTitle.Name = "TxtNewTitle";
            TxtNewTitle.Size = new Size(150, 31);
            TxtNewTitle.TabIndex = 0;
            // 
            // LblNewAllowance
            // 
            LblNewAllowance.AutoSize = true;
            LblNewAllowance.Location = new Point(8, 291);
            LblNewAllowance.Name = "LblNewAllowance";
            LblNewAllowance.Size = new Size(92, 25);
            LblNewAllowance.TabIndex = 7;
            LblNewAllowance.Text = "Allowance";
            // 
            // LblNewPassword
            // 
            LblNewPassword.AutoSize = true;
            LblNewPassword.Location = new Point(8, 250);
            LblNewPassword.Name = "LblNewPassword";
            LblNewPassword.Size = new Size(87, 25);
            LblNewPassword.TabIndex = 6;
            LblNewPassword.Text = "Password";
            // 
            // LblNewEmail
            // 
            LblNewEmail.AutoSize = true;
            LblNewEmail.Location = new Point(8, 211);
            LblNewEmail.Name = "LblNewEmail";
            LblNewEmail.Size = new Size(124, 25);
            LblNewEmail.TabIndex = 5;
            LblNewEmail.Text = "Email Address";
            // 
            // LblNewNi
            // 
            LblNewNi.AutoSize = true;
            LblNewNi.Location = new Point(8, 172);
            LblNewNi.Name = "LblNewNi";
            LblNewNi.Size = new Size(77, 25);
            LblNewNi.TabIndex = 4;
            LblNewNi.Text = "NI Code";
            // 
            // LblNewDob
            // 
            LblNewDob.AutoSize = true;
            LblNewDob.Location = new Point(8, 135);
            LblNewDob.Name = "LblNewDob";
            LblNewDob.Size = new Size(112, 25);
            LblNewDob.TabIndex = 3;
            LblNewDob.Text = "Date of Birth";
            // 
            // LblNewLastName
            // 
            LblNewLastName.AutoSize = true;
            LblNewLastName.Location = new Point(8, 92);
            LblNewLastName.Name = "LblNewLastName";
            LblNewLastName.Size = new Size(95, 25);
            LblNewLastName.TabIndex = 2;
            LblNewLastName.Text = "Last Name";
            // 
            // LblFirstName
            // 
            LblFirstName.AutoSize = true;
            LblFirstName.Location = new Point(8, 53);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(97, 25);
            LblFirstName.TabIndex = 1;
            LblFirstName.Text = "First Name";
            // 
            // LblNewTitle
            // 
            LblNewTitle.AutoSize = true;
            LblNewTitle.Location = new Point(8, 18);
            LblNewTitle.Name = "LblNewTitle";
            LblNewTitle.Size = new Size(44, 25);
            LblNewTitle.TabIndex = 0;
            LblNewTitle.Text = "Title";
            // 
            // TabModifyCustomer
            // 
            TabModifyCustomer.Controls.Add(TxtModDob);
            TabModifyCustomer.Controls.Add(BtnModify);
            TabModifyCustomer.Controls.Add(TxtModID);
            TabModifyCustomer.Controls.Add(LblModId);
            TabModifyCustomer.Controls.Add(TxtModFirstName);
            TabModifyCustomer.Controls.Add(TxtModLastName);
            TabModifyCustomer.Controls.Add(TxtModNi);
            TabModifyCustomer.Controls.Add(TxtModEmail);
            TabModifyCustomer.Controls.Add(TxtModPassword);
            TabModifyCustomer.Controls.Add(TxtModAllowance);
            TabModifyCustomer.Controls.Add(TxtModTitle);
            TabModifyCustomer.Controls.Add(LblModAllowance);
            TabModifyCustomer.Controls.Add(LblModPassword);
            TabModifyCustomer.Controls.Add(LblModEmail);
            TabModifyCustomer.Controls.Add(LblModNi);
            TabModifyCustomer.Controls.Add(LblModDob);
            TabModifyCustomer.Controls.Add(LblModLastName);
            TabModifyCustomer.Controls.Add(LblModFirstName);
            TabModifyCustomer.Controls.Add(LblModTitle);
            TabModifyCustomer.Location = new Point(4, 34);
            TabModifyCustomer.Name = "TabModifyCustomer";
            TabModifyCustomer.Padding = new Padding(3);
            TabModifyCustomer.Size = new Size(420, 457);
            TabModifyCustomer.TabIndex = 1;
            TabModifyCustomer.Text = "Modify Customer";
            TabModifyCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtModDob
            // 
            TxtModDob.CustomFormat = " ";
            TxtModDob.Format = DateTimePickerFormat.Custom;
            TxtModDob.Location = new Point(203, 196);
            TxtModDob.Name = "TxtModDob";
            TxtModDob.Size = new Size(150, 31);
            TxtModDob.TabIndex = 33;
            TxtModDob.Value = new DateTime(2024, 4, 14, 2, 3, 49, 0);
            // 
            // BtnModify
            // 
            BtnModify.Location = new Point(15, 417);
            BtnModify.Name = "BtnModify";
            BtnModify.Size = new Size(142, 34);
            BtnModify.TabIndex = 9;
            BtnModify.Text = "Modify Record";
            BtnModify.UseVisualStyleBackColor = true;
            BtnModify.Click += BtnModify_Click;
            // 
            // TxtModID
            // 
            TxtModID.Location = new Point(203, 23);
            TxtModID.Name = "TxtModID";
            TxtModID.Size = new Size(150, 31);
            TxtModID.TabIndex = 0;
            // 
            // LblModId
            // 
            LblModId.AutoSize = true;
            LblModId.Location = new Point(15, 23);
            LblModId.Name = "LblModId";
            LblModId.Size = new Size(112, 25);
            LblModId.TabIndex = 32;
            LblModId.Text = "Customer ID";
            // 
            // TxtModFirstName
            // 
            TxtModFirstName.Location = new Point(203, 116);
            TxtModFirstName.Name = "TxtModFirstName";
            TxtModFirstName.Size = new Size(150, 31);
            TxtModFirstName.TabIndex = 2;
            // 
            // TxtModLastName
            // 
            TxtModLastName.Location = new Point(203, 153);
            TxtModLastName.Name = "TxtModLastName";
            TxtModLastName.Size = new Size(150, 31);
            TxtModLastName.TabIndex = 3;
            // 
            // TxtModNi
            // 
            TxtModNi.Location = new Point(203, 233);
            TxtModNi.Name = "TxtModNi";
            TxtModNi.Size = new Size(150, 31);
            TxtModNi.TabIndex = 5;
            // 
            // TxtModEmail
            // 
            TxtModEmail.Location = new Point(203, 272);
            TxtModEmail.Name = "TxtModEmail";
            TxtModEmail.Size = new Size(150, 31);
            TxtModEmail.TabIndex = 6;
            // 
            // TxtModPassword
            // 
            TxtModPassword.Location = new Point(203, 311);
            TxtModPassword.Name = "TxtModPassword";
            TxtModPassword.Size = new Size(150, 31);
            TxtModPassword.TabIndex = 7;
            // 
            // TxtModAllowance
            // 
            TxtModAllowance.Location = new Point(203, 352);
            TxtModAllowance.Name = "TxtModAllowance";
            TxtModAllowance.Size = new Size(150, 31);
            TxtModAllowance.TabIndex = 8;
            // 
            // TxtModTitle
            // 
            TxtModTitle.Location = new Point(203, 79);
            TxtModTitle.Name = "TxtModTitle";
            TxtModTitle.Size = new Size(150, 31);
            TxtModTitle.TabIndex = 1;
            // 
            // LblModAllowance
            // 
            LblModAllowance.AutoSize = true;
            LblModAllowance.Location = new Point(15, 352);
            LblModAllowance.Name = "LblModAllowance";
            LblModAllowance.Size = new Size(92, 25);
            LblModAllowance.TabIndex = 23;
            LblModAllowance.Text = "Allowance";
            // 
            // LblModPassword
            // 
            LblModPassword.AutoSize = true;
            LblModPassword.Location = new Point(15, 311);
            LblModPassword.Name = "LblModPassword";
            LblModPassword.Size = new Size(87, 25);
            LblModPassword.TabIndex = 22;
            LblModPassword.Text = "Password";
            // 
            // LblModEmail
            // 
            LblModEmail.AutoSize = true;
            LblModEmail.Location = new Point(15, 272);
            LblModEmail.Name = "LblModEmail";
            LblModEmail.Size = new Size(124, 25);
            LblModEmail.TabIndex = 21;
            LblModEmail.Text = "Email Address";
            // 
            // LblModNi
            // 
            LblModNi.AutoSize = true;
            LblModNi.Location = new Point(15, 233);
            LblModNi.Name = "LblModNi";
            LblModNi.Size = new Size(77, 25);
            LblModNi.TabIndex = 20;
            LblModNi.Text = "NI Code";
            // 
            // LblModDob
            // 
            LblModDob.AutoSize = true;
            LblModDob.Location = new Point(15, 196);
            LblModDob.Name = "LblModDob";
            LblModDob.Size = new Size(112, 25);
            LblModDob.TabIndex = 19;
            LblModDob.Text = "Date of Birth";
            // 
            // LblModLastName
            // 
            LblModLastName.AutoSize = true;
            LblModLastName.Location = new Point(15, 153);
            LblModLastName.Name = "LblModLastName";
            LblModLastName.Size = new Size(95, 25);
            LblModLastName.TabIndex = 18;
            LblModLastName.Text = "Last Name";
            // 
            // LblModFirstName
            // 
            LblModFirstName.AutoSize = true;
            LblModFirstName.Location = new Point(15, 114);
            LblModFirstName.Name = "LblModFirstName";
            LblModFirstName.Size = new Size(97, 25);
            LblModFirstName.TabIndex = 17;
            LblModFirstName.Text = "First Name";
            // 
            // LblModTitle
            // 
            LblModTitle.AutoSize = true;
            LblModTitle.Location = new Point(15, 79);
            LblModTitle.Name = "LblModTitle";
            LblModTitle.Size = new Size(44, 25);
            LblModTitle.TabIndex = 16;
            LblModTitle.Text = "Title";
            // 
            // TabDeleteCustomer
            // 
            TabDeleteCustomer.Controls.Add(BtnDelete);
            TabDeleteCustomer.Controls.Add(TxtDelCustId);
            TabDeleteCustomer.Controls.Add(LblDelCustId);
            TabDeleteCustomer.Location = new Point(4, 34);
            TabDeleteCustomer.Name = "TabDeleteCustomer";
            TabDeleteCustomer.Padding = new Padding(3);
            TabDeleteCustomer.Size = new Size(420, 457);
            TabDeleteCustomer.TabIndex = 2;
            TabDeleteCustomer.Text = "Delete Customer";
            TabDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(12, 87);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(154, 34);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete Customer";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // TxtDelCustId
            // 
            TxtDelCustId.Location = new Point(145, 13);
            TxtDelCustId.Name = "TxtDelCustId";
            TxtDelCustId.Size = new Size(150, 31);
            TxtDelCustId.TabIndex = 0;
            // 
            // LblDelCustId
            // 
            LblDelCustId.AutoSize = true;
            LblDelCustId.Location = new Point(11, 19);
            LblDelCustId.Name = "LblDelCustId";
            LblDelCustId.Size = new Size(112, 25);
            LblDelCustId.TabIndex = 0;
            LblDelCustId.Text = "Customer ID";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(300, 502);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(128, 34);
            BtnCancel.TabIndex = 999;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 548);
            Controls.Add(BtnCancel);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Modify Customer Details";
            TabControl.ResumeLayout(false);
            TabNewCustomer.ResumeLayout(false);
            TabNewCustomer.PerformLayout();
            TabModifyCustomer.ResumeLayout(false);
            TabModifyCustomer.PerformLayout();
            TabDeleteCustomer.ResumeLayout(false);
            TabDeleteCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabNewCustomer;
        private TabPage TabModifyCustomer;
        private Label LblNewTitle;
        private TabPage TabDeleteCustomer;
        private Label LblNewLastName;
        private Label LblFirstName;
        private TextBox TxtNewFirstName;
        private TextBox TxtNewLastName;
        private DateTimePicker TxtNewDob;
        private TextBox TxtNewNi;
        private TextBox TxtNewEmail;
        private TextBox TxtNewPassword;
        private TextBox TxtNewAllowance;
        private TextBox TxtNewTitle;
        private Label LblNewAllowance;
        private Label LblNewPassword;
        private Label LblNewEmail;
        private Label LblNewNi;
        private Label LblNewDob;
        private Button BtnCancel;
        private Button BtnAddRecord;
        private Button BtnDelete;
        private TextBox TxtDelCustId;
        private Label LblDelCustId;
        private TextBox TxtModID;
        private Label LblModId;
        private TextBox TxtModFirstName;
        private TextBox TxtModLastName;
        private TextBox TxtModNi;
        private TextBox TxtModEmail;
        private TextBox TxtModPassword;
        private TextBox TxtModAllowance;
        private TextBox TxtModTitle;
        private Label LblModAllowance;
        private Label LblModPassword;
        private Label LblModEmail;
        private Label LblModNi;
        private Label LblModDob;
        private Label LblModLastName;
        private Label LblModFirstName;
        private Label LblModTitle;
        private Button BtnModify;
        private DateTimePicker TxtModDob;
    }
}