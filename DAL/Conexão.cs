using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Final_Facial.DAL
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();
        public Conexão()
        {
            con.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BancoFacial;Data Source=DESKTOP-97ALHNI";
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
