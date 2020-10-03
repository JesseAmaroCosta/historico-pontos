using Placares.ViewModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace Placares.Tests
{
    public class PlacaresTestes
    {
        /// <summary>
        /// Testa o método LeitorDePlacares.LerPlacares. Teste específico sobre o cálculo de Recorde Máximo.
        /// </summary>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(2)]
        public void TestaRecordeMaximo(int expected)
        {
            Jogadora jogadora = new Jogadora();
            jogadora.Pontos.Add(20);
            jogadora.Pontos.Add(30);
            jogadora.Pontos.Add(40);

            LeitorDePlacares leitorDePlacares = new LeitorDePlacares(jogadora);
            List<PlacarViewModel> placares = leitorDePlacares.LerPlacares();

            Assert.Equal(placares[2].RecordMaximo, expected);
        }

        /// <summary>
        /// Testa o método LeitorDePlacares.LerPlacares. Teste específico sobre o cálculo de Recorde Mínimo.
        /// </summary>
        /// <param name="recordMinimoA"></param>
        /// <param name="recordMinimoB"></param>
        [Theory]
        [InlineData(1, 2)]
        public void TestaRecordeMinimo(int recordMinimoA, int recordMinimoB)
        {
            Jogadora jogadora = new Jogadora();
            jogadora.Pontos.Add(40);
            jogadora.Pontos.Add(40);
            jogadora.Pontos.Add(20);
            jogadora.Pontos.Add(10);

            LeitorDePlacares leitorDePlacares = new LeitorDePlacares(jogadora);
            List<PlacarViewModel> placares = leitorDePlacares.LerPlacares();

            Assert.Equal(placares[2].RecordMinimo, recordMinimoA);
            Assert.Equal(placares[3].RecordMinimo, recordMinimoB);
        }
    }
}
