using System.Globalization;
using System.Windows.Forms;

namespace WesselSoft.Ui
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}