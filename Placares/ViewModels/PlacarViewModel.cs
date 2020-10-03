using System;
using System.Collections.Generic;
using System.Text;

namespace Placares.ViewModels
{
    /// <summary>
    /// Agrupa dados de um jogo específico.
    /// </summary>
    public class PlacarViewModel
    {
        public int Jogo { get; set; }
        public int Placar { get; set; }
        public int MaxTemporada { get; set; }
        public int MinTemporada { get; set; }
        public int RecordMinimo { get; set; }
        public int RecordMaximo { get; set; }
    }
}
