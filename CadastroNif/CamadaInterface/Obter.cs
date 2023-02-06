using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Nif.CamadaInterface
{
    public partial class Obter : Form
    {
        
        public Obter()
        {

            InitializeComponent();
            InicializarControleSexo();
        }

        #region Metodos
        /// <summary>
        /// Inicializa os definições do controle Sexo.
        /// </summary>
        private void InicializarControleSexo()
        {
            this.SexoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SexoComboBox.Items.Clear();
            this.SexoComboBox.Items.Add("Masculino");
            this.SexoComboBox.Items.Add("Feminino");

            this.SexoComboBox.SelectedIndex = (int) Sexo.Masculino;
        }

        
        /// <summary>
        /// Preenche o formulário com os dados do NIF.
        /// </summary>
        private void PreencherCadastroNIF(CamadaNegocio.NIF nif)
        {
            if (nif != null)
            {
                NomeCompletoTextBox.Text = nif.Nome;
                MoradaLabel.Text = nif.Morada;
                SexoComboBox.SelectedIndex = (int)nif.Sexo;
                DataNascimentoDateTimePicker.Value = nif.DataNascimento;
                ProfissaoLabel.Text = nif.Profissao;
                EmailLabel.Text = nif.Email;
                TelefoneLabel.Text = nif.Telefone;
                NifLabel.Text = nif.Nif.ToString();
            }
        }

        private bool ValidarDado()
        {
            bool ok = false;

            string nome = this.NomeCompletoTextBox.Text;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoNome, 
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        private void ObterNif()
        {
            string nome = this.NomeCompletoTextBox.Text;
            
            string erro = string.Empty;
            if (this.ValidarDado())
            {
                CamadaNegocio.NIF nif = CamadaNegocio.NIF.Obter(nome, out erro);
                if (nif != null)
                {
                    PreencherCadastroNIF(nif);
                }
                else
                {
                    MessageBox.Show(CadastroNif.Properties.Resources.ObterErro + erro, 
                        Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
        }

        private void LimparCampos()
        {
            NomeCompletoTextBox.Text = string.Empty;
            MoradaLabel.Text = string.Empty;
            SexoComboBox.SelectedIndex = (int)Sexo.Masculino;
            DataNascimentoDateTimePicker.Value = DateTime.Now;
            ProfissaoLabel.Text = string.Empty;
            EmailLabel.Text = string.Empty;
            TelefoneLabel.Text = string.Empty;
            NifLabel.Text = string.Empty;
        }

        #endregion

        #region Eventos

        private void ObterButton_Click(object sender, EventArgs e)
        {
            ObterNif();
        }


        private void NomeCompletoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ObterNif();

            }
        }


        #endregion

        private void LimparDadosButton_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        
    }
}
