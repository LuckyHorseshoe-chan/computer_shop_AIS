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
    public partial class Buyers : Form
    {
        public Buyers()
        {
            InitializeComponent();
        }

        private void goods_Click(object sender, EventArgs e)
        {
            GoodsForm_r gf = new GoodsForm_r();
            gf.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
