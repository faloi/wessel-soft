using System;

namespace WesselSoft.Domain
{
    public class NoComplejoException : Exception
    {
        public NoComplejoException(string mensaje) : base(mensaje) { }
    }

    public class ComplejoNuloException : Exception
    {
        public ComplejoNuloException(string mensaje) : base(mensaje) { }
    }

    public class SumaSenoidalImposibleException : Exception
    {
        public SumaSenoidalImposibleException(string mensaje) : base(mensaje) { }
    }
}
