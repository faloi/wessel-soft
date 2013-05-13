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
        [InlineData(2, 0, 0)]
        [InlineData(-2, 0, Math.PI)]
        [InlineData(0, 2, Math.PI / 2)]
        [InlineData(0, -2, 1.5 * Math.PI)]
        public void Calculo_del_argumento_a_partir_de_binomica(double parteReal, double parteImaginaria, double argumentoEsperado)
        {
            var unComplejo = Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            Assert.Equal(argumentoEsperado, unComplejo.Argumento);            
        }
    }
}
