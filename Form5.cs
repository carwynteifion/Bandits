using System.Data.SQLite;

namespace Bandits
{
    public partial class Form5 : Form
    {
        public Form5(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
        }

        readonly string ConnectionString;

        // Add up all deposits from set date onwards and display to user
        private void BtnTotalDeposits_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = """
                    SELECT SUM(amnt) 
                    FROM tranx 
                    WHERE action = 'deposit' AND event >= '
                    """ + TranxDateTime.Text + "';";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                { 
                    TotalDepositsNo.Text = Reader.GetValue(0).ToString();
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Add up all withdrawals from set date onwards and display to user
        private void BtnTotalWithdrawals_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = """
                    SELECT SUM(amnt) 
                    FROM tranx 
                    WHERE action = 'withdrw' AND event >= '
                    """ + TranxDateTime.Text + "';";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    TotalWithdrawalsNo.Text = Reader.GetValue(0).ToString();
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
        
        // Close the form
        private void TranxOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
