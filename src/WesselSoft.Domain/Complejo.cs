using System;
using System.Linq;
using System.Text;

namespace WesselSoft.Domain
{
    public class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }
        private const string FORMATO_NUMERO = "##.##";

        private Complejo() { }

        public double Modulo { get {
            return Math.Sqrt(Math.Pow(this.ParteReal, 2) + Math.Pow(this.ParteImaginaria, 2));
        } }

        public double Argumento { get {
            var valorBase = Math.Atan(this.ParteImaginaria / this.ParteReal);
            if (this.ParteReal < 0) valorBase += Math.PI;
            return valorBase;
        } }

        public Complejo Conjugado { get {
            return Complejo.DesdeFormaBinomica(this.ParteReal, -this.ParteImaginaria);
        } }

        public string ToString(Representacion representacion) {
            switch(representacion) {
                case Representacion.Binomica:
                    var parteReal = this.ParteReal.ToString(FORMATO_NUMERO);
                    var signo = ParteImaginaria > 0 ? "+" : "-";
                    var parteImaginaria = Math.Abs(this.ParteImaginaria).ToString(FORMATO_NUMERO);

                    return String.Format("{0} {1} {2}j", parteReal, signo, parteImaginaria);
                case Representacion.Polar:
                    var modulo = this.Modulo.ToString(FORMATO_NUMERO);
                    var argumento = this.Argumento.ToString(FORMATO_NUMERO);

                    return String.Format("({0}, {1})", modulo, argumento);
            }
            return base.ToString();
        }

        #region Operaciones
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
        #endregion

        #region Constructores
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