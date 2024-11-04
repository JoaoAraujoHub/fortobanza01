using fortobanza1.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
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
        private object id;
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
                    "dados no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Update(Usuario prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            Objective = @Objective,
            Email = @Email,
            Senha = @Senha
            WHERE Id = @Id";
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int idUsuario)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";
            Command.Parameters.AddWithValue("@id", idUsuario);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Usuario> ListarTodosUsuarios()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Usuarios";

            List<Usuario> listaDeUsuarios = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario id = new Usuario((string)rd["id"],
                        (string)rd["Senha"], (string)rd["Email"],
                        "000");
                    listaDeUsuarios.Add(id);
                }

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeUsuarios;
        }
    }
}
