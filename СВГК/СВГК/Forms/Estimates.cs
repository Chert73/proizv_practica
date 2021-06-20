using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СВГК
{
    public partial class Estimates : Form
    {
        public Estimates()
        {
            InitializeComponent();
        }

        private void сметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRACTIKADataSet);

        }

        private void Estimates_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRACTIKADataSet.Сметы". При необходимости она может быть перемещена или удалена.
            this.сметыTableAdapter.Fill(this.pRACTIKADataSet.Сметы);

        }
    }
}
