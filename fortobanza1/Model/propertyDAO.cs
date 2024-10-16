using fortobanza1.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace fortobanza1.Model
{
    internal class propertyDAO
    {
        private object senha;
        private Object email;

        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public propertyDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(propertyDAO prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Property VALUES 
            (@senha, @email)";

            Command.Parameters.AddWithValue("@nome", prop.senha);
            Command.Parameters.AddWithValue("@email", prop.email);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        internal void Insert(Property property)
        {
            throw new NotImplementedException();
        }
    }
}