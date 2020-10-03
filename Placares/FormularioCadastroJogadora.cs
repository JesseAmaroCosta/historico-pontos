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

            BindingList<Jogadora> bindingList = new BindingList<Jogadora>(FormularioPrincipal.jogadoras);
            source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tamanhoDaListAoAbrir = FormularioPrincipal.jogadoras.Count;

            FormularioNovaJogadora formularioNovaJogadora = new FormularioNovaJogadora();
            formularioNovaJogadora.FormClosed += FormularioNovaJogadora_FormClosed;
            formularioNovaJogadora.ShowDialog();
        }

        private void FormularioNovaJogadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tamanhoDaListAoAbrir != FormularioPrincipal.jogadoras.Count)
            {
                source.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    Jogadora jogadora = (Jogadora)row.DataBoundItem;
                    
                    if (jogadora != null)
                    {
                        FormularioPrincipal.jogadoras.Remove(jogadora);
                        FormularioPrincipal.PersistirJogadoras();
                    }
                }
            }

            source.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
