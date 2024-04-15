using System.Data.SQLite;

namespace Bandits
{
    public partial class Form3 : Form
    {
        public Form3(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
        }

        readonly string ConnectionString;

        // Adds a new product to the database; product status is open by default
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"INSERT INTO product (isaname, status, intrate) VALUES (@isaname, @status, @intrate)";
                Command.Parameters.AddWithValue("isaname", TxtNewProdName.Text);
                Command.Parameters.AddWithValue("status", DdStatus.Text);
                Command.Parameters.AddWithValue("intrate", TxtNewIntRate.Text);

                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " product(s) added.", "Modify Product");
                Connection.Close();
                TxtNewProdName.Text = string.Empty;
                TxtNewIntRate.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*
         * Modifies existing product's values if corresponding
         * values in text boxes are not blank
         */
        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                // If value's text box is not blank, update value, else leave it alone
                Command.CommandText = @"UPDATE product " +
                                " SET isaname = CASE WHEN COALESCE(@isaname, '') = '' THEN isaname ELSE @isaname END," +
                                " status = CASE WHEN COALESCE(@status, '') = '' THEN status ELSE @status END," +
                                " intrate = CASE WHEN COALESCE(@intrate, '') = '' THEN intrate ELSE @intrate END" +
                                " where prodid = @id";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(TxtModId.Text));
                Command.Parameters.AddWithValue("isaname", TxtModProdName.Text);
                Command.Parameters.AddWithValue("status", DdModStatus.Text);
                Command.Parameters.AddWithValue("intrate", TxtModIntRate.Text);
                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged.ToString() + " product(s) modified.", "Modify Product");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Deletes a product entry by ID
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"DELETE FROM product WHERE prodid = @id";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(TxtDelProdId.Text));
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully.", "Modify Product");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
