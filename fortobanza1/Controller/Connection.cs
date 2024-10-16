using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022498SOUCE";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringConnection =
                @"data source = " + Server
                + "; initial catalog = " + DataBase
                + "; user id =" + Username
                + "; password =" + Password
                + "; encrypt = false";

            con = new SqlConnection(stringConnection);
            con.Open();
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

        }
        public SqlConnection ReturnConnection ()
        { return con; }
    }
}