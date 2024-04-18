using System.Data.SQLite;

namespace Bandits
{
    // Manage Products
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
                Command.CommandText = """
                    INSERT INTO product (isaname, status, intrate) 
                    VALUES (@isaname, @status, @intrate);
                    """;
                Command.Parameters.AddWithValue("isaname", TxtNewProdName.Text);
                Command.Parameters.AddWithValue("status", DdStatus.Text);
                Command.Parameters.AddWithValue("intrate", TxtNewIntRate.Text);

                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " product(s) added.", "Manage Product");
                Connection.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
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
                                " where prodid = @id;";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(DdModId.Text));
                Command.Parameters.AddWithValue("isaname", TxtModProdName.Text);
                Command.Parameters.AddWithValue("status", DdModStatus.Text);
                Command.Parameters.AddWithValue("intrate", TxtModIntRate.Text);
                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged.ToString() + " product(s) modified.", "Manage Product");
                Connection.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Deletes a product entry by ID
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"DELETE FROM product WHERE prodid = @id;";
                Command.Parameters.AddWithValue("id", Convert.ToInt16(DdDelProdId.Text));
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Product deleted successfully.", "Manage Product");
                Connection.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Close the form
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        // On load, populate dropdowns with product IDs from the database
        private void Form3_Load(object sender, EventArgs e)
        {
            DdStatus.Text = "open";
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT DISTINCT prodid FROM product ORDER BY prodid;";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    DdModId.Items.Add(Reader.GetInt16(0).ToString());
                    DdDelProdId.Items.Add(Reader.GetInt16(0).ToString());
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Only allow numerics and no more than one decimal point
        private void TxtNewIntRate_KeyPress(object sender, KeyPressEventArgs e)
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

        // On product ID selection from dropdown, pull through product details from db
        private void DdModId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT isaname, status, intrate FROM product WHERE prodid = " + DdModId.Text + ";";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    TxtModProdName.Text = Reader.GetString(0);
                    DdModStatus.Text = Reader.GetString(1);
                    TxtModIntRate.Text = Reader.GetValue(2).ToString();
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // Enable buttons when all required fields are filled
        private void EnableAdd(object sender, EventArgs e)
        {
            if (TxtNewProdName.Text != "" &&
                DdStatus.Text != "" &&
                TxtNewIntRate.Text != "")
            {
                BtnAddProduct.Enabled = true;
            }
            else
            {
                BtnAddProduct.Enabled = false;
            }
        }

        private void EnableMod(object sender, EventArgs e)
        {
            if (DdModId.Text != "" &&
                TxtModProdName.Text != "" &&
                DdModStatus.Text != "" &&
                TxtModIntRate.Text != "")
            {
                BtnModify.Enabled = true;
            }
            else
            {
                BtnModify.Enabled = false;
            }
        }

        private void EnableDel(object sender, EventArgs e)
        {
            if (DdDelProdId.Text != "")
            {
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnDelete.Enabled = false;
            }
        }
    }
}
