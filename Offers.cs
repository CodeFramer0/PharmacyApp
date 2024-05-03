using System.Data.SQLite;
using WinFormsApp1;

namespace WinFormsApp2
{
    public partial class Offers : Form
    {
        public Offers()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void button2_Click(object sender, EventArgs e)
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
            string query = "SELECT * FROM Offers";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();





            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Text;
            var number = textBox1.Text;
            var list = textBox2.Text;
            var sum = textBox3.Text;
            db database = new();
            database.CreateOffer(date, number, list, sum);
            LoadGrid();
        }
    }
}
