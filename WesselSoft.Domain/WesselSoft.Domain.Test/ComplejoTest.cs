using System;
using Xunit;
using Xunit.Extensions;

namespace WesselSoft.Domain.Test
{
    public class ComplejoTest
    {
        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(3, 0, 3)]
        [InlineData(1, 1, 1.4142)]
        public void Calculo_de_modulo(double parteReal, double parteImaginaria, double moduloEsperado)
        {
            var unComplejo = Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            Assert.Equal(moduloEsperado, unComplejo.Modulo, 4);
        }

        [Theory]
        [InlineData(0, 1, Cuadrante.Primero)]
        [InlineData(1, 0, Cuadrante.Primero)]
        [InlineData(-1, 0, Cuadrante.Segundo)]
        [InlineData(0, -1, Cuadrante.Tercero)]
        [InlineData(2, 1, Cuadrante.Primero)]
        [InlineData(-2, 1, Cuadrante.Segundo)]
        [InlineData(-2, -1, Cuadrante.Tercero)]
        [InlineData(2, -1, Cuadrante.Cuarto)]
        public void Cuadrante_al_que_pertenece(double parteReal, double parteImaginaria, Cuadrante cuadranteEsperado)
        {
            var unComplejo = Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            Assert.Equal(cuadranteEsperado, unComplejo.Cuadrante);
        }
    }
}
