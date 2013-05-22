using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WesselSoft.Domain;
using WesselSoft.Ui;

namespace WesselSoft.Ui
{
    public partial class SumaFasores : Form
    {
        public SumaFasores()
        {
            InitializeComponent();
        }

        private void Btn_Result_Click(object sender, System.EventArgs e)
        {
            double amplitud1 = double.Parse(TxtBox_Amplitude1.Text);
            double amplitud2 = double.Parse(TxtBox_Amplitude2.Text);
            double frecuencia1 = double.Parse(TxtBox_Frequency1.Text);
            double frecuencia2 = double.Parse(TxtBox_Frequency2.Text);
            double fase1 = double.Parse(TxtBox_Phase1.Text);
            double fase2 = double.Parse(TxtBox_Phase2.Text);
            TipoFuncionSenoidal tipoFuncion1;
            TipoFuncionSenoidal tipoFuncion2;
            if (Enum.TryParse(ComboBox_Function1.SelectedItem.ToString(), out tipoFuncion1) == false)
                return;
            if (Enum.TryParse(ComboBox_Function2.SelectedItem.ToString(), out tipoFuncion2) == false)
                return;
            
            FuncionSenoidal fasor1 = new FuncionSenoidal(amplitud1, tipoFuncion1, frecuencia1, fase1);
            FuncionSenoidal fasor2 = new FuncionSenoidal(amplitud2, tipoFuncion2, frecuencia2, fase2);
            FuncionSenoidal resultado;
            try
            {
                resultado = fasor1.SumarCon(fasor2);
            }
            catch (SumaSenoidalImposibleException errorSuma)
            {
                MessageBox.Show(errorSuma.Message);
                return;
            }

            TxtBox_AmplitudeResult.Text = resultado.Amplitud.ToString();
            TxtBox_FrequencyResult.Text = resultado.Pulsación.ToString();
            TxtBox_PhaseResult.Text = resultado.FaseInicial.ToString();
            TxtBox_FunctionResult.Text = resultado.Tipo.ToString();
        }

        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            UIController.IsNumeric(txtBox.Text, e);
        }

    }
}