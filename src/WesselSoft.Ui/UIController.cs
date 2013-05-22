using System;
using System.Linq;
using System.Windows.Forms;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    internal class UIController
    {
        public Representacion GetSelectedResultEnum(GroupBox groupoBox)
        {
            RadioButton checkedButton = groupoBox.Controls
                                                 .OfType<RadioButton>()
                                                 .FirstOrDefault(r => r.Checked);
            Representacion enumOut;
            Enum.TryParse(checkedButton.Text, false, out enumOut);
            return enumOut;
        }


        public static void IsNumeric(string text, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}