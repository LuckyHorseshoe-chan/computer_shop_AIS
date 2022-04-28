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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void employeers_Click(object sender, EventArgs e)
        {
            Employees w = new Employees();
            w.Show();
            this.Hide();
        }

        private void makers_Click(object sender, EventArgs e)
        {
            Makers m = new Makers();
            m.Show();
            this.Hide();
        }

        private void buyers_Click(object sender, EventArgs e)
        {
            Buyers b = new Buyers();
            b.Show();
            this.Hide();
        }
    }
}
