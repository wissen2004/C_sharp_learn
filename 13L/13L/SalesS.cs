using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13L
{
    public partial class SalesS : Form
    {
        public SalesS()
        {
            InitializeComponent();
        }

        private void SalesS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.cafeDBDataSet.Sales);

        }
    }
}
