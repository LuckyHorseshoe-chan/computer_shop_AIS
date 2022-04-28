using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсовая
{
    public partial class PurchasesSearch : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = lab2_Anya.mdb";
        private OleDbConnection myConnection;
        public PurchasesSearch()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            myConnection.Open();
            string id = textBox1.Text;
            string query = "Select * from Покупки where IDпокупателя = " + id + "";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            myConnection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }
    }
}
