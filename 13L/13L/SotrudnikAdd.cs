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
    public partial class SotrudnikAdd : Form
    {
        public SotrudnikAdd()
        {
            InitializeComponent();
        }

        private void SotrudnikAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cafeDBDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.cafeDBDataSet.Workers);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.workersTableAdapter.Update(this.cafeDBDataSet);
            MessageBox.Show("Обновлено успешно!");
        }
    }
}
