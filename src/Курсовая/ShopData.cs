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
    public partial class ShopData : Form
    {
        public ShopData()
        {
            InitializeComponent();
        }

        private void goods_Click(object sender, EventArgs e)
        {
            GoodsForm_e gf = new GoodsForm_e();
            gf.Show();
            this.Close();
        }

        private void purchases_Click(object sender, EventArgs e)
        {
            PurchasesForm_e pf = new PurchasesForm_e();
            pf.Show();
            this.Close();
        }

        private void supply_Click(object sender, EventArgs e)
        {
            SupplyForm sf = new SupplyForm();
            sf.Show();
            this.Close();
        }

        private void warehouse_Click(object sender, EventArgs e)
        {
            Warehouse w = new Warehouse();
            w.Show();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Employees form1 = new Employees();
            form1.Show();
            this.Close();
        }
    }
}
