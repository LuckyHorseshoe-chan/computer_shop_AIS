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
    public partial class Makers : Form
    {
        public Makers()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buyers_Click(object sender, EventArgs e)
        {
            PurchasesForm_r pf = new PurchasesForm_r();
            pf.Show();
        }
    }
}
