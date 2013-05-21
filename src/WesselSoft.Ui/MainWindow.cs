using System;
using System.Windows.Forms;

namespace WesselSoft.Ui
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OperacionesBasicas().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OperacionesAvanzadas().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SumaFasores().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new CalculoTransferencia().Show();
        }
    }
}