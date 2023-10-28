using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysql
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=worker");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            
            //если мы не подключены, то мы подключимся к базе данных
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
            //если мы подключены, то мы отключимся от базы данных
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
