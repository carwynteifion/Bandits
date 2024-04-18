using System.Data;
using System.Data.SQLite;

namespace Bandits
{
    // View Transactions by Customer
    public partial class Form7 : Form
    {
        public Form7(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
            // Add ListView columns
            ListCustTranx.View = View.Details;
            ListCustTranx.Columns.Add("Date", 180, HorizontalAlignment.Left);
            ListCustTranx.Columns.Add("Account ID", 100, HorizontalAlignment.Left);
            ListCustTranx.Columns.Add("Transaction Type", 150, HorizontalAlignment.Left);
            ListCustTranx.Columns.Add("Amount", 100, HorizontalAlignment.Left);
        }

        readonly string ConnectionString;

        // On load, populate dropdown with customer IDs from database
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteCommand Command = Connection.CreateCommand();
                Command.CommandText = """
                    SELECT DISTINCT c.custid 
                    FROM customer c JOIN account a ON c.custid = a.custid 
                    ORDER BY c.custid;
                    """;
                using SQLiteDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    DdCustId.Items.Add(Reader.GetInt16(0).ToString());
                }
                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        // When customer ID is selected, display all transactions for that customer
        private void DdCustId_OnValueChanged(object sender, EventArgs e)
        { 
            try
            {
                using SQLiteConnection Connection2 = new(ConnectionString);
                Connection2.Open();
                SQLiteDataAdapter sda = new("""
                    SELECT event AS 'Date', 
                    t.accid AS 'Account ID', 
                    action AS 'Transaction Type', 
                    amnt AS 'Amount' 
                    FROM tranx t JOIN account a ON t.accid = a.accid 
                    WHERE a.custid = 
                    """ + DdCustId.Text +
                    " ORDER BY event;", Connection2);
                DataSet ds = new();
                sda.Fill(ds);

                // Clear rows from ListView, then generate new ones based on customer ID
                ListCustTranx.Items.Clear();
                ListCustTranx.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem item = new()
                    {
                        Text = row["Date"].ToString()
                    };
                    item.SubItems.Add(row["Account ID"].ToString());
                    item.SubItems.Add(row["Transaction Type"].ToString());
                    item.SubItems.Add(row["Amount"].ToString());
                    ListCustTranx.Items.Add(item);
                }
                ListCustTranx.EndUpdate();
                Connection2.Close();
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
    }
}
