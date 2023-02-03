using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class Nif
    {
        #region Metodos

        public bool Gravar(string nome, string morada, int sexo, DateTime dataNascimento, string profissao, string email, string telefone, int nif, out string erro)
        {
            erro = string.Empty;

            bool resultado = Nif.GravarNif(nome, morada, sexo, dataNascimento, profissao, email, telefone, nif, out erro);

            return resultado;
        }

        public static bool GravarNif(string nome, string morada, int sexo, DateTime dataNascimento, string profissao, string email, string telefone, int nif, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("GravarNif", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Nome", SqlDbType.NVarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nome;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Morada", System.Data.SqlDbType.NVarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = morada;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Sexo", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = sexo;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("DataNascimento", System.Data.SqlDbType.DateTime);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = dataNascimento;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Profissao", System.Data.SqlDbType.VarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = profissao;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Email", System.Data.SqlDbType.VarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = email;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Telefone", System.Data.SqlDbType.VarChar, 15);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = telefone;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlParameter = new SqlParameter("Nif", System.Data.SqlDbType.Int);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nif;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static bool Eliminar(string nome, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("EliminarNif", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Nome", SqlDbType.NVarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nome;

                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                resultado = true;
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }

        public static DataTable Listar(out string erro)
        {
            DataTable dataTable = null;
            erro = string.Empty;
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("ListarNif", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);

                dataTable = new DataTable();
                dataTable.Load(dataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return dataTable;
        }


        public static bool Obter(string nome, ref string morada, ref int sexo, ref DateTime dataNascimento, ref string profissao, ref string email, ref string telefone, out string erro)
        {
            bool resultado = false;
            erro = string.Empty;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("ObterNif", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("Nome", SqlDbType.NVarChar, 80);
                sqlParameter.Direction = System.Data.ParameterDirection.Input;
                sqlParameter.Value = nome;

                sqlCommand.Parameters.Add(sqlParameter);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    if (!sqlDataReader.IsDBNull(1))
                    {
                        nome = sqlDataReader.GetString(1);
                    }
                    if (!sqlDataReader.IsDBNull(2))
                    {
                        morada = sqlDataReader.GetString(2);
                    }
                    if (!sqlDataReader.IsDBNull(3))
                    {
                        sexo = sqlDataReader.GetInt32(3);
                    }
                    if (!sqlDataReader.IsDBNull(4))
                    {
                        dataNascimento = sqlDataReader.GetDateTime(4);
                    }
                    if (!sqlDataReader.IsDBNull(5))
                    {
                        profissao = sqlDataReader.GetString(5);
                    }
                    if (!sqlDataReader.IsDBNull(6))
                    {
                        email = sqlDataReader.GetString(6);
                    }
                    if (!sqlDataReader.IsDBNull(7))
                    {
                        telefone = sqlDataReader.GetString(7);
                    }
                    resultado = true;
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }

            return resultado;
        }
        #endregion
    }
}






