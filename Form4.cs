using System.Data.SQLite;

namespace Bandits
{
    public partial class Form4 : Form
    {
        public Form4(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
        }

        readonly string ConnectionString;

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT DISTINCT accid FROM tranx ORDER BY accid;";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    DdAccId.Items.Add(Reader.GetInt16(0).ToString());
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCreateTranx_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"INSERT INTO tranx (accid, action, amnt, event) VALUES (@accid, @action, @amnt, @event);";
                Command.Parameters.AddWithValue("accid", DdAccId.Text);
                Command.Parameters.AddWithValue("action", DdTranxType.Text);
                Command.Parameters.AddWithValue("amnt", TxtTranxAmt.Text);
                Command.Parameters.AddWithValue("event", DateTime.Now.ToString("yyyy:MM:dd HH:mm"));

                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " transaction(s) added.", "New Transaction");
                Connection.Close();
                TxtTranxAmt.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "New Transaction");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtTranxAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
