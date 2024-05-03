using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WinFormsApp1
{
    public class db
    {


        public SQLiteConnection createConnection()
        {
            string connectionString = "Data Source=database.sqlite";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }


        public void CreateUser(string login, string password,string full_name)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            var query = $"INSERT OR IGNORE INTO Users(login,password,full_name) VALUES ('{login}','{password}','{full_name}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public bool CheckUser(string login, string password)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            var query = $"select * from Users where login='{login}' and password ='{password}' ";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            return false;
        }

       public void CreateBuyer(string full_name)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            var query = $"INSERT OR IGNORE INTO Buyers(full_name) VALUES ('{full_name}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        
        public void CreateOffer(string date,string number,string list,string sum)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            var query = $"INSERT OR IGNORE INTO Offers(date,Number,list,sum) VALUES ('{date}','{number}','{list}','{sum}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void CreatePeople(string full_name, string phone)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            var query = $"INSERT OR IGNORE INTO People(full_name,phone) VALUES ('{full_name}','{phone}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

    }
}

