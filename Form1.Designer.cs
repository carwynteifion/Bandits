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
            MenuView = new ToolStripMenuItem();
            MenuHelp = new ToolStripMenuItem();
            MenuAbout = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            ToolStrip = new ToolStrip();
            TsBtnConnectTo = new ToolStripButton();
            TsBtnDisconnect = new ToolStripButton();
            StatusStrip = new StatusStrip();
            ConnectionStatus = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, MenuEdit, MenuView, MenuHelp });
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
            MenuEdit.DropDownItems.AddRange(new ToolStripItem[] { MenuModifyDetails });
            MenuEdit.Name = "MenuEdit";
            MenuEdit.Size = new Size(58, 29);
            MenuEdit.Text = "Edit";
            // 
            // MenuModifyDetails
            // 
            MenuModifyDetails.DoubleClickEnabled = true;
            MenuModifyDetails.Name = "MenuModifyDetails";
            MenuModifyDetails.Size = new Size(323, 34);
            MenuModifyDetails.Text = "Modify Customer Details...";
            MenuModifyDetails.Click += MenuModifyDetails_Click;
            // 
            // MenuView
            // 
            MenuView.Name = "MenuView";
            MenuView.Size = new Size(65, 29);
            MenuView.Text = "View";
            // 
            // MenuHelp
            // 
            MenuHelp.DropDownItems.AddRange(new ToolStripItem[] { MenuAbout });
            MenuHelp.Name = "MenuHelp";
            MenuHelp.Size = new Size(65, 29);
            MenuHelp.Text = "Help";
            // 
            // MenuAbout
            // 
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Size = new Size(176, 34);
            MenuAbout.Text = "About...";
            MenuAbout.Click += MenuAbout_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { TsBtnConnectTo, TsBtnDisconnect });
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
            // TsBtnDisconnect
            // 
            TsBtnDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lvc2;
            pictureBox1.Location = new Point(12, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bandits";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuEdit;
        private ToolStripMenuItem MenuView;
        private ToolStripMenuItem MenuHelp;
        private ToolStripMenuItem MenuAbout;
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
        private PictureBox pictureBox1;
        private ToolStripButton TsBtnDisconnect;
        private Label label1;
        private ToolStripMenuItem MenuModifyDetails;
    }
}
