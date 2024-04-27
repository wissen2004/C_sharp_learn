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
    public partial class MenuS : Form
    {
        public MenuS()
        {
            InitializeComponent();
        }

        private void MenuS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.cafeDBDataSet.Dishes);

        }
    }
}
