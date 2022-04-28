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
    public partial class WarehouseReport : Form
    {
        public WarehouseReport()
        {
            InitializeComponent();
        }

        private void WarehouseReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataBase.Склад". При необходимости она может быть перемещена или удалена.
            this.СкладTableAdapter.Fill(this.ShopDataBase.Склад);

            this.reportViewer1.RefreshReport();
        }
    }
}
