using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placares.ViewModels
{
    /// <summary>
    /// Agrupa dados de uma posição do Rank de jogadoras.
    /// </summary>
    public class RankJogadorasViewModel
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public int MaxTemporada { get; set; }
    }
}
