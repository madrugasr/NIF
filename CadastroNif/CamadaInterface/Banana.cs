using cadastro.CamadaInterface;
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

namespace Cadastro.CamadaInterface
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
            this.SexoComboBox.Items.Add("Masculino");
            this.SexoComboBox.Items.Add("Feminino");

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
        /// Novo NIF.
        /// </summary>
        private void NovoNif()
        {
            CamadaNegocio.Nif nif = CamadaNegocio.Nif.NovoNif();
            this.PreencherCadastroNIF(nif);
        }
        
        /// <summary>
        /// Preenche o formulário com os dados do NIF.
        /// </summary>
        private void PreencherCadastroNIF(CamadaNegocio.Nif nif)
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
            if (this.ValidarDados())
            {
                CamadaNegocio.Nif nif = PreencherDados();
                if (nif.Gravar(out erro))
                {                    
                    MessageBox.Show("Gravado com sucesso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro ao gravar. Erro=[{erro}]", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Recebe os dados do formulário.
        /// </summary>
        /// <returns>Retorna os dados inseridos.</returns>
        private CamadaNegocio.Nif PreencherDados()
        {

            CamadaNegocio.Nif nif = new CamadaNegocio.Nif()
            {
                Nome = this.NomeCompletoTextBox.Text,
                Morada = this.MoradaTextBox.Text,
                Sexo = (Sexo)this.SexoComboBox.SelectedIndex,
                DataNascimento = this.DataNascimentoDateTimePicker.Value,
                Profissao = this.ProfissaoTextBox.Text,
                Email = this.EmailTextBox.Text,
                Telefone = this.TelefoneTextBox.Text,
                NIF = this.NifLabel.Text



            };

            
            return nif;
        }

        /// <summary>
        /// Validação dos dados de entrada no formulário.
        /// </summary>
        /// <returns>Retorna dados válidos ou inválidos.</returns>
        private bool ValidarDados()
        {
            bool ok = true;

            string nome = this.NomeCompletoTextBox.Text;
            string morada = this.MoradaTextBox.Text;
            DateTime dataNascimento = this.DataNascimentoDateTimePicker.Value;
            string profissao = this.ProfissaoTextBox.Text;
            string email = this.EmailTextBox.Text;
            string telefone = this.TelefoneTextBox.Text;

            DateTime today = DateTime.Today;


            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo nome não pode estar vazia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(morada))
            {
                MessageBox.Show("O campo nome não pode estar vazia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataNascimento >= today)
            {
                MessageBox.Show("Data de nascimento não pode ser superior nem igual a data de hoje.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(profissao))
            {
                MessageBox.Show("O campo nome não pode estar vazia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("O campo nome não pode estar vazia.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(telefone))
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
            if (this.ValidarDados())
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

        private void Novo_Click(object sender, EventArgs e)
        {
            NovoNif();
        }

        private void Gravar_Click(object sender, EventArgs e)
        {
            GravarNif();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarNif();
        }

        

        private void Sobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        #endregion


    }
}
