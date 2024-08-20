using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DataBase.Configuracao
{
    class Conexao
    {
        private string _servidor = "localhost";
        private string _porta = "";
        private string _usuario = "";
        private string _senha = "";
        private string _bancoDadosNome = "";
        private MySqlConnection connection;
        private MySqlCommand command;

        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta};user={_usuario};password={_senha}");
                connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                return command;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}