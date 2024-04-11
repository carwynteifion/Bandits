using Microsoft.VisualBasic;
using System.Data.SQLite;

namespace Bandits
{
    public partial class Bandits : Form
    {
        public Bandits()
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
            openFileDialog1.Title = "Select database file";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Database files (*.db)|*.db";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = default;
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ConnectionStatus.Text = "Disconnected";
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

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Carwyn Thomas", "About Bandits");
        }

        private void MenuDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            ConnectionStatus.Text = "Disconnected";
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

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
    }
}