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
    public partial class PurchasesReport : Form
    {
        public PurchasesReport()
        {
            InitializeComponent();
        }

        private void PurchasesReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataBase.Покупки". При необходимости она может быть перемещена или удалена.
            this.ПокупкиTableAdapter.Fill(this.ShopDataBase.Покупки);

            this.reportViewer1.RefreshReport();
        }
    }
}
