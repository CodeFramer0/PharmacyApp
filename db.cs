﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public void CreateUser(string login, string password, string full_name)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"INSERT OR IGNORE INTO Users(login,password,full_name) VALUES ('{login}','{password}','{full_name}')";
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
                reader.Close();
                connection.Close();
                return true;
            }
            reader.Close();
            connection.Close();
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

        public void CreatePeople(string full_name, string phone)
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"INSERT OR IGNORE INTO People(full_name,phone) VALUES ('{full_name}','{phone}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        
        public Dictionary<string, string> GetProduct (int product_id)
        {
            var product = new Dictionary<string, string>();
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"select product_id,name,price from Products where product_id='{product_id}'";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                product.Add("id", reader[0].ToString());
                product.Add("name", reader[1].ToString());
                product.Add("price", reader[2].ToString());
                reader.Close();
                connection.Close();
               
            }
            reader.Close();
            connection.Close();
            return product;
           

        }
        public void AddBuyToCart(string cart_item)
        { 
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"INSERT OR IGNORE INTO Carts(cart_item,count) VALUES ('{cart_item}','{1}')";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
            

        }
        public List<string[]> GetCart()
        {
            List<string[]> data = new List<string[]>();
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = "SELECT Products.name AS \"Название товара\"," +
                " Products.price AS \"Цена товара\"," +
                " COALESCE(Carts.count, 0) AS \"Количество товаров\"" +
                " FROM Products INNER JOIN ( SELECT cart_item, SUM(count)" +
                " AS count FROM Carts GROUP BY cart_item )" +
                " AS Carts ON Products.product_id = Carts.cart_item;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString() + " руб";
                data[data.Count - 1][2] = reader[2].ToString() + " товар(ов)";






            }
            reader.Close();
            connection.Close();
            return data;
        }
        public void ClearCart()
        {
            SQLiteConnection connection = createConnection();
            connection.Open();
            string query = $"DELETE FROM Carts";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}

