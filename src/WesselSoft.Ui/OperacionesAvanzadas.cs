using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WesselSoft.Domain;
using System.Linq;

namespace WesselSoft.Ui
{
    public partial class OperacionesAvanzadas : Form
    {
        public OperacionesAvanzadas()
        {
            InitializeComponent();
        }

        private void Btn_DoOperation_Click_1(object sender, EventArgs e)
        {
            //Adaptar para que la raiz devuelva varios resultados

            var controller = new UIController();
            Complejo complejo1;
            int coeficienteEntero = 1;
            try
            {
                complejo1 = Complejo.DesdeString(TxtBox_Number1.Text);
            }
            catch (NoComplejoException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            try
            {
                coeficienteEntero = Int32.Parse(TxtBox_Number2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato del numero para realizar la operación no es válido.");
                return;
            }
            List<Complejo> resultados;
            if (ComboBox_Operation.SelectedItem != null)
            {
                switch (ComboBox_Operation.SelectedItem.ToString())
                {
                    case "Raiz":
                        resultados = (List<Complejo>) complejo1.RaizN(coeficienteEntero);
                        break;
                    case "Potencia":
                        resultados = new List<Complejo>();
                        resultados.Add(complejo1.ElevarA(coeficienteEntero));
                        break;
                    default:
                        return;
                }
            }
            else
            {
                MessageBox.Show("No seleccionó operación");
                return;
            }
            ListBox_Result.Items.Clear();
            resultados.ForEach(item => ListBox_Result.Items.Add(item.ToString(controller.GetSelectedResultEnum(GroupBox_EnumResult))));
            AutoScaleListBox();
        }

        private void AutoScaleListBox()
        {
            if (ListBox_Result.Items.Count > 6)
            {
                ListBox_Result.Height = 147;
            }
            else
            {
                ListBox_Result.Height = 15 * ListBox_Result.Items.Count;
            }
        }


    }
}
