using System;
using System.Windows.Forms;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    public partial class OperacionesAvanzadas : Form
    {
        public OperacionesAvanzadas() {
            InitializeComponent();
        }

        private void Btn_DoOperation_Click_1(object sender, EventArgs e) {
            UIController controller = new UIController();
            Complejo complejo1;
            int coeficienteEntero = 1;
            try {
                complejo1 = Complejo.DesdeString(TxtBox_Number1.Text);
            } catch (Domain.NoComplejoException exc) {
                MessageBox.Show(exc.Message);
                return;
            }
            try {
                coeficienteEntero = Int32.Parse(TxtBox_Number2.Text);
            } catch (Exception) {
                MessageBox.Show("El formato del numero para realizar la operación no es válido.");
                return;
            }
            Complejo resultado = Complejo.Nulo;
            if (ComboBox_Operation.SelectedItem != null) {
                switch (ComboBox_Operation.SelectedItem.ToString()) {
                    case "Raiz":
                        resultado = complejo1.RaizN(coeficienteEntero);
                        break;
                    case "Potencia":
                        resultado = complejo1.ElevarA((uint)coeficienteEntero);
                        break;
                }
            } else {
                MessageBox.Show("No seleccionó operación");
                return;
            }
            TxtBox_Result.Text = resultado.ToString(controller.GetSelectedResultEnum(GroupBox_Result));
        }
    }
}
