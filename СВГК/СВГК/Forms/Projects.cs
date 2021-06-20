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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void проектBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.проектBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRACTIKADataSet);

        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRACTIKADataSet.Проект". При необходимости она может быть перемещена или удалена.
            this.проектTableAdapter.Fill(this.pRACTIKADataSet.Проект);

        }
    }
}
