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
        public void Calculo_de_modulo(double parteReal, double parteImaginaria, double modulo)
        {
            var unComplejo = new Complejo(parteReal, parteImaginaria);
            Assert.Equal(modulo, unComplejo.Modulo, 4);
        }
    }
}
