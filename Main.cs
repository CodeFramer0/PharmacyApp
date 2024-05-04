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



            var data = database.GetCart();
           
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
            Dictionary<string, string> product = database.GetProduct(Int32.Parse(b.Tag.ToString()));
            database.AddBuyToCart(product["id"]);
            LoadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш заказ успешно оформлен, мы сообщим Вам в СМС, когда он будет готов к выдаче!");
            db database = new();
            database.ClearCart();
            LoadGrid();
        }
    }
}
