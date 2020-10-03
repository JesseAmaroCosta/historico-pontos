using Placares.ViewModels;
using System;
using System.Collections.Generic;

namespace Placares
{
    public class LeitorDePlacares
    {
        private Jogadora jogadoraAlvo;

        public LeitorDePlacares(Jogadora jogadora)
        {
           jogadoraAlvo = jogadora;
        }

        public List<PlacarViewModel> LerPlacares()
        {
            List<PlacarViewModel> resultado = new List<PlacarViewModel>();

            int maxTemporada = 0;
            int minTemporada = int.MaxValue;
            int recordMinimo = -1;
            int recordMaximo = -1;

            for (int i = 0; i < jogadoraAlvo.Pontos.Count; i++)
            {
                PlacarViewModel viewModel = new PlacarViewModel();

                int ponto = jogadoraAlvo.Pontos[i];

                viewModel.Jogo = i + 1;
                viewModel.Placar = ponto;

                if (ponto > maxTemporada)
                {
                    maxTemporada = ponto;
                    recordMaximo++;
                }

                viewModel.MaxTemporada = maxTemporada;
                viewModel.RecordMaximo = recordMaximo;

                if (ponto < minTemporada)
                {
                    minTemporada = ponto;
                    recordMinimo++;
                }

                viewModel.MinTemporada = minTemporada;
                viewModel.RecordMinimo = recordMinimo;

                resultado.Add(viewModel);
            }

            return resultado;
        }
    }
}