using CamadaNegocio;
using System;
using System.Windows.Forms;

namespace Nif.CamadaInterface
{
    public partial class Cadastrar : Form
    {
        
        public Cadastrar()
        {

            InitializeComponent();
            InicializarControleSexo();
            GerarNif();
        }

        #region Metodos
        /// <summary>
        /// Inicializa os definições do controle Sexo.
        /// </summary>
        private void InicializarControleSexo()
        {
            this.SexoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SexoComboBox.Items.Clear();
            this.SexoComboBox.Items.Add(CadastroNif.Properties.Resources.SexoMasculino);
            this.SexoComboBox.Items.Add(CadastroNif.Properties.Resources.SexoFeminino);

            this.SexoComboBox.SelectedIndex = (int) Sexo.Masculino;
        }

        public int GerarNif()
        {
            Random random = new Random();
            int nif = random.Next(000000000, 999999999);

            this.NifLabel.Text = nif.ToString();

            return nif;
        }
        
        /// <summary>
        /// Preenche o formulário com os dados do NIF.
        /// </summary>
        private void PreencherCadastroNIF(CamadaNegocio.NIF nif)
        {
            if (nif != null)
            {
                NomeCompletoTextBox.Text = nif.Nome;
                MoradaTextBox.Text = nif.Morada;
                SexoComboBox.SelectedIndex = (int)nif.Sexo;
                DataNascimentoDateTimePicker.Value = nif.DataNascimento;
                ProfissaoTextBox.Text = nif.Profissao;
                EmailTextBox.Text = nif.Email;
                TelefoneTextBox.Text = nif.Telefone;
            }
        }

        /// <summary>
        /// Criar um novo NIF.
        /// </summary>
        private void GravarNif()
        {
                     
            string erro = string.Empty;
            if (this.ValidarDado())
            {
                CamadaNegocio.NIF nif = PreencherDados();
                if (nif.Gravar(out erro))
                {
                    MessageBox.Show(CadastroNif.Properties.Resources.GravadoSucesso, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show($"Erro ao gravar. Erro=[{erro}]", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(CadastroNif.Properties.Resources.GravadoErro + erro, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimparDadosFormulário();
            }
        }

        public void LimparDadosFormulário()
        {
            NomeCompletoTextBox.Text = string.Empty;
            MoradaTextBox.Text = string.Empty;
            ProfissaoTextBox.Text = string.Empty;
            TelefoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            nifGeradoLabel.Text = string.Empty;
        }

        /// <summary>
        /// Recebe os dados do formulário.
        /// </summary>
        /// <returns>Retorna os dados inseridos.</returns>
        private CamadaNegocio.NIF PreencherDados()
        {
            CamadaNegocio.NIF nif = new CamadaNegocio.NIF()
            {
                Nome = this.NomeCompletoTextBox.Text,
                Morada = this.MoradaTextBox.Text,
                Sexo = (Sexo)this.SexoComboBox.SelectedIndex,
                DataNascimento = this.DataNascimentoDateTimePicker.Value,
                Profissao = this.ProfissaoTextBox.Text,
                Email = this.EmailTextBox.Text,
                Telefone = this.TelefoneTextBox.Text,
                Nif = Convert.ToInt32(this.NifLabel.Text)
            };
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
            string morada = this.MoradaTextBox.Text;
            DateTime dataNascimento = this.DataNascimentoDateTimePicker.Value;
            string profissao = this.ProfissaoTextBox.Text;
            string email = this.EmailTextBox.Text;
            string telefone = this.TelefoneTextBox.Text;

            DateTime today = DateTime.Today;


            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoNome, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(morada))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoMorada, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataNascimento >= today)
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoDataNascimento, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(profissao))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoProfissao, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoEmail, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show(CadastroNif.Properties.Resources.ValidaDadoTelefone, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        #endregion

        #region Eventos
        private void Gravar_Click(object sender, EventArgs e)
        {
            GravarNif();
        }
        #endregion
    }
}
