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
    public partial class MakersForm : Form
    {
        public MakersForm()
        {
            InitializeComponent();
        }

        private void MakersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Производители". При необходимости она может быть перемещена или удалена.
            this.производителиTableAdapter.Fill(this.shopDataBase.Производители);

        }

        private void save_Click(object sender, EventArgs e)
        {
            производителиTableAdapter.Update(shopDataBase);
            this.Validate();
            this.производителиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataBase);
        }

        private void report_Click(object sender, EventArgs e)
        {
            MakersReport gr = new MakersReport();
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
