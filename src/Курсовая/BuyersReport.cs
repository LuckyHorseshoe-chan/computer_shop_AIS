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
    public partial class BuyersReport : Form
    {
        public BuyersReport()
        {
            InitializeComponent();
        }

        private void BuyersReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataBase.Покупатели". При необходимости она может быть перемещена или удалена.
            this.ПокупателиTableAdapter.Fill(this.ShopDataBase.Покупатели);

            this.reportViewer1.RefreshReport();
        }
    }
}
