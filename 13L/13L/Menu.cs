using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _13L
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.cafeDBDataSet.Dishes);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dishesBindingSource.EndEdit();
            this.dishesTableAdapter.Update(this.cafeDBDataSet);
            MessageBox.Show("Обновлено успешно!");
        }
    }
}
