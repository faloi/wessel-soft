using System;
using System.Linq;

namespace WesselSoft.Domain
{
    public class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        public static Complejo DesdeFormaBinomica(double parteReal, double parteImaginaria)
        {
            return new Complejo { ParteReal = parteReal, ParteImaginaria = parteImaginaria };
        }

        public Cuadrante Cuadrante
        {
            get
            {
                if (this.ParteReal >= 0 && this.ParteImaginaria >= 0)
                    return Cuadrante.Primero;

                if (this.ParteReal < 0 && this.ParteImaginaria >= 0)
                    return Cuadrante.Segundo;

                if (this.ParteReal <= 0 && this.ParteImaginaria < 0)
                    return Cuadrante.Tercero;

                return Cuadrante.Cuarto;
            }
        }

        public double Modulo
        {
            get { return Math.Sqrt(Math.Pow(this.ParteImaginaria, 2) + Math.Pow(this.ParteReal, 2)); }
        }

        public double Argumento
        {
            get
            {
                var valorBase = Math.Atan(this.ParteImaginaria / this.ParteReal);

                var cuadrantesConCorreccion = new[] { Cuadrante.Segundo, Cuadrante.Tercero };
                if (cuadrantesConCorreccion.Contains(this.Cuadrante))
                    valorBase += Math.PI;

                return valorBase;
            }
        }
    }
}