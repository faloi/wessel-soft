using System;
using System.Collections.Generic;

namespace WesselSoft.Domain
{
    public partial class Complejo
    {
        public double ParteReal { get; protected set; }
        public double ParteImaginaria { get; protected set; }
        private const string FORMATO_NUMERO = "F2";

        private Complejo() { }

        public double Modulo { get {
            return Math.Sqrt(Math.Pow(this.ParteReal, 2) + Math.Pow(this.ParteImaginaria, 2));
        } }

        public double Argumento
        {
            get
            {
                if (this.EsNulo)
                    throw new ComplejoNuloException("No se puede calcular el argumento del complejo nulo");

                if (this.ParteReal != 0)
                {
                    var valorBase = Math.Atan(this.ParteImaginaria / this.ParteReal);
                    if (this.ParteReal < 0) valorBase += Math.PI;
                    return valorBase;
                }

                return this.ParteImaginaria > 0 ? Math.PI / 2 : 3 * Math.PI / 2;
            }
        }

        public Complejo Conjugado { get {
            return Complejo.DesdeFormaBinomica(this.ParteReal, -this.ParteImaginaria);
        } }

        public bool EsNulo { get {
            return this.ParteReal == 0 && this.ParteImaginaria == 0;
        } }

        public Complejo ElevarA(int natural) {
            return Complejo.DesdeFormaPolar(Math.Pow(this.Modulo, natural), natural * this.Argumento);
        }

        public Complejo LogaritmoNatural() {
            return Math.Log(this.Modulo) + this.Argumento * Complejo.UnidadImaginaria;
        }

        public IList<Complejo> RaizN(int n) {
            var raices = new List<Complejo>();
            for (int k = 0; k < n; k++)
                raices.Add(
                    Complejo.DesdeFormaPolar(
                        modulo: Math.Pow(this.Modulo, 1f/n),
                        argumento: (this.Argumento + 2 * k * Math.PI) / n
                    )
                );

            return raices;
        }

        #region Constructores
            public static Complejo DesdeFormaBinomica(double parteReal, double parteImaginaria) {
                return new Complejo { ParteReal = parteReal, ParteImaginaria = parteImaginaria };
            }

            public static Complejo DesdeFormaPolar(double modulo, double argumento) {
                var parteReal = modulo * Math.Cos(argumento);
                var parteImaginaria = modulo * Math.Sin(argumento);
                return Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            }

            public static Complejo DesdeString(String complejo) {
                if (Utils.EsComplejoBinario(complejo))
                    return DesdeFormaBinomica(Utils.ParteRealComplejoBinario(complejo), Utils.ParteImaginariaComplejoBinario(complejo));

                if (Utils.EsComplejoPolar(complejo))
                    return DesdeFormaPolar(Utils.ParteModuloComplejoPolar(complejo), Utils.ParteAnguloComplejoPolar(complejo));

                throw new NoComplejoException("El String " + complejo + " no tiene formato válido.");
            }

            public static Complejo Nulo { get {
                return Complejo.DesdeFormaBinomica(0, 0);
            } }

            public static Complejo UnidadImaginaria { get {
                return Complejo.DesdeFormaBinomica(0, 1);
            } }
        #endregion

        public override string ToString()
        {
            return this.ToString(Representacion.Binomica);
        }

        public string ToString(Representacion representacion)
        {
            switch (representacion) {
                default:
                    var parteReal = this.ParteReal.ToString(FORMATO_NUMERO, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    var parteImaginaria = Math.Abs(this.ParteImaginaria).ToString(FORMATO_NUMERO, System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                    return String.Format("({0}, {1})", parteReal, parteImaginaria);
                case Representacion.Polar:
                    var modulo = this.Modulo.ToString(FORMATO_NUMERO, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                    try {
                        var argumento = this.Argumento.ToString(FORMATO_NUMERO, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                        return String.Format("[{0}; {1}]", modulo, argumento);
                    } catch (ComplejoNuloException) {
                        return "[Complejo nulo]";
                    }
            }
        }
    }
}
