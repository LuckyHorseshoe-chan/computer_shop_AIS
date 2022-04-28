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
    public partial class BuyersForm : Form
    {
        public BuyersForm()
        {
            InitializeComponent();
        }

        private void BuyersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Покупатели". При необходимости она может быть перемещена или удалена.
            this.покупателиTableAdapter.Fill(this.shopDataBase.Покупатели);

        }

        private void save_Click(object sender, EventArgs e)
        {
            покупателиTableAdapter.Update(shopDataBase);
            this.Validate();
            this.покупателиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataBase);
        }

        private void report_Click(object sender, EventArgs e)
        {
            BuyersReport gr = new BuyersReport();
            gr.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Employees w = new Employees();
            w.Show();
            this.Close();
        }
    }
}
