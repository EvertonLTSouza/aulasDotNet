using System;
using Xunit;
using Aulas_dotNet;

namespace TestExercicios
{
    public class UnitTest1
    {
        [Fact]
        public void TestDecisaoEx1Maior()
        {
            var maior = new Maior();
            Assert.Equal("2", Convert.ToString(maior.MaiorNumero(1, 2)));
        }
    }
}
