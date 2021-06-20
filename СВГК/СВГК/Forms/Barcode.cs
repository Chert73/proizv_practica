using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace СВГК
{
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
        }
        
        private void btnBarcode_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 }; //создание штрих-кода
            pictureBarcode.BackgroundImage = writer.Write(textBarcode.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            pictureBarcode.Image.Save(@"C:/Users/олег/Desktop/СВГК/штрих-коды/barcode.png");
        }

        private void pictureBarcode_Click(object sender, EventArgs e)
        {

        }
    }
}
