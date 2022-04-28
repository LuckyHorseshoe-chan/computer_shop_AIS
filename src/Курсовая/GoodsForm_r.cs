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
    public partial class GoodsForm_r : Form
    {
        public GoodsForm_r()
        {
            InitializeComponent();
        }

        private void GoodsForm_r_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataBase.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.shopDataBase.Товары);

        }


        private void report_Click(object sender, EventArgs e)
        {
            GoodsReport gr = new GoodsReport();
            gr.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Buyers w = new Buyers();
            w.Show();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            GoodsSearch supf = new GoodsSearch();
            supf.Show();
        }
    }
}
