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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void заказчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRACTIKADataSet);
            Barcode barcode = new Barcode();
            barcode.Show();

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRACTIKADataSet.Заказчик". При необходимости она может быть перемещена или удалена.
            this.заказчикTableAdapter.Fill(this.pRACTIKADataSet.Заказчик);

        }

       

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
