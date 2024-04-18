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

        // Populate dropdown with account IDs that have made a transaction
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
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Create new deposit or withdrawal record
        private void BtnCreateTranx_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = """
                    INSERT INTO tranx (accid, action, amnt, event) 
                    VALUES (@accid, @action, @amnt, @event);
                    """;
                Command.Parameters.AddWithValue("accid", DdAccId.Text);
                Command.Parameters.AddWithValue("action", DdTranxType.Text);
                Command.Parameters.AddWithValue("amnt", TxtTranxAmt.Text);
                Command.Parameters.AddWithValue("event", DateTime.Now.ToString("yyyy:MM:dd HH:mm"));

                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " transaction(s) added.", "New Transaction");
                Connection.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Close the form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Only allow numerics and only one decimal point
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

        // Allow user to create transaction only when all fields are populated
        private void EnableCreate(object sender, EventArgs e)
        {
            if (DdAccId.Text != "" && TxtTranxAmt.Text != "" && DdTranxType.Text != "")
            {
                BtnCreateTranx.Enabled = true;
            } else
            {
                BtnCreateTranx.Enabled = false;
            }
        }
    }
}
