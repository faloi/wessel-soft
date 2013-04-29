using System;
using System.Linq;
using System.Text;

namespace WesselSoft.Domain
{
    public partial class Complejo
    {
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
            if (c2.EsNulo) throw new ComplejoNuloException("El divisor es el complejo nulo");
            return Complejo.DesdeFormaPolar(c1.Modulo / c2.Modulo, c1.Argumento - c2.Argumento);
        }

        #region Operadores con reales
            public static Complejo operator +(Complejo c, double r) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c + real;
            }
            public static Complejo operator +(double r, Complejo c) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c + real;
            }
            public static Complejo operator -(Complejo c, double r) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c - real;
            }
            public static Complejo operator -(double r, Complejo c) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return real - c;
            }
            public static Complejo operator *(Complejo c, double r) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c * real;
            }
            public static Complejo operator *(double r, Complejo c) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c * real;
            }
            public static Complejo operator /(Complejo c, double r) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return c / real;
            }
            public static Complejo operator /(double r, Complejo c) {
                var real = Complejo.DesdeFormaBinomica(r, 0);
                return real / c;
            }
        #endregion

        public string ToString(Representacion representacion) {
            switch (representacion) {
                case Representacion.Binomica:
                    var parteReal = this.ParteReal.ToString(FORMATO_NUMERO);
                    var signo = ParteImaginaria > 0 ? "+" : "-";
                    var parteImaginaria = Math.Abs(this.ParteImaginaria).ToString(FORMATO_NUMERO);

                    var completo = this.ParteReal != 0 && this.ParteImaginaria != 0;
                    var format = new StringBuilder()
                        .Append(this.ParteReal != 0 || this.EsNulo ? "{0}" : "")
                        .Append(completo || this.ParteImaginaria < 0 ? " {1} " : "")
                        .Append(this.ParteImaginaria != 0 ? "{2}j" : "")
                        .ToString();
                    return String.Format(format, parteReal, signo, parteImaginaria);

                case Representacion.Polar:
                    var modulo = this.Modulo.ToString(FORMATO_NUMERO);
                    try {
                        var argumento = this.Argumento.ToString(FORMATO_NUMERO);
                        return String.Format("[{0}; {1}]", modulo, argumento);
                    } catch (ComplejoNuloException) {
                        return "[Complejo nulo]";
                    }
            }
            return base.ToString();
        }
    }
}