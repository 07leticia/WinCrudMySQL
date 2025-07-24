using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinCrudMySQL.Data
{
    public class DataBase
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
