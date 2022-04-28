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
    public partial class SupplyReport : Form
    {
        public SupplyReport()
        {
            InitializeComponent();
        }

        private void SupplyReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataBase.Поставка". При необходимости она может быть перемещена или удалена.
            this.ПоставкаTableAdapter.Fill(this.ShopDataBase.Поставка);

            this.reportViewer1.RefreshReport();
        }
    }
}
