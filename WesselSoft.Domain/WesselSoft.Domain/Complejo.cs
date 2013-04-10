using System;

namespace WesselSoft.Domain
{
    public class Complejo
    {
        public double ParteReal { get; set; }
        public double ParteImaginaria { get; set; }

        public static Complejo DesdeFormaBinomica(double parteReal, double parteImaginaria)
        {
            return new Complejo { ParteReal = parteReal, ParteImaginaria = parteImaginaria };
        }

        public Cuadrante Cuadrante
        {
            get
            {
                if (this.ParteReal >= 0 && this.ParteImaginaria >= 0)
                    return Cuadrante.Primero;

                if (this.ParteReal < 0 && this.ParteImaginaria >= 0)
                    return Cuadrante.Segundo;

                if (this.ParteReal <= 0 && this.ParteImaginaria < 0)
                    return Cuadrante.Tercero;

                return Cuadrante.Cuarto;
            }
        }

        public double Modulo
        {
            get { return Math.Sqrt(Math.Pow(this.ParteImaginaria, 2) + Math.Pow(this.ParteReal, 2)); }
        }
    }
}