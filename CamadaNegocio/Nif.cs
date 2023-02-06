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
    public class NIF
    {
        #region Construtores

        public NIF()
        {

        }

        public NIF(string nome, string morada, Sexo sexo, DateTime dataNascimento, string profissao,
                    string email, string telefone, int nif)
            : this ()
        {
            this.nome = nome;
            this.morada = morada;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.profissao = profissao;
            this.email = email;
            this.telefone = telefone;
            this.nif = nif;
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
        
        public int Nif
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
        
        public static NIF NovoNif()
        {
            NIF Nif = new NIF();
            Nif.Novo();

            return Nif;
        }

        public bool Gravar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;
            
            ok = CamadaDados.NIF.GravarNif(this.Nome, this.Morada, (int) this.Sexo, this.DataNascimento, 
                this.Profissao, this.Email, this.Telefone, this.Nif, out erro);

            return ok;
        }

        public bool Eliminar(out string erro)
        {
            bool ok = false;
            erro = string.Empty;

            ok = CamadaDados.NIF.Eliminar(this.Nome, out erro);

            return ok;
        }

        public static NIF Obter(string nome, out string erro)
        {
            NIF Nif = null;
            erro = string.Empty;

            string morada = string.Empty;
            int sexo = 0;
            DateTime dataNascimento = DateTime.Today;
            string profissao = string.Empty;
            string email = string.Empty;
            string telefone = string.Empty;
            int nif = 0;


            bool ok = CamadaDados.NIF.Obter(nome, ref morada, ref sexo, ref dataNascimento, ref profissao, ref email, ref telefone, ref nif, out erro);
            
            if (ok)
            {
                Nif = new NIF(nome, morada, (Sexo)sexo, dataNascimento, profissao, email, telefone, nif);
            }

            return Nif;
        }

        #endregion
    }

    
}
