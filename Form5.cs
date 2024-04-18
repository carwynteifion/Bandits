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

        private void BtnTotalDeposits_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT SUM(amnt) FROM tranx WHERE action = 'deposit' AND event >= '" + TranxDateTime.Text + "';";
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnTotalWithdrawals_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT SUM(amnt) FROM tranx WHERE action = 'withdrw' AND event >= '" + TranxDateTime.Text + "';";
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void TranxOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
