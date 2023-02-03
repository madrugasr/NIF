using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CamadaNegocio
{
    public enum Sexo
    {
        Masculino = 0,
        Feminino = 1
    }
    public class Nif
    {
        #region Construtores

        public Nif()
        {

        }

        public Nif(string nome, string morada, Sexo sexo, DateTime dataNascimento, string profissao, 
                    string email, string telefone)
            : this()
        {
            this.nome = nome;
            this.morada = morada;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.profissao = profissao;
            this.email = email;
            this.telefone = telefone;
        }

        #endregion

        #region Propriedades

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private string morada;

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        private string profissao;
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private int nif;
        
        public int NIF
        {
            get { return nif; }
            set { nif = value; }
        }



        #endregion

        #region Metodos

        public void Novo()
        {
            this.Nome = string.Empty;
            this.Morada = string.Empty;
            this.Sexo = Sexo.Masculino;
            this.DataNascimento = DateTime.Today;
            this.Profissao = string.Empty;
            this.Email = string.Empty;
            this.Telefone = string.Empty;          
        }
        
        public static Nif NovoNif()
        {
            Nif nif = new Nif();
            nif.Novo();

            return nif;
        }

        public bool Gravar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;
            
            ok = CamadaDados.Nif.GravarNif(this.Nome, this.Morada, (int) this.Sexo, this.DataNascimento, 
                this.Profissao, this.Email, this.Telefone, this.NIF, out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            ok = CamadaDados.Nif.Eliminar(this.Nome, out erro);

            return ok;
        }

        public static Nif ObterNif(string nome, out string erro)
        {
            Nif nif = null;
            erro = string.Empty;

            string morada = string.Empty;
            int sexo = 0;
            DateTime dataNascimento = DateTime.Today;
            string profissao = string.Empty;
            string email = string.Empty;
            string telefone = string.Empty;
            

            bool ok = CamadaDados.Nif.Obter(nome, ref morada, ref sexo, ref dataNascimento, ref profissao, ref email, ref telefone, out erro);

            if (ok)
            {
                nif = new Nif(nome, morada, (Sexo)sexo, dataNascimento, profissao, email, telefone);
            }

            return nif;
        }
     
        #endregion      
    }

    
}
