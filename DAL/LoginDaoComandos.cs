using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Facial.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {
            //Comandos SQL para verificar se tem no Banco
            cmd.CommandText = "select * from CadastrarLogin where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }

        public string cadastrar(String Email, string Senha, string confSenha)
        {
            tem = false;
            //Comandos sql para fazer o cadastro no Banco
            if (Senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into CadastrarLogin values (@E,@S);";
                cmd.Parameters.AddWithValue("@E", Email);
                cmd.Parameters.AddWithValue("@S", Senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch(SqlException)
                {
                    this.mensagem = "Erro com banco de dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            cmd.CommandText = "";
            return mensagem;
        }

    }
}
