using System.Data.SQLite;

namespace Bandits
{
    public partial class Form2 : Form
    {
        public Form2(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
        }
        readonly string ConnectionString;

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //create a connection object to connect to the selected database
                using SQLiteConnection Connection = new(ConnectionString);
                //create a command object that uses this connection 
                using SQLiteCommand cmd = Connection.CreateCommand();
                //set up the SQL instruction using placeholders
                cmd.CommandText = @"insert into customer(
                    title, firstname, lastname, dob, nicode, email, password, allowance
                ) values (
                    @title, @firstname, @lastname, @dob, @nicode, @email, @password, @allowance)";
                //fill the placeholders with data from the UI
                cmd.Parameters.AddWithValue("title", TxtNewTitle.Text);
                cmd.Parameters.AddWithValue("firstname", TxtNewFirstName.Text);
                cmd.Parameters.AddWithValue("lastname", TxtNewLastName.Text);
                cmd.Parameters.AddWithValue("dob", TxtNewDob.Text);
                cmd.Parameters.AddWithValue("nicode", TxtNewNi.Text);
                cmd.Parameters.AddWithValue("email", TxtNewEmail.Text);
                cmd.Parameters.AddWithValue("password", TxtNewPassword.Text);
                cmd.Parameters.AddWithValue("allowance", TxtNewAllowance.Text);
                //execute the command against the database
                Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added new customer record.");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection con = new(ConnectionString);
                using SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = @"update customer set address = @addr"
                                                    + " where customerid = @id";
                cmd.Parameters.AddWithValue("addr", txtAddress2.Text);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(txtID2.Text));
                con.Open();
                int recordsChanged = cmd.ExecuteNonQuery();
                MessageBox.Show(recordsChanged.ToString() + " records modified");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }*/

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand cmd = Connection.CreateCommand();
                cmd.CommandText = @"delete from customer where custid = @id";
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(TxtDelCustId.Text));
                Connection.Open();
                int recordsChanged = cmd.ExecuteNonQuery();
                MessageBox.Show(recordsChanged.ToString() + " records deleted");
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
