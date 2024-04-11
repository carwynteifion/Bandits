namespace Bandits
{
    partial class Bandits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bandits));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            MenuConnectTo = new ToolStripMenuItem();
            MenuDisconnect = new ToolStripMenuItem();
            MenuExit = new ToolStripMenuItem();
            MenuEdit = new ToolStripMenuItem();
            MenuView = new ToolStripMenuItem();
            MenuHelp = new ToolStripMenuItem();
            MenuAbout = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            ToolStrip = new ToolStrip();
            TsBtnConnectTo = new ToolStripButton();
            StatusStrip = new StatusStrip();
            ConnectionStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuConnectTo, MenuDisconnect, MenuExit });
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
            // MenuExit
            // 
            MenuExit.Name = "MenuExit";
            MenuExit.Size = new Size(270, 34);
            MenuExit.Text = "Exit";
            MenuExit.Click += MenuExit_Click;
            // 
            // MenuEdit
            // 
            MenuEdit.Name = "MenuEdit";
            MenuEdit.Size = new Size(58, 29);
            MenuEdit.Text = "Edit";
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
            ToolStrip.Items.AddRange(new ToolStripItem[] { TsBtnConnectTo });
            ToolStrip.Location = new Point(0, 33);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 33);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "ToolStrip";
            // 
            // TsBtnConnectTo
            // 
            TsBtnConnectTo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TsBtnConnectTo.Image = (Image)resources.GetObject("TsBtnConnectTo.Image");
            TsBtnConnectTo.ImageTransparentColor = Color.Magenta;
            TsBtnConnectTo.Name = "TsBtnConnectTo";
            TsBtnConnectTo.Size = new Size(34, 28);
            TsBtnConnectTo.Text = "Connect To...";
            TsBtnConnectTo.Click += TsBtnConnectTo_Click;
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
            ConnectionStatus.Name = "ConnectionStatus";
            ConnectionStatus.Size = new Size(119, 25);
            ConnectionStatus.Text = "Disconnected";
            // 
            // Bandits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StatusStrip);
            Controls.Add(ToolStrip);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Bandits";
            Text = "Bandits";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
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
    }
}
