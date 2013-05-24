using System;
using System.Collections.Generic;
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
        public void Calculo_de_modulo(double parteReal, double parteImaginaria, double moduloEsperado) {
            var unComplejo = Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            Assert.Equal(moduloEsperado, unComplejo.Modulo, 4);
        }

        [Theory]
        [InlineData(2, 0, 0)]
        [InlineData(-2, 0, Math.PI)]
        [InlineData(0, 2, Math.PI / 2)]
        [InlineData(0, -2, 1.5 * Math.PI)]
        public void Calculo_del_argumento_a_partir_de_binomica(double parteReal, double parteImaginaria, double argumentoEsperado) {
            var unComplejo = Complejo.DesdeFormaBinomica(parteReal, parteImaginaria);
            Assert.Equal(argumentoEsperado, unComplejo.Argumento);            
        }

        [Theory]
        [InlineData(52, Math.PI)]
        [InlineData(1, Math.PI / 2)]
        public void Calculo_del_argumento_a_partir_de_polar(double modulo, double argumento) {
            var unComplejo = Complejo.DesdeFormaPolar(modulo, argumento);
            Assert.Equal(argumento, unComplejo.Argumento);
        }

        [Fact]
        public void Calculo_del_argumento_del_complejo_nulo()
        {
            Assert.Throws<ComplejoNuloException>(
                () => Complejo.Nulo.Argumento
            );
        }

        public static IEnumerable<object[]> Conjugado_del_complejo_fixture
        {
            get
            {
                return new[]
                {
                    new object[] {Complejo.DesdeFormaBinomica(4, 5), Complejo.DesdeFormaBinomica(4, -5)}
                };
            }
        }

        [Theory, PropertyData("Conjugado_del_complejo_fixture")]
        public void Conjugado_del_complejo(Complejo original, Complejo conjugado) {
            Assert.Equal(conjugado, original.Conjugado);
        }

        [Fact]
        public void Complejo_es_nulo() {
            Assert.False(Complejo.DesdeFormaBinomica(2, 0).EsNulo);
            Assert.False(Complejo.DesdeFormaBinomica(2, 0).EsNulo);
            Assert.True(Complejo.Nulo.EsNulo);
        }

        public static IEnumerable<object[]> Calculo_de_potencia_natural_fixture
        {
            get
            {
                return new[]
                {
                    new object[] {Complejo.DesdeFormaBinomica(3, 6), 2, Complejo.DesdeFormaBinomica(-27, 36)},
                    new object[] {Complejo.DesdeFormaBinomica(3, -6), 3, Complejo.DesdeFormaBinomica(-297, 54)},
                    new object[] {Complejo.DesdeFormaBinomica(3, 6), 1, Complejo.DesdeFormaBinomica(3, 6)},
                    new object[] {Complejo.DesdeFormaPolar(23, Math.PI), 2, Complejo.DesdeFormaPolar(529, 2 * Math.PI)}
                };
            }
        }

        [Theory, PropertyData("Calculo_de_potencia_natural_fixture")]
        public void Calculo_de_potencia_natural(Complejo c, int potencia, Complejo esperado) {
            Assert.Equal(esperado, c.ElevarA(potencia));
        }
    }
}
