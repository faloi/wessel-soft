namespace WesselSoft.Domain
{
    public enum TipoFuncionSenoidal { Seno, Coseno }

    public struct FuncionSenoidal
    {
        public double Amplitud { get; private set; }
        public TipoFuncionSenoidal Tipo { get; private set; }
        public double Pulsación { get; private set; }
        public double Argumento { get; private set; }


    }
}