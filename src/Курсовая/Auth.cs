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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login1 = "employee";
            string login2 = "buyer";
            string login3 = "maker";
            string right_pass1 = "1";
            string right_pass2 = "2";
            string right_pass3 = "3";
            string login = textBox1.Text;
            string pass = maskedTextBox1.Text;
            if (login == login1 && pass == right_pass1)
            {
                Employees w = new Employees();
                w.Show();
                this.Hide();
            }
            else if (login == login2 && pass == right_pass2) {
                Buyers b = new Buyers();
                b.Show();
                this.Hide();
            }
            else if (login == login3 && pass == right_pass3) {
                Makers m = new Makers();
                m.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Неверный пароль или логин";
            }
        }

        private void BuyersAuth_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
