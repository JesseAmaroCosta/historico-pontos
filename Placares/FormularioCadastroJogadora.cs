using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Placares
{
    public partial class FormularioCadastroJogadora : Form
    {
        int tamanhoDaListAoAbrir = 0;
        BindingSource source;

        public FormularioCadastroJogadora()
        {
            InitializeComponent();

            // Cria um objeto BindingList para conectar a lista de jogadoras da aplicação a grid na tela.
            BindingList<Jogadora> bindingList = new BindingList<Jogadora>(FormularioPrincipal.jogadoras);
            source = new BindingSource(bindingList, null);

            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guarda a quantidade de jogadoras cadastradas antes de abrir a janela de nova jogadora.
            // Depois, esse valor será utilizado para identificar se uma jogadora foi adicionada ou se usuário
            // fechou a janela sem realizar um cadastro.
            tamanhoDaListAoAbrir = FormularioPrincipal.jogadoras.Count;

            FormularioNovaJogadora formularioNovaJogadora = new FormularioNovaJogadora();
            formularioNovaJogadora.FormClosed += FormularioNovaJogadora_FormClosed;
            formularioNovaJogadora.ShowDialog();
        }

        private void FormularioNovaJogadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verifica se o usuário cadastrou uma nova jogadora verificando se o 
            // tamanho da lista foi alterado.
            if (tamanhoDaListAoAbrir != FormularioPrincipal.jogadoras.Count)
            {
                // Solicita que a grid seja atualizada com a nova jogadora adicionada.
                source.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Procura na grid qual linha está selecionada para obter o dado da jogadora.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    Jogadora jogadora = (Jogadora)row.DataBoundItem;
                    
                    if (jogadora != null)
                    {
                        // Quando o objeto é obtido, o remove da lista e solicita para que os dados no banco sejam salvos.
                        FormularioPrincipal.jogadoras.Remove(jogadora);
                        FormularioPrincipal.PersistirJogadoras();
                    }
                }
            }

            // Solicita que a grid seja atualizada com a nova jogadora adicionada.
            source.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
