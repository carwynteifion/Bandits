namespace Bandits
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            TranxDateTime = new DateTimePicker();
            label1 = new Label();
            TranxOk = new Button();
            BtnTotalDeposits = new Button();
            BtnTotalWithdrawals = new Button();
            LblDeposits = new Label();
            LblWithdrawals = new Label();
            TotalDepositsNo = new Label();
            TotalWithdrawalsNo = new Label();
            SuspendLayout();
            // 
            // TranxDateTime
            // 
            TranxDateTime.CustomFormat = "yyyy:MM:dd";
            TranxDateTime.Format = DateTimePickerFormat.Custom;
            TranxDateTime.Location = new Point(290, 9);
            TranxDateTime.Name = "TranxDateTime";
            TranxDateTime.Size = new Size(126, 31);
            TranxDateTime.TabIndex = 0;
            TranxDateTime.Value = new DateTime(2024, 4, 17, 20, 46, 43, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 28);
            label1.TabIndex = 2;
            label1.Text = "Show Transactions From Date:";
            // 
            // TranxOk
            // 
            TranxOk.Location = new Point(172, 225);
            TranxOk.Name = "TranxOk";
            TranxOk.Size = new Size(112, 34);
            TranxOk.TabIndex = 3;
            TranxOk.Text = "OK";
            TranxOk.UseVisualStyleBackColor = true;
            TranxOk.Click += TranxOk_Click;
            // 
            // BtnTotalDeposits
            // 
            BtnTotalDeposits.Location = new Point(11, 64);
            BtnTotalDeposits.Name = "BtnTotalDeposits";
            BtnTotalDeposits.Size = new Size(224, 34);
            BtnTotalDeposits.TabIndex = 1;
            BtnTotalDeposits.Text = "Show Deposits Total";
            BtnTotalDeposits.UseVisualStyleBackColor = true;
            BtnTotalDeposits.Click += BtnTotalDeposits_Click;
            // 
            // BtnTotalWithdrawals
            // 
            BtnTotalWithdrawals.Location = new Point(12, 158);
            BtnTotalWithdrawals.Name = "BtnTotalWithdrawals";
            BtnTotalWithdrawals.Size = new Size(223, 34);
            BtnTotalWithdrawals.TabIndex = 2;
            BtnTotalWithdrawals.Text = "Show Withdrawals Total";
            BtnTotalWithdrawals.UseVisualStyleBackColor = true;
            BtnTotalWithdrawals.Click += BtnTotalWithdrawals_Click;
            // 
            // LblDeposits
            // 
            LblDeposits.AutoSize = true;
            LblDeposits.Location = new Point(261, 69);
            LblDeposits.Name = "LblDeposits";
            LblDeposits.Size = new Size(128, 25);
            LblDeposits.TabIndex = 6;
            LblDeposits.Text = "Total Deposits:";
            // 
            // LblWithdrawals
            // 
            LblWithdrawals.AutoSize = true;
            LblWithdrawals.Location = new Point(261, 163);
            LblWithdrawals.Name = "LblWithdrawals";
            LblWithdrawals.Size = new Size(155, 25);
            LblWithdrawals.TabIndex = 7;
            LblWithdrawals.Text = "Total Withdrawals:";
            // 
            // TotalDepositsNo
            // 
            TotalDepositsNo.AutoSize = true;
            TotalDepositsNo.Location = new Point(273, 105);
            TotalDepositsNo.Name = "TotalDepositsNo";
            TotalDepositsNo.Size = new Size(0, 25);
            TotalDepositsNo.TabIndex = 8;
            // 
            // TotalWithdrawalsNo
            // 
            TotalWithdrawalsNo.AutoSize = true;
            TotalWithdrawalsNo.Location = new Point(273, 200);
            TotalWithdrawalsNo.Name = "TotalWithdrawalsNo";
            TotalWithdrawalsNo.Size = new Size(0, 25);
            TotalWithdrawalsNo.TabIndex = 9;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 271);
            Controls.Add(TotalWithdrawalsNo);
            Controls.Add(TotalDepositsNo);
            Controls.Add(LblWithdrawals);
            Controls.Add(LblDeposits);
            Controls.Add(BtnTotalWithdrawals);
            Controls.Add(BtnTotalDeposits);
            Controls.Add(TranxOk);
            Controls.Add(label1);
            Controls.Add(TranxDateTime);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "View Total Deposits/Withdrawals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker TranxDateTime;
        private Label label1;
        private Button TranxOk;
        private Button BtnTotalDeposits;
        private Button BtnTotalWithdrawals;
        private Label LblDeposits;
        private Label LblWithdrawals;
        private Label TotalDepositsNo;
        private Label TotalWithdrawalsNo;
    }
}