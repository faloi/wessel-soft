using System;
using System.Linq;
using System.Text;

namespace WesselSoft.Domain
{
    public class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        public double Modulo { get {
            return Math.Sqrt(Math.Pow(this.ParteReal, 2) + Math.Pow(this.ParteImaginaria, 2));
        } }

        public double Argumento { get {
            var valorBase = Math.Atan(this.ParteImaginaria / this.ParteReal);
            if (this.ParteReal < 0) valorBase += Math.PI;
            return valorBase;
        } }

        public string ToString(Representacion representacion) {
            switch(representacion) {
                case Representacion.Binomica:
                    return new StringBuilder()
                        .Append(ParteReal.ToString("##.##"))
                        .AppendFormat(" {0} ", ParteImaginaria > 0 ? "+" : "-")
                        .AppendFormat("j * {0}", Math.Abs(ParteImaginaria).ToString("##.##"))
                        .ToString();
                case Representacion.Polar:
                    return "Están hablando del faaaaaaaaaasor";
            }
            return base.ToString();
        }

        #region Operadores
            public static Complejo operator +(Complejo c1, Complejo c2) {
                return Complejo.DesdeFormaBinomica(c1.ParteReal + c2.ParteReal, c1.ParteImaginaria + c2.ParteImaginaria);
            }
            public static Complejo operator -(Complejo c1, Complejo c2) {
                return Complejo.DesdeFormaBinomica(c1.ParteReal - c2.ParteReal, c1.ParteImaginaria - c2.ParteImaginaria);
            }
            public static Complejo operator *(Complejo c1, Complejo c2) {
                return Complejo.DesdeFormaPolar(c1.Modulo * c2.Modulo, c1.Argumento + c2.Argumento);
            }
            public static Complejo operator /(Complejo c1, Complejo c2) {
                return Complejo.DesdeFormaPolar(c1.Modulo / c2.Modulo, c1.Argumento - c2.Argumento);
            }
            public static Complejo operator !(Complejo c) {
                return Complejo.DesdeFormaBinomica(c.ParteReal, -c.ParteImaginaria);
            }
        #endregion

        #region Creadores
            public static Complejo DesdeFormaBinomica(double parteReal, double parteImaginaria)
            {
                return new Complejo { ParteReal = parteReal, ParteImaginaria = parteImaginaria };
            }

            public static Complejo DesdeFormaPolar(double modulo, double argumento) {
                var parteReal = modulo * Math.Cos(argumento);
                var parteImaginaria = modulo * Math.Sin(argumento);
                return Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            }
        #endregion
    }
}