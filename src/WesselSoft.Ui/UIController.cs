using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    class UIController
    {

        public Representacion GetSelectedResultEnum(GroupBox groupoBox)
        {
            var checkedButton = groupoBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            Representacion enumOut;
            Representacion.TryParse(checkedButton.Text, false, out enumOut);
            return enumOut;
        }
    }
}
