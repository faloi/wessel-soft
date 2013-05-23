using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    public partial class CalculoTransferencia : Form
    {
        public CalculoTransferencia()
        {
            InitializeComponent();
        }

        private void Btn_Calculate_Click(object sender, System.EventArgs e)
        {
            IList<Complejo> polos;
            IList<Complejo> ceros;
            try
            {
                polos = TxtBox_Poles.Text.Split('\n').Select(polo => Complejo.DesdeString(polo.Trim())).ToList();
                ceros = TxtBox_Zeros.Text.Split('\n').Select(polo => Complejo.DesdeString(polo.Trim())).ToList();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            double constante;
            try
            {
                constante = double.Parse(TxtBox_Constant.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El valor de la Constante es erroneo");
                return;
            }

            Domain.FuncionTransferencia funcionTransferencia = new FuncionTransferencia(constante, polos, ceros);
            Complejo complejo;
            try
            {
                complejo = funcionTransferencia.EvaluarEn(Complejo.DesdeString(TxtBox_ComplexNumber.Text));
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            TxtBox_Result.Text = complejo.ToString(Representacion.Binomica);
        }
    }
}