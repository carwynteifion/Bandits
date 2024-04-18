using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandits
{
    public partial class Form6 : Form
    {
        public Form6(string InString)
        {
            InitializeComponent();
            ConnectionString = InString;
            StartPosition = FormStartPosition.CenterScreen;
            ListMVC.View = View.Details;
            ListMVC.Columns.Add("Customer ID", 100, HorizontalAlignment.Left);
            ListMVC.Columns.Add("Name", 180, HorizontalAlignment.Left);
            ListMVC.Columns.Add("Total Held", 100, HorizontalAlignment.Left);
        }

        readonly string ConnectionString;

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                using SQLiteConnection Connection = new(ConnectionString);
                Connection.Open();
                SQLiteDataAdapter sda = new(@"SELECT c.custid AS 'Customer ID', c.title || ' ' || c.firstname || ' ' || c.lastname AS 'Name', ROUND(SUM(a.balance), 2) AS 'Total Held' FROM customer c JOIN account a ON c.custid = a.custid GROUP BY c.custid ORDER BY SUM(a.balance) DESC;
", Connection);
                DataSet ds = new();
                sda.Fill(ds);

                ListMVC.BeginUpdate();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ListViewItem item = new()
                    {
                        Text = row["Customer ID"].ToString()
                    };
                    item.SubItems.Add(row["Name"].ToString());
                    item.SubItems.Add(row["Total Held"].ToString());
                    ListMVC.Items.Add(item);
                }
                ListMVC.EndUpdate();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
