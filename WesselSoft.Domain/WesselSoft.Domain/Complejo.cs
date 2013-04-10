using System;

namespace WesselSoft.Domain
{
    public class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        public Complejo(double parteReal, double parteImaginaria)
        {
            this.ParteReal = parteReal;
            this.ParteImaginaria = parteImaginaria;
        }

        public double Modulo
        {
            get { return Math.Sqrt(Math.Pow(this.ParteImaginaria, 2) + Math.Pow(this.ParteReal, 2)); }
        }
    }
}
