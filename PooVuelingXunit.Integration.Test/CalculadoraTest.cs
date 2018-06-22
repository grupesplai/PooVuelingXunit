using System;
using Xunit;
using log4net;

namespace PooVuelingXunit.Integration.Test
{
    public class CalculadoraTest
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Fact]
        public void SumaTest()
        {
            //podria haber creado un objeto de tipo Calculadora con referencia a la interfaz, pero quería pobrarlo de otra manera.
            var sut = new Calculadora();
            var result = sut.Suma(2, 2);
            Assert.True(4 == result);
            log.Info("La suma se ha realizado");
        }

        [Fact]
        public void RestaTest()
        {
            var sut = new Calculadora();
            var result = sut.Resta(4, 2);
            Assert.True(2 == result);
            log.Info("La resta se ha realizado");
        }

        [Fact]
        public void MultilicacionTest()
        {
            var sut = new Calculadora();
            var result = sut.Multiplicacion(2, 2);
            Assert.True(4 == result);
            log.Info("La multiplicación se ha realizado");
        }

        [Fact]
        public void DivisionTest()
        {
            var sut = new Calculadora();
            var result = sut.Division(4, 2);
            Assert.True(2 == result);
            log.Info("La división a se ha realizado");
        }
    }
}
