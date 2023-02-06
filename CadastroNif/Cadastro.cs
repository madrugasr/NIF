using Nif.CamadaInterface;
using System;
using System.Windows.Forms;

namespace CadastroNif
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }

        private void SobreButton_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
        }

        private void ObterButton_Click(object sender, EventArgs e)
        {
            Obter obter = new Obter();
            obter.ShowDialog();
        }
    }
}
