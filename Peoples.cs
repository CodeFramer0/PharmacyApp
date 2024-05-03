using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp2
{
    public partial class Peoples : Form
    {
        public Peoples()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }

        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            db database = new();


            SQLiteConnection connection = database.createConnection();
            connection.Open();
            string query = "SELECT * FROM People";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();





            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var full_name = textBox1.Text;
            var phone = textBox2.Text;
            db database = new();
            database.CreatePeople(full_name, phone);
            LoadGrid();
        }
    }
}
