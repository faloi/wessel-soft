using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WesselSoft.Domain;

namespace WesselSoft.Ui
{
    class Program
    {
        static void Main(string[] args) {
            var repre = Representacion.Binomica;
            Console.WriteLine("Mirá el 3 + 2j: {0}", Complejo.DesdeFormaBinomica(3, 2).ToString(repre));
            Console.WriteLine("Mirá el 0: {0}", Complejo.DesdeFormaBinomica(0, 0).ToString(repre));
            Console.WriteLine("Mirá el -2.3: {0}", Complejo.DesdeFormaBinomica(-2.3, 0).ToString(repre));
            Console.WriteLine("Mirá el -4.5j: {0}", Complejo.DesdeFormaBinomica(0, -4.5).ToString(repre));
            Console.WriteLine("Mirá el 3.581 - 2.1102j: {0}", Complejo.DesdeFormaBinomica(3.581, -2.1102).ToString(repre));

            Console.WriteLine();
            repre = Representacion.Polar;
            Console.WriteLine("Mirá el 3 + 2j: {0}", Complejo.DesdeFormaBinomica(3, 2).ToString(repre));
            Console.WriteLine("Mirá el 0: {0}", Complejo.DesdeFormaBinomica(0, 0).ToString(repre));
            Console.WriteLine("Mirá el -2.3: {0}", Complejo.DesdeFormaBinomica(-2.3, 0).ToString(repre));
            Console.WriteLine("Mirá el -4.5j: {0}", Complejo.DesdeFormaBinomica(0, -4.5).ToString(repre));
            Console.WriteLine("Mirá el 3.581 - 2.1102j: {0}", Complejo.DesdeFormaBinomica(3.581, -2.1102).ToString(repre));

            Console.ReadKey();
        }
    }
}
