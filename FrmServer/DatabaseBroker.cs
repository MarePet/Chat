using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmServer
{
    internal class DatabaseBroker
    {
        private static DatabaseBroker instance;
        private SqlConnection connection;
        private SqlCommand command;
        public static DatabaseBroker Instance
        {
            get
            {
                if(instance==null)instance = new DatabaseBroker();
                return instance;
            }
        }
        private DatabaseBroker()
        {
            connection = new SqlConnection($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"ROK - Februar 2023\";Integrated Security=True;");
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        internal Admin Login(Admin admin)
        {
            command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM Admin";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Admin a = new Admin() { 
                    Username = (string)reader[1],
                    Password = (string)reader[2],
                    Ime = (string)reader[3],
                    Prezime = (string)reader[4],
                };
                if(a.Username == admin.Username && a.Password == admin.Password)
                {
                    return a;
                }
            }
            reader.Close();
            return null;
        }

        internal User LoginUser(User user)
        {
            command = new SqlCommand("", connection);
            command.CommandText = "SELECT * FROM Users";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {
                    ID = (int)reader[0],
                    Username = (string)reader[1],
                    Password = (string)reader[2],
                };
                if (u.Username == user.Username && u.Password == user.Password)
                {
                    return u;
                }
            }
            reader.Close();
            return null;
        }
    }
}
