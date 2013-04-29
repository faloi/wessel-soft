using System;
using System.Linq;
using System.Text;

namespace WesselSoft.Domain
{
    public partial class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }
        private const string FORMATO_NUMERO = "F2";

        private Complejo() { }

        public double Modulo { get {
            return Math.Sqrt(Math.Pow(this.ParteReal, 2) + Math.Pow(this.ParteImaginaria, 2));
        } }

        public double Argumento { get {
            if (this.EsNulo)
                throw new ComplejoNuloException("No se puede calcular el argumento del complejo nulo");

            var valorBase = Math.Atan(this.ParteImaginaria / this.ParteReal);
            if (this.ParteReal < 0) valorBase += Math.PI;
            return valorBase;
        } }

        public Complejo Conjugado { get {
            return Complejo.DesdeFormaBinomica(this.ParteReal, -this.ParteImaginaria);
        } }

        public bool EsNulo { get {
            return this.ParteReal == 0 && this.ParteImaginaria == 0;
        } }

        public Complejo ElevarA(uint natural) {
            return Complejo.DesdeFormaPolar(Math.Pow(this.Modulo, natural), natural * this.Argumento);
        }

        public Complejo LogaritmoNatural() {
            return Math.Log(this.Modulo) + this.Argumento * Complejo.UnidadImaginaria();
        }

        public Complejo RaizN(int n) {
            throw new NotImplementedException("Me quiero ir a dormir");
        }

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

            public static Complejo Nulo() {
                return Complejo.DesdeFormaBinomica(0, 0);
            }

            public static Complejo UnidadImaginaria() {
                return Complejo.DesdeFormaBinomica(0, 1);
            }
        #endregion
    }

    public class ComplejoNuloException : Exception
    {
        public ComplejoNuloException(string mensaje) : base(mensaje) {}
    }
}