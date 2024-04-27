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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.DishSale". При необходимости она может быть перемещена или удалена.
            this.dishSaleTableAdapter.Fill(this.cafeDBDataSet.DishSale);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dishSaleBindingSource.EndEdit();
            this.dishSaleTableAdapter.Update(this.cafeDBDataSet);
            MessageBox.Show("Обновлено успешно!");
        }
    }
}
