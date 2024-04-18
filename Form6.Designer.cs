namespace Bandits
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            ListMVC = new ListView();
            BtnOK = new Button();
            SuspendLayout();
            // 
            // ListMVC
            // 
            ListMVC.Location = new Point(12, 53);
            ListMVC.Name = "ListMVC";
            ListMVC.Size = new Size(415, 266);
            ListMVC.TabIndex = 0;
            ListMVC.UseCompatibleStateImageBehavior = false;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(164, 340);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(112, 34);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 386);
            Controls.Add(BtnOK);
            Controls.Add(ListMVC);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Most Valuable Customer";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView ListMVC;
        private Button BtnOK;
    }
}