using Placares.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placares
{
    public partial class FormularioPrincipal : Form
    {
        public static List<Jogadora> jogadoras = new List<Jogadora>();

        BindingSource sourceConsulta;
        BindingSource sourceRank;

        public FormularioPrincipal()
        {
            InitializeComponent();
            CarregarListaJogadoras();

            CriaRankSource();

            BindingList<Jogadora> bindingList = new BindingList<Jogadora>(jogadoras);
            sourceConsulta = new BindingSource(bindingList, null);

            comboBox1.DataSource = sourceConsulta;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "nome";
        }

        private void CriaRankSource()
        {
            List<RankJogadorasViewModel> rankJogadoras = new List<RankJogadorasViewModel>();

            foreach (Jogadora item in jogadoras)
            {
                RankJogadorasViewModel rankJogadorasViewModel = new RankJogadorasViewModel();
                rankJogadorasViewModel.Nome = item.Nome;

                if (item.Pontos.Count > 0)
                {
                    rankJogadorasViewModel.MaxTemporada = item.Pontos.Max();
                }

                rankJogadoras.Add(rankJogadorasViewModel);
            }

            List<RankJogadorasViewModel> listaOrdenada = rankJogadoras.OrderByDescending(x => x.MaxTemporada).ToList();

            for (int i = 0; i < listaOrdenada.Count; i++)
            {
                RankJogadorasViewModel item = listaOrdenada[i];
                item.Posicao = (i + 1) + "°";
            }

            BindingList<RankJogadorasViewModel> bindingList = new BindingList<RankJogadorasViewModel>(listaOrdenada);
            sourceRank = new BindingSource(bindingList, null);

            dataGridView1.DataSource = sourceRank;
        }

        private void FormularioJogadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            CriaRankSource();
            sourceConsulta.ResetBindings(false);
        }

        private void FormularioPlacar_FormClosed(object sender, FormClosedEventArgs e)
        {
            CriaRankSource();
        }

        private void FormularioEditaJogadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            CriaRankSource();
            sourceConsulta.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormularioPlacar formularioPlacar = new FormularioPlacar();
            formularioPlacar.FormClosed += FormularioPlacar_FormClosed;
            formularioPlacar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioCadastroJogadora formularioJogadora = new FormularioCadastroJogadora();
            formularioJogadora.FormClosed += FormularioJogadora_FormClosed;
            formularioJogadora.ShowDialog();
        }

        public static Jogadora PegaJogadoraPorNome(string nomeSelecionado)
        {
            foreach (Jogadora jogadora in jogadoras)
            {
                if (jogadora.Nome == nomeSelecionado)
                {
                    return jogadora;
                }
            }
            return null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nomeJogadora = (string)comboBox1.SelectedValue;
            Jogadora jogadora = PegaJogadoraPorNome(nomeJogadora);

            if (jogadora != null)
            {
                FormularioEditaJogadora formularioEditaJogadora = new FormularioEditaJogadora(jogadora);
                formularioEditaJogadora.FormClosed += FormularioEditaJogadora_FormClosed;
                formularioEditaJogadora.ShowDialog();
            }
        }

        #region Banco

        /// <summary>
        /// Persiste os dados no arquivo JSON tmp/db.json.
        /// </summary>
        public static void PersistirJogadoras()
        {
            File.WriteAllText("tmp/db.json", Newtonsoft.Json.JsonConvert.SerializeObject(jogadoras));
        }

        /// <summary>
        /// Carrega a lista de todas as jogadoras cadastradas. 
        /// </summary>
        public void CarregarListaJogadoras()
        {
            if (!File.Exists("tmp/db.json"))
            {
                Directory.CreateDirectory("tmp");
                File.WriteAllText("tmp/db.json", "[]");
            }

            string db = File.ReadAllText("tmp/db.json");

            jogadoras = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Jogadora>>(db);
        }

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
