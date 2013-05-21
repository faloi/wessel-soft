using System;

namespace WesselSoft.Domain
{
    public enum TipoFuncionSenoidal { Seno, Coseno }

    public class FuncionSenoidal
    {
        public double Amplitud { get; protected set; }
        public TipoFuncionSenoidal Tipo { get; protected set; }
        public double Pulsación { get; protected set; }
        public double FaseInicial { get; protected set; }

        public FuncionSenoidal(double amplitud, TipoFuncionSenoidal tipo, double pulsacion, double faseInicial) {
            this.Amplitud = amplitud;
            this.Tipo = tipo;
            this.Pulsación = pulsacion;
            this.FaseInicial = faseInicial;
        }

        public Complejo FasorAsociado { get {
            return Complejo.DesdeFormaPolar(Amplitud, FaseInicial);
        } }

        public FuncionSenoidal SumarCon(FuncionSenoidal otraFuncion) {
            if (this.Pulsación != otraFuncion.Pulsación)
                throw new SumaSenoidalImposibleException("No se puede, las frecuencias son distintas");

            if (this.Tipo != otraFuncion.Tipo)
                otraFuncion.CambiarTipoA(this.Tipo);

            var sumaFasores = this.FasorAsociado + otraFuncion.FasorAsociado;
            return new FuncionSenoidal(sumaFasores.Modulo, this.Tipo, this.Pulsación, sumaFasores.Argumento);
        }

        private void CambiarTipoA(TipoFuncionSenoidal otroTipo) {
            switch (otroTipo) {
                case TipoFuncionSenoidal.Seno:
                    if (this.Tipo == TipoFuncionSenoidal.Coseno)
                        this.FaseInicial += Math.PI / 2;

                    break;
                case TipoFuncionSenoidal.Coseno:
                    if (this.Tipo == TipoFuncionSenoidal.Seno)
                        this.FaseInicial -= Math.PI / 2;

                    break;
            }
        }
    }
}