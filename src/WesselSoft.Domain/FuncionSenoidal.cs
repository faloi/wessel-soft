namespace WesselSoft.Domain
{
    public enum TipoFuncionSenoidal { Seno, Coseno }

    public class FuncionSenoidal
    {
        public double Amplitud { get; private set; }
        public TipoFuncionSenoidal Tipo { get; private set; }
        public double Pulsación { get; private set; }
        public double FaseInicial { get; private set; }

        public FuncionSenoidal(double amplitud, TipoFuncionSenoidal tipo, double pulsacion, double faseInicial) {
            this.Amplitud = amplitud;
            this.Tipo = tipo;
            this.Pulsación = pulsacion;
            this.FaseInicial = faseInicial;
        }
        public Complejo FasorAsociado { get {
            return Complejo.DesdeFormaPolar(Amplitud, FaseInicial);
        } }
    }
}