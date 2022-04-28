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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.shopDataBase.Склад);

        }

        private void save_Click(object sender, EventArgs e)
        {
            складTableAdapter.Update(shopDataBase);
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataBase);
        }

        private void report_Click(object sender, EventArgs e)
        {
            WarehouseReport gr = new WarehouseReport();
            gr.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ShopData w = new ShopData();
            w.Show();
            this.Close();
        }
    }
}
