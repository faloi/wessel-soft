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
        [InlineData(52, Math.PI, 0)]
        [InlineData(1, Math.PI / 2)]
        [InlineData(0, 1.5 * Math.PI)]
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

        [Theory]
        [InlineData(Complejo.DesdeFormaBinomica(4,5))]
        public void Conjugado_del_complejo(Complejo c) {
            var conjugado = c.Conjugado;
            Assert.Equal(c.ParteReal, conjugado.ParteReal);
            Assert.Equal(-c.ParteImaginaria, conjugado.ParteImaginaria);
        }

        [Fact]
        public void Complejo_es_nulo() {
            Assert.False(Complejo.DesdeFormaBinomica(2, 0).EsNulo);
            Assert.False(Complejo.DesdeFormaBinomica(2, 0).EsNulo);
            Assert.True(Complejo.Nulo.EsNulo);
        }

        [Theory]
        [InlineData(Complejo.DesdeFormaBinomica(3, 6), 2, Complejo.DesdeFormaBinomica(-27, 36))]
        [InlineData(Complejo.DesdeFormaBinomica(3, -6), 3, Complejo.DesdeFormaBinomica(-297, 54))]
        [InlineData(Complejo.DesdeFormaBinomica(3, 6), 1, Complejo.DesdeFormaBinomica(3, 6))]
        [InlineData(Complejo.DesdeFormaPolar(23, Math.PI), 2, Complejo.DesdeFormaPolar(529, 2 * Math.PI))]
        public void Calculo_de_potencia_natural(Complejo c, uint potencia, Complejo esperado) {
            Assert.Equal(esperado, c.ElevarA(potencia));
        }

        [Theory]
        [InlineData(Complejo.DesdeFormaPolar(1, 6), 2, Complejo.DesdeFormaPolar(0, 6))]
        [InlineData(Complejo.DesdeFormaPolar(5, 6), 2, Complejo.DesdeFormaPolar(1.6, 6))]
        [InlineData(Complejo.DesdeFormaPolar(8, 6), 2, Complejo.DesdeFormaPolar(2.07, 6))]
        public void Calculo_de_logaritmo_natural(Complejo c, Complejo esperado) {
            var logaritmo = c.LogaritmoNatural();
            Assert.True(Math.Abs(esperado.ParteReal - logaritmo.ParteReal) < 0.5);
            Assert.True(Math.Abs(esperado.ParteImaginaria - logaritmo.ParteImaginaria) < 0.5);
        }

        public void Calculo_de_raiz() {
            Complejo.DesdeFormaBinomica(2, 3).RaizN(3);
            //(va a romper porque no está hecho)
        }
    }
}
