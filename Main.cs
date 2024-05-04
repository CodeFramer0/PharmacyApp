using WinFormsApp1;
using System.Diagnostics;
using System.Data.SQLite;

namespace WinFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Form.ActiveForm.BackColor = Color.FromName("DarkSlateGray");


        }
        private void LoadGrid()
        {
            dataGridView1.Rows.Clear();
            db database = new();



            SQLiteConnection connection = database.createConnection();
            connection.Open();
            string query = "SELECT Products.name AS \"Название товара\"," +
                " Products.price AS \"Цена товара\"," +
                " COALESCE(Carts.count, 0) AS \"Количество товаров\"" +
                " FROM Products INNER JOIN ( SELECT cart_item, SUM(count)" +
                " AS count FROM Carts GROUP BY cart_item )" +
                " AS Carts ON Products.product_id = Carts.cart_item;";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString()+" руб";
                data[data.Count - 1][2] = reader[2].ToString()+" товар(ов)";






            }
            reader.Close();
            connection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void add_to_cart(object sender, EventArgs e)
        {
            db database = new();
            Button b = (Button)sender;
            Dictionary<string,string> product = database.GetProduct(Int32.Parse(b.Tag.ToString()));
            database.AddBuyToCart(product["id"]);
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
