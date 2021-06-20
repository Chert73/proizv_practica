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
    public partial class Glavnoe_menu : Form
    {
        public Glavnoe_menu()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.Show();
        }

        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projects pr = new Projects();
            pr.Show();
        }

        private void сметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estimates est = new Estimates();
            est.Show();
        }

        private void выполнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Performance perf = new Performance();
            perf.Show();
        }

        private void сравнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comparison comp = new Comparison();
            comp.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autorization autoriz = new Autorization();
            autoriz.Show();
            Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
