using System;
using System.Collections.Generic;
using System.Linq;

namespace WesselSoft.Domain
{
    public class FuncionTransferencia
    {
        public double K { get; set; }
        public IList<Complejo> Ceros { get; protected set; }
        public IList<Complejo> Polos { get; protected set; }

        public FuncionTransferencia(double k, IList<Complejo> ceros, IList<Complejo> polos) {
            this.K = k;
            this.Ceros = ceros;
            this.Polos = polos;
        }

        public Complejo EvaluarEn(Complejo complejo) {
            return
                K * Ceros.Aggregate((a, b) => a * (complejo - b))
                /*  _____________________________________________  */ /
                    Polos.Aggregate((a, b) => a * (complejo - b));
        }
    }
}