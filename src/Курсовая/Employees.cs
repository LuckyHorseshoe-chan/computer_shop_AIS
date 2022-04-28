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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void shopdata_Click(object sender, EventArgs e)
        {
            ShopData w = new ShopData();
            w.Show();
            this.Close();
        }

        private void makers_Click(object sender, EventArgs e)
        {
            MakersForm mf = new MakersForm();
            mf.Show();
        }

        private void buyers_Click(object sender, EventArgs e)
        {
            BuyersForm bf = new BuyersForm();
            bf.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 supf = new Form1();
            supf.Show();
            this.Close();
        }
    }
}
