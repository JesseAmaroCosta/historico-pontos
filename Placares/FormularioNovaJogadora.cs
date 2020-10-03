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
    public partial class FormularioNovaJogadora : Form
    {
        public FormularioNovaJogadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um novo objeto de Jogadora para representar a jogadora
            // e insere o objeto na lista de jogadoras da aplicação.
            // Após isso, solicita que os dados sejam salvos no banco.

            Jogadora jogadora = new Jogadora();
            jogadora.Nome = textBox1.Text;

            FormularioPrincipal.jogadoras.Add(jogadora);
            FormularioPrincipal.PersistirJogadoras();

            Close();
        }
    }
}
