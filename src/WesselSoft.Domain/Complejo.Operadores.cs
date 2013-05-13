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

        public static bool operator ==(Complejo c1, Complejo c2) {
            return c1.ParteReal == c2.ParteReal && c1.ParteImaginaria == c2.ParteImaginaria;
        }

        public static bool operator !=(Complejo c1, Complejo c2)
        {
            return !(c1 == c2);
        }
    }
}