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
    public partial class PurchasesForm_r : Form
    {
        public PurchasesForm_r()
        {
            InitializeComponent();
        }

        private void PurchasesForm_r_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Покупки". При необходимости она может быть перемещена или удалена.
            this.покупкиTableAdapter.Fill(this.shopDataBase.Покупки);

        }

        private void report_Click(object sender, EventArgs e)
        {
            PurchasesReport gr = new PurchasesReport();
            gr.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Makers w = new Makers();
            w.Show();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            PurchasesSearch supf = new PurchasesSearch();
            supf.Show();
            this.Close();
        }
    }
}
