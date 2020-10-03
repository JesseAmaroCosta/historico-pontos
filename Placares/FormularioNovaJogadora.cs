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
            Jogadora jogadora = new Jogadora();
            jogadora.Nome = textBox1.Text;

            FormularioPrincipal.jogadoras.Add(jogadora);
            FormularioPrincipal.PersistirJogadoras();

            Close();
        }
    }
}
