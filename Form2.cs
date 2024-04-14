﻿using System.Data.SQLite;

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

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //create a connection object to connect to the selected database
                using SQLiteConnection Connection = new(ConnectionString);

                //create a command object that uses this connection 
                using SQLiteCommand Command = Connection.CreateCommand();

                //set up the SQL instruction using placeholders
                Command.CommandText = @"INSERT INTO customer(
                    title, firstname, lastname, dob, nicode, email, password, allowance
                ) VALUES (
                    @title, @firstname, @lastname, @dob, @nicode, @email, @password, @allowance)";
                //fill the placeholders with data from the UI
                Command.Parameters.AddWithValue("title", TxtNewTitle.Text);
                Command.Parameters.AddWithValue("firstname", TxtNewFirstName.Text);
                Command.Parameters.AddWithValue("lastname", TxtNewLastName.Text);
                Command.Parameters.AddWithValue("dob", TxtNewDob.Text);
                Command.Parameters.AddWithValue("nicode", TxtNewNi.Text);
                Command.Parameters.AddWithValue("email", TxtNewEmail.Text);
                Command.Parameters.AddWithValue("password", TxtNewPassword.Text);
                Command.Parameters.AddWithValue("allowance", TxtNewAllowance.Text);

                //execute the command against the database
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Successfully added new customer record.");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"UPDATE customer " +
                                " SET title = CASE WHEN COALESCE(@title, '') = '' THEN title ELSE @title END," +
                                " firstname = CASE WHEN COALESCE(@firstname, '') = '' THEN firstname ELSE @firstname END," +
                                " lastname = CASE WHEN COALESCE(@lastname, '') = '' THEN lastname ELSE @lastname END," +
                                " dob = CASE WHEN COALESCE(@dob, '') = '' THEN dob ELSE @dob END," +
                                " nicode = CASE WHEN COALESCE(@nicode, '') = '' THEN nicode ELSE @nicode END," +
                                " email = CASE WHEN COALESCE(@email, '') = '' THEN email ELSE @email END," +
                                " password = CASE WHEN COALESCE(@password, '') = '' THEN password ELSE @password END," +
                                " allowance = CASE WHEN COALESCE(@allowance, '') = '' THEN allowance ELSE @allowance END" +
                                " where custid = @id";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(TxtModID.Text));
                Command.Parameters.AddWithValue("title", TxtModTitle.Text);
                Command.Parameters.AddWithValue("firstname", TxtModFirstName.Text);
                Command.Parameters.AddWithValue("lastname", TxtModLastName.Text);
                Command.Parameters.AddWithValue("dob", TxtModDob.Text);
                Command.Parameters.AddWithValue("nicode", TxtModNi.Text);
                Command.Parameters.AddWithValue("email", TxtModEmail.Text);
                Command.Parameters.AddWithValue("password", TxtModPassword.Text);
                Command.Parameters.AddWithValue("allowance", TxtModAllowance.Text);
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Record modified successfully.");
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                using SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = @"DELETE FROM customer WHERE custid = @id";
                Command.Parameters.AddWithValue("id", Convert.ToInt32(TxtDelCustId.Text));
                Connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
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
