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
    }
}