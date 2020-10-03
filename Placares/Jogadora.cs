using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Placares
{
    /// <summary>
    /// Representa uma jogadora cadastrada na aplicação.
    /// </summary>
    public class Jogadora
    {
        public Jogadora()
        {
            Pontos = new List<int>();
        }

        public string Nome { get; set; }
        public List<int> Pontos { get; set; }

        public bool PontoEhValido(int ponto)
        {
            bool valido = true;

            if (ponto < 0 || ponto > 1000)
            {
                valido = false;
            }

            return valido;
        }
    }
}
