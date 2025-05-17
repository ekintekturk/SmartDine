using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GörselProgramlamaProje
{
    using MySql.Data.MySqlClient;

    public class Database
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;password=;database=smartdine_db;";

        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
