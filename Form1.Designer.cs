namespace Bandits
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            MenuConnectTo = new ToolStripMenuItem();
            MenuDisconnect = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuExit = new ToolStripMenuItem();
            MenuEdit = new ToolStripMenuItem();
            MenuModifyDetails = new ToolStripMenuItem();
            MenuModifyProduct = new ToolStripMenuItem();
            MenuNewTranx = new ToolStripMenuItem();
            MenuView = new ToolStripMenuItem();
            MenuTotalTranx = new ToolStripMenuItem();
            MenuMVC = new ToolStripMenuItem();
            TranxByCustomer = new ToolStripMenuItem();
            MenuRun = new ToolStripMenuItem();
            MenuInterestCalc = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            ToolStrip = new ToolStrip();
            TsBtnConnectTo = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsBtnDisconnect = new ToolStripButton();
            StatusStrip = new StatusStrip();
            ConnectionStatus = new ToolStripStatusLabel();
            leeVanCleef = new PictureBox();
            label1 = new Label();
            bulletholes = new PictureBox();
            menuStrip1.SuspendLayout();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leeVanCleef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulletholes).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, MenuEdit, MenuView, MenuRun });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuConnectTo, MenuDisconnect, toolStripSeparator1, MenuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // MenuConnectTo
            // 
            MenuConnectTo.Name = "MenuConnectTo";
            MenuConnectTo.Size = new Size(213, 34);
            MenuConnectTo.Text = "Connect to...";
            MenuConnectTo.Click += MenuConnectTo_Click;
            // 
            // MenuDisconnect
            // 
            MenuDisconnect.Enabled = false;
            MenuDisconnect.Name = "MenuDisconnect";
            MenuDisconnect.Overflow = ToolStripItemOverflow.Always;
            MenuDisconnect.Size = new Size(213, 34);
            MenuDisconnect.Text = "Disconnect";
            MenuDisconnect.Click += MenuDisconnect_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(213, 34);
            MenuExit.Text = "Exit";
            MenuExit.Click += MenuExit_Click;
            // 
            // MenuEdit
            // 
            MenuEdit.DropDownItems.AddRange(new ToolStripItem[] { MenuModifyDetails, MenuModifyProduct, MenuNewTranx });
            MenuEdit.Enabled = false;
            MenuEdit.Name = "MenuEdit";
            MenuEdit.Size = new Size(58, 29);
            MenuEdit.Text = "Edit";
            // 
            // MenuModifyDetails
            // 
            MenuModifyDetails.DoubleClickEnabled = true;
            MenuModifyDetails.Name = "MenuModifyDetails";
            MenuModifyDetails.Size = new Size(330, 34);
            MenuModifyDetails.Text = "Manage Customer Details...";
            MenuModifyDetails.Click += MenuModifyDetails_Click;
            // 
            // MenuModifyProduct
            // 
            MenuModifyProduct.Name = "MenuModifyProduct";
            MenuModifyProduct.Size = new Size(330, 34);
            MenuModifyProduct.Text = "Manage Products...";
            MenuModifyProduct.Click += MenuModifyProduct_Click;
            // 
            // MenuNewTranx
            // 
            MenuNewTranx.Name = "MenuNewTranx";
            MenuNewTranx.Size = new Size(330, 34);
            MenuNewTranx.Text = "New Transaction...";
            MenuNewTranx.Click += MenuNewTranx_Click;
            // 
            // MenuView
            // 
            MenuView.DropDownItems.AddRange(new ToolStripItem[] { MenuTotalTranx, MenuMVC, TranxByCustomer });
            MenuView.Enabled = false;
            MenuView.Name = "MenuView";
            MenuView.Size = new Size(65, 29);
            MenuView.Text = "View";
            // 
            // MenuTotalTranx
            // 
            MenuTotalTranx.Name = "MenuTotalTranx";
            MenuTotalTranx.Size = new Size(342, 34);
            MenuTotalTranx.Text = "Total Deposits/Withdrawals...";
            MenuTotalTranx.Click += MenuTotalTranx_Click;
            // 
            // MenuMVC
            // 
            MenuMVC.Name = "MenuMVC";
            MenuMVC.Size = new Size(342, 34);
            MenuMVC.Text = "Most Valuable Customer...";
            MenuMVC.Click += MenuMVC_Click;
            // 
            // TranxByCustomer
            // 
            TranxByCustomer.Name = "TranxByCustomer";
            TranxByCustomer.Size = new Size(342, 34);
            TranxByCustomer.Text = "Transactions by Customer...";
            TranxByCustomer.Click += TranxByCustomer_Click;
            // 
            // MenuRun
            // 
            MenuRun.DropDownItems.AddRange(new ToolStripItem[] { MenuInterestCalc });
            MenuRun.Enabled = false;
            MenuRun.Name = "MenuRun";
            MenuRun.Size = new Size(59, 29);
            MenuRun.Text = "Run";
            // 
            // MenuInterestCalc
            // 
            MenuInterestCalc.Name = "MenuInterestCalc";
            MenuInterestCalc.Size = new Size(270, 34);
            MenuInterestCalc.Text = "Interest Calculation";
            MenuInterestCalc.Click += MenuInterestCalc_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { TsBtnConnectTo, toolStripSeparator2, TsBtnDisconnect });
            ToolStrip.Location = new Point(0, 33);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 33);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "ToolStrip";
            // 
            // TsBtnConnectTo
            // 
            TsBtnConnectTo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsBtnConnectTo.Image = Properties.Resources.link;
            TsBtnConnectTo.ImageTransparentColor = Color.Magenta;
            TsBtnConnectTo.Name = "TsBtnConnectTo";
            TsBtnConnectTo.Size = new Size(34, 28);
            TsBtnConnectTo.Text = "Connect To...";
            TsBtnConnectTo.Click += TsBtnConnectTo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 33);
            // 
            // TsBtnDisconnect
            // 
            TsBtnDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsBtnDisconnect.Enabled = false;
            TsBtnDisconnect.Image = Properties.Resources.unlink;
            TsBtnDisconnect.ImageTransparentColor = Color.Magenta;
            TsBtnDisconnect.Name = "TsBtnDisconnect";
            TsBtnDisconnect.Size = new Size(34, 28);
            TsBtnDisconnect.Text = "Disconnect";
            TsBtnDisconnect.Click += TsDisconnect_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(24, 24);
            StatusStrip.Items.AddRange(new ToolStripItem[] { ConnectionStatus });
            StatusStrip.Location = new Point(0, 418);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 32);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "StatusStrip";
            // 
            // ConnectionStatus
            // 
            ConnectionStatus.Image = Properties.Resources.unlink;
            ConnectionStatus.Name = "ConnectionStatus";
            ConnectionStatus.Size = new Size(143, 25);
            ConnectionStatus.Text = "Disconnected";
            // 
            // leeVanCleef
            // 
            leeVanCleef.Image = Properties.Resources.lvc2;
            leeVanCleef.Location = new Point(12, 69);
            leeVanCleef.Name = "leeVanCleef";
            leeVanCleef.Size = new Size(236, 346);
            leeVanCleef.SizeMode = PictureBoxSizeMode.StretchImage;
            leeVanCleef.TabIndex = 3;
            leeVanCleef.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 24F);
            label1.Location = new Point(322, 132);
            label1.Name = "label1";
            label1.Size = new Size(410, 162);
            label1.TabIndex = 4;
            label1.Text = "Welcome to the\r\nBank of\r\nOutlaw Hess";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // bulletholes
            // 
            bulletholes.Image = Properties.Resources.bulletholes;
            bulletholes.Location = new Point(254, 286);
            bulletholes.Name = "bulletholes";
            bulletholes.Size = new Size(128, 129);
            bulletholes.SizeMode = PictureBoxSizeMode.StretchImage;
            bulletholes.TabIndex = 5;
            bulletholes.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bulletholes);
            Controls.Add(label1);
            Controls.Add(leeVanCleef);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Bank of Outlaw Hess";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)leeVanCleef).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulletholes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuEdit;
        private ToolStripMenuItem MenuView;
        private OpenFileDialog openFileDialog1;
        private ToolStrip ToolStrip;
        private ToolStripButton TsBtnConnectTo;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel ConnectionStatus;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem MenuConnectTo;
        private ToolStripMenuItem MenuExit;
        private ToolStripMenuItem MenuDisconnect;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox leeVanCleef;
        private ToolStripButton TsBtnDisconnect;
        private Label label1;
        private ToolStripMenuItem MenuModifyDetails;
        private ToolStripMenuItem MenuModifyProduct;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem MenuNewTranx;
        private ToolStripMenuItem MenuTotalTranx;
        private ToolStripMenuItem MenuMVC;
        private ToolStripMenuItem MenuRun;
        private ToolStripMenuItem MenuInterestCalc;
        private PictureBox bulletholes;
        private ToolStripMenuItem TranxByCustomer;
    }
}
