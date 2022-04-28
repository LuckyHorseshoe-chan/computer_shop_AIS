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
    public partial class MakersReport : Form
    {
        public MakersReport()
        {
            InitializeComponent();
        }

        private void MakersReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ShopDataBase.Производители". При необходимости она может быть перемещена или удалена.
            this.ПроизводителиTableAdapter.Fill(this.ShopDataBase.Производители);

            this.reportViewer1.RefreshReport();
        }
    }
}
