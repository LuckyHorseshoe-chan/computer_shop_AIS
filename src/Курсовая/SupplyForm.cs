using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class SupplyForm : Form
    {
        public SupplyForm()
        {
            InitializeComponent();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.shopDataBase.Поставка);

        }

        private void search_Click(object sender, EventArgs e)
        {
            SupplySearch supf = new SupplySearch();
            supf.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ShopData w = new ShopData();
            w.Show();
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            поставкаTableAdapter.Update(shopDataBase);
            this.Validate();
            this.поставкаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataBase);
        }

        private void report_Click(object sender, EventArgs e)
        {
            SupplyReport sr = new SupplyReport();
            sr.Show();
        }
    }
}
