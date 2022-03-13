using Final_Facial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Facial.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarLogin(login, senha);
            if (!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }

            return tem;
        }

        public String cadastrar (string Email, string Senha, string confSenha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            this.mensagem = LoginDao.cadastrar(Email, Senha, confSenha);
            if (LoginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
