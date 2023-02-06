using System;
using System.Windows.Forms;

namespace Nif.CamadaInterface
{
    public partial class Eliminar : Form
    {
        
        public Eliminar()
        { 
            InitializeComponent();  
        }

        #region Metodo
        /// <summary>
        /// Validação dos dados de entrada no formulário.
        /// </summary>
        /// <returns>Retorna dados válidos ou inválidos.</returns>
        private bool ValidarDado()
        {
            bool ok = false;

            string nome = this.NomeCompletoTextBox.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoNome, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        private void EliminarNif()
        {
            if (ValidarDado())
            {

                string erro = string.Empty;
                if (this.ValidarDado())
                {
                    CamadaNegocio.NIF nif = PreencherDados();
                    if (MessageBox.Show(CadastroNif.Properties.Resources.EliminarCerteza, Application.ProductName, MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (nif.Eliminar(out erro))
                        {
                            MessageBox.Show(CadastroNif.Properties.Resources.EliminarSucesso, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(CadastroNif.Properties.Resources.EliminarErro, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }

                
            }
        }



        // <summary>
        // Recebe os dados do formulário.
        // </summary>
        //<returns>Retorna os dados inseridos.</returns>
        private CamadaNegocio.NIF PreencherDados()
        {
            CamadaNegocio.NIF nif = new CamadaNegocio.NIF()
            {
                Nome = this.NomeCompletoTextBox.Text,

            };
            return nif;
        }

        #endregion

        #region Eventos

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            EliminarNif();
        }

        

        #endregion


    }
}
