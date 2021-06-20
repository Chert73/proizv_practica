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
    public partial class Comparison : Form
    {
        public Comparison()
        {
            InitializeComponent();
        }

        private void сравнениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сравнениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRACTIKADataSet);

        }

        private void Comparison_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRACTIKADataSet.Сравнение". При необходимости она может быть перемещена или удалена.
            this.сравнениеTableAdapter.Fill(this.pRACTIKADataSet.Сравнение);

        }
    }
}
