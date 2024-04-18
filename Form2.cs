using System.Data.SQLite;

namespace Bandits
{
    public partial class Form2 : Form
    {
        public Form2(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
        }

        readonly string ConnectionString;

        // Adds new customer record to database
        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"INSERT INTO customer(
                    title, firstname, lastname, dob, nicode, email, password, allowance
                ) VALUES (
                    @title, @firstname, @lastname, @dob, @nicode, @email, @password, @allowance);";
                Command.Parameters.AddWithValue("title", TxtNewTitle.Text);
                Command.Parameters.AddWithValue("firstname", TxtNewFirstName.Text);
                Command.Parameters.AddWithValue("lastname", TxtNewLastName.Text);
                Command.Parameters.AddWithValue("dob", TxtNewDob.Text);
                Command.Parameters.AddWithValue("nicode", TxtNewNi.Text);
                Command.Parameters.AddWithValue("email", TxtNewEmail.Text);
                Command.Parameters.AddWithValue("password", TxtNewPassword.Text);
                Command.Parameters.AddWithValue("allowance", TxtNewAllowance.Text);
                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " record(s) added", "Modify Customer Details");
                Connection.Close();
                TxtNewTitle.Text = string.Empty;
                TxtNewFirstName.Text = string.Empty;
                TxtNewLastName.Text = string.Empty;
                TxtNewDob.Text = string.Empty;
                TxtNewNi.Text = string.Empty;
                TxtNewEmail.Text = string.Empty;
                TxtNewPassword.Text = string.Empty;
                TxtNewAllowance.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*
         * Modifies an existing record's values if 
         * corresponding values entered in the
         * text boxes are not blank, otherwise leaves those
         * values alone when command is executed.
         */
        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();

                // If there is text in the text box, update the value, else leave it alone
                Command.CommandText = @"UPDATE customer " +
                                " SET title = CASE WHEN COALESCE(@title, '') = '' THEN title ELSE @title END," +
                                " firstname = CASE WHEN COALESCE(@firstname, '') = '' THEN firstname ELSE @firstname END," +
                                " lastname = CASE WHEN COALESCE(@lastname, '') = '' THEN lastname ELSE @lastname END," +
                                " dob = CASE WHEN COALESCE(@dob, '') = '' THEN dob ELSE @dob END," +
                                " nicode = CASE WHEN COALESCE(@nicode, '') = '' THEN nicode ELSE @nicode END," +
                                " email = CASE WHEN COALESCE(@email, '') = '' THEN email ELSE @email END," +
                                " password = CASE WHEN COALESCE(@password, '') = '' THEN password ELSE @password END," +
                                " allowance = CASE WHEN COALESCE(@allowance, '') = '' THEN allowance ELSE @allowance END" +
                                " where custid = @id;";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(DdModId.Text));
                Command.Parameters.AddWithValue("title", TxtModTitle.Text);
                Command.Parameters.AddWithValue("firstname", TxtModFirstName.Text);
                Command.Parameters.AddWithValue("lastname", TxtModLastName.Text);
                Command.Parameters.AddWithValue("dob", TxtModDob.Text);
                Command.Parameters.AddWithValue("nicode", TxtModNi.Text);
                Command.Parameters.AddWithValue("email", TxtModEmail.Text);
                Command.Parameters.AddWithValue("password", TxtModPassword.Text);
                Command.Parameters.AddWithValue("allowance", TxtModAllowance.Text);
                Connection.Open();
                int recordsChanged = Command.ExecuteNonQuery();
                MessageBox.Show(recordsChanged + " record(s) modified", "Modify Customer Details");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Deletes a customer record by ID
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"DELETE FROM customer WHERE custid = @id;";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(TxtDelCustId.Text));
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.", "Modify Customer Details");
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

        private void TxtNewAllowance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT DISTINCT custid FROM customer ORDER BY custid;";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    DdModId.Items.Add(Reader.GetInt16(0).ToString());
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void DdModId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"SELECT dob FROM customer WHERE custid = " + DdModId.Text + ";";
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    TxtModDob.Text = Reader.GetString(0);
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}
