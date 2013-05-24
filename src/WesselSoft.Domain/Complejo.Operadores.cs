using System;

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

        public static Complejo operator -(Complejo c) {
            return Complejo.DesdeFormaBinomica(-c.ParteReal, -c.ParteImaginaria);
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

        #region Equals
            public static bool operator ==(Complejo c1, Complejo c2) {
                return Math.Abs(c1.ParteReal - c2.ParteReal) < 0.0001 && Math.Abs(c1.ParteImaginaria - c2.ParteImaginaria) < 0.0001;
            }

            public static bool operator !=(Complejo c1, Complejo c2) {
                return !(c1 == c2);
            }

            public override bool Equals(Object c2) {
                return this == (Complejo) c2;
            }

            public override int GetHashCode() { return this.ParteReal.GetHashCode() ^ this.ParteImaginaria.GetHashCode(); }
        #endregion
    }
}
