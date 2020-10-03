using Placares.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placares
{
    public partial class FormularioEditaJogadora : Form
    {
        Jogadora jogadoraDaTela;

        public FormularioEditaJogadora(Jogadora jogadora)
        {
            InitializeComponent();

            jogadoraDaTela = jogadora;
            textBox1.Text = jogadora.Nome;

            // Obtem os placares processados na classe LeitorDePlacares.
            LeitorDePlacares leitorDePlacares = new LeitorDePlacares(jogadora);
            List<PlacarViewModel> placares = leitorDePlacares.LerPlacares();

            dataGridView1.DataSource = placares;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Altera e salva o novo nome da jogadora apenas se o nome foi alterado.
            if (textBox1.Text != jogadoraDaTela.Nome)
            {
                jogadoraDaTela.Nome = textBox1.Text;
                FormularioPrincipal.PersistirJogadoras();
            }
            Close();
        }
    }
}
