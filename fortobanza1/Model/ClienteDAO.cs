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
    internal class ClienteDAO
    {
      

        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }

        //Sempre o nome da classe
        public ClienteDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Cliente cli)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO TabelaClientes VALUES 
            (@email, @senha)";

            Command.Parameters.AddWithValue("@senha", cli.Senha);
            Command.Parameters.AddWithValue("@email", cli.Email);


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

        public void Update(Cliente prop)
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

        public void Excluir(int idCliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM TabelaClientes WHERE Id = @id";
            Command.Parameters.AddWithValue("@id", idCliente);
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
        public List<Cliente> ListarTodosUsuarios()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Cliente";

            List<Cliente> listaCliente = new List<Cliente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cliente cli = new Cliente(
                        (string)rd["Email"], (string)rd["Senha"], (int)rd["CodCLiente"]);
                    listaCliente.Add(cli);
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

            return listaCliente;
        }

       
    }
}
