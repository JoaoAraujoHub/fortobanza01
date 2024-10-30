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
        private object senha;
        private Object email;

        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        public object Cmd { get; private set; }
        public object Con { get; private set; }

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

        public void Update(Property prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            Objective = @Objective,
            Email = @Email,
            Senha = @Senha
            WHERE Id = @Id";
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int idUsuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", idUsuario);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Usuario> ListarTodosUsuarios()
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Usuarios";

            List<Usuario> listaDeUsuarios = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario usuario = new Usuario((int)rd["Id"],
                        (string)rd["Nome"], (string)rd["Email"], (string)rd["Cpf"],
                        (string)rd["Telefone"], (string)rd["Usuario"],
                        "000");
                    listaDeUsuarios.Add(usuario);
                }
      
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeUsuarios;
        }
    }
