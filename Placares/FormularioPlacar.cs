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
    public partial class FormularioPlacar : Form
    {
        public FormularioPlacar()
        {
            InitializeComponent();

            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "nome";
            comboBox1.DataSource = FormularioPrincipal.jogadoras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = (string)comboBox1.SelectedValue;
            int ponto = Convert.ToInt32(numericUpDown1.Value);

            Jogadora jogadoraSelecionado = FormularioPrincipal.PegaJogadoraPorNome(nomeSelecionado);

            // Verifica se o ponto informado pelo usuário é valido e se for, adiciona o Ponto na lista
            // da jogadora selecionada.
            if (jogadoraSelecionado.PontoEhValido(ponto))
            {
                jogadoraSelecionado.Pontos.Add(ponto);

                // Após alterado a lista de pontos, solicita que sejam salvos os dados no banco.
                FormularioPrincipal.PersistirJogadoras();
            }
            else
            {
                MessageBox.Show("Valor informado para o campo \"Placar\" deve ser maior que 0 e menor que 1000.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        } 
    }
}
