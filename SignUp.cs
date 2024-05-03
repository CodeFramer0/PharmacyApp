using WinFormsApp1;

namespace WinFormsApp2
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db database = new();
            var login = textBox1.Text;
            var password = textBox2.Text;
            var full_name = textBox3.Text;
            
            database.CreateUser(login, password, full_name);
            MessageBox.Show("Вы успешно зарегистрировались, Ваш логин: " + login);
            new Login().Show();
        
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox2.PasswordChar = (char)0; } else { textBox2.PasswordChar = (char)char.Parse("*"); }


        }
    }
}
