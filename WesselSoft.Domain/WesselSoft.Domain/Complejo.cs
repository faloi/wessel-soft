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
    }
}
