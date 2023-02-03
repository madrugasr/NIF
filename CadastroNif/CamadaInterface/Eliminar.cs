using CadastroNif.CamadaInterface;
using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliminarNif.CamadaInterface
{
    public partial class Eliminar : Form
    {
        
        public Eliminar()
        {
            InitializeComponent();
        }

        #region Metodos
        /// <summary>
        /// Recebe os dados do formulário.
        /// </summary>
        /// <returns>Retorna os dados inseridos.</returns>
        private CamadaNegocio.Nif PreencherDados()
        {
            CamadaNegocio.Nif nif = new CamadaNegocio.Nif();
            nif.Nome = this.NomeCompletoTextBox.Text;

            return nif;
        }
        
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
                MessageBox.Show("O campo nome não pode estar vazia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
            else
            {
                ok = true;
            }

            return ok;
        }

        private void EliminarNif()
        {
            if (this.ValidarDado())
            {
                CamadaNegocio.Nif nif = this.PreencherDados();
                
                if (nif.Eliminar(out string erro))
                {
                    MessageBox.Show("Eliminado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro a eliminar. Erro=[{erro}]", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Eventos   
        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarNif();
        }
        #endregion
    }
}
