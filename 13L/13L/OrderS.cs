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
    public partial class OrderS : Form
    {
        public OrderS()
        {
            InitializeComponent();
        }

        private void OrderS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.DishSale". При необходимости она может быть перемещена или удалена.
            this.dishSaleTableAdapter.Fill(this.cafeDBDataSet.DishSale);

        }
    }
}
