using System;
using System.Collections.Generic;

namespace WesselSoft.Domain
{
    public enum TipoFuncionSenoidal { Seno, Coseno }

    public class FuncionSenoidal
    {
        public double Amplitud { get; protected set; }
        public TipoFuncionSenoidal Tipo { get; protected set; }
        public double Pulsación { get; protected set; }
        public double Argumento { get; protected set; }


    }
}