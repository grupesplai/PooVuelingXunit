using System;
using Xunit;
using log4net;
using PooVuelingXunit;

namespace PooVuelingXunit.Unit.Test
{
    
    public class CalculadoraXunitTests
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void SumaTest()
        {   
            Assert.True(iCalculadora.Suma(2, 4) == 6);
            log.Info("La suma se ha realizado");
        }

        [Fact]
        public void RestaTest()
        {
            Assert.True(iCalculadora.Resta(4, 2) == 2);
            log.Info("La resta se ha realizado");
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.True(iCalculadora.Multiplicacion(2, 4) == 8);
            log.Info("La multiplicación se ha realizado");
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.True(iCalculadora.Division(4, 2) == 2);
            log.Info("La división se ha realizado");
        }
    }
}