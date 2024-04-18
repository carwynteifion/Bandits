using System.Data.SQLite;

namespace Bandits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // Create connection object
        readonly SQLiteConnection connection = new();

        // Set up string variable for connection details
        public string ConnectionString = string.Empty;

        private void MenuConnectTo_Click(object sender, EventArgs e)
        {
            // Opens file selection dialog box to My Documents and filter to only show .db files
            openFileDialog1.Title = "Select database file";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database files (*.db)|*.db";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = default;
            // If database has been successfully selected, connect to it
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ConnectionString = @"Data Source =" + openFileDialog1.FileName;
                try
                {
                    connection.ConnectionString = ConnectionString;
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        ConnectionStatus.Text = "Connected to: " + Path.GetFileName(openFileDialog1.FileName);
                        ConnectionStatus.Image = Properties.Resources.link;
                        MenuDisconnect.Enabled = true;
                        MenuConnectTo.Enabled = false;
                        TsBtnConnectTo.Enabled = false;
                        TsBtnDisconnect.Enabled = true;
                        MenuEdit.Enabled = true;
                        MenuView.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ConnectionStatus.Text = "Disconnected";
                    ConnectionStatus.Image = Properties.Resources.unlink;
                    MenuDisconnect.Enabled = false;
                    MenuConnectTo.Enabled = true;
                    TsBtnConnectTo.Enabled = true;
                    TsBtnDisconnect.Enabled = false;
                    MenuEdit.Enabled = false;
                    MenuView.Enabled = false;
                }
            }
            else
            {
                ConnectionString = "Data Source =";
            }
        }

        private void TsBtnConnectTo_Click(object sender, EventArgs e)
        {
            MenuConnectTo_Click(sender, e);
        }

        // Disconnect from the database
        private void MenuDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            ConnectionStatus.Text = "Disconnected";
            ConnectionStatus.Image = Properties.Resources.unlink;
            MenuDisconnect.Enabled = false;
            MenuConnectTo.Enabled = true;
            TsBtnConnectTo.Enabled = true;
            TsBtnDisconnect.Enabled = false;
            MenuEdit.Enabled = false;
            MenuView.Enabled = false;
        }

        private void TsDisconnect_Click(object sender, EventArgs e)
        {
            MenuDisconnect_Click(sender, e);
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Carwyn Thomas", "About Bandits");
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        // When close button is clicked, show "are you sure" message box
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit",
              MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                base.OnFormClosing(e);
            }
            else
            {
                e.Cancel = true;
            }
        }

        // Open Modify Customer Details
        private void MenuModifyDetails_Click(object sender, EventArgs e)
        {
            Form2 ModifyCustomer = new(ConnectionString);
            ModifyCustomer.ShowDialog();
        }

        // Open Modify Product
        private void MenuModifyProduct_Click(object sender, EventArgs e)
        {
            Form3 ModifyProduct = new(ConnectionString);
            ModifyProduct.ShowDialog();
        }

        private void MenuNewTranx_Click(object sender, EventArgs e)
        {
            Form4 NewTranx = new(ConnectionString);
            NewTranx.ShowDialog();
        }

        private void MenuTotalTranx_Click(object sender, EventArgs e)
        {
            Form5 ViewTranx = new(ConnectionString);
            ViewTranx.ShowDialog();
        }

        private void MenuMVC_Click(object sender, EventArgs e)
        {
            Form6 MostValuableCustomer = new(ConnectionString);
            MostValuableCustomer.ShowDialog();
        }
    }
}
