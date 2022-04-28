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
    public partial class SupplySearch : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = lab2_Anya.mdb";
        private OleDbConnection myConnection;

        public SupplySearch()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString); 
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            myConnection.Open();
            string country = textBox1.Text;
            //string dateLow = textBox1.Text;
            //string dateHigh = textBox2.Text;
            //string query = "Select ДатаПоставки from Поставка where ДатаПоставки between " + dateLow + " and " + dateHigh + "";
            string query = "Select * from Поставка where Откуда = '" + country + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            myConnection.Close();
            adapter.SelectCommand = command; 
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0]; 
            adapter.Update(dataSet);
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.shopDataBase.Поставка);

        }

    }
}
