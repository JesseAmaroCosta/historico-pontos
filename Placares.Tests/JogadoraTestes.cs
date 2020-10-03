using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Placares.Tests
{
    public class JogadoraTestes
    {
        [Theory]
        [InlineData(1001, false)]
        [InlineData(-1, false)]
        [InlineData(50, true)]
        public void AdicionaPonto(int pontoDeTeste, bool expected)
        {
            Jogadora jogadora = new Jogadora();
            Assert.Equal(jogadora.PontoEhValido(pontoDeTeste), expected);
        }
    }
}
