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
    public partial class Performance : Form
    {
        public Performance()
        {
            InitializeComponent();
        }

        private void выполнениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выполнениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRACTIKADataSet);

        }

        private void Performance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRACTIKADataSet.Выполнение". При необходимости она может быть перемещена или удалена.
            this.выполнениеTableAdapter.Fill(this.pRACTIKADataSet.Выполнение);

        }
    }
}
