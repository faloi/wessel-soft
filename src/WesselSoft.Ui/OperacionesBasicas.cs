using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    public partial class OperacionesBasicas : Form
    {
        public OperacionesBasicas()
        {
            InitializeComponent();
        }

        private void Btn_DoOperation_Click(object sender, EventArgs e)
        {
            UIController controller = new UIController();
            Complejo complejo1;
            Complejo complejo2;
            try
            {
                complejo1 = Complejo.DesdeString(TxtBox_Number1.Text);
                complejo2 = Complejo.DesdeString(TxtBox_Number2.Text);
            }
            catch (Domain.NoComplejoException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            Complejo resultado = Complejo.Nulo;
            if (ComboBox_Operation.SelectedItem != null)
            {
                switch (ComboBox_Operation.SelectedItem.ToString())
                {
                    case "+":
                        resultado = complejo1 + complejo2;
                        break;
                    case "-":
                        resultado = complejo1 - complejo2;
                        break;
                    case "*":
                        resultado = complejo1*complejo2;
                        break;
                    case "/":
                        resultado = complejo1/complejo2;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No seleccionó operación");
                return;
            }
            TxtBox_Result.Text = resultado.ToString(controller.GetSelectedResultEnum(GroupBox_Result));
        }









    }
}
