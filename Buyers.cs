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
    public partial class Buyers : Form
    {
        public Buyers()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var full_name = textBox1.Text;
            db database = new();
            database.CreateBuyer(full_name);
            LoadGrid();
        }
        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            db database = new();


            SQLiteConnection connection = database.createConnection();
            connection.Open();
            string query = "SELECT * FROM Buyers";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();





            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }
    }
}
