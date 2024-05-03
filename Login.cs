using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            db database = new();

            bool check = database.CheckUser(login, password);
            if (check)
            {
                MessageBox.Show("Вы успешно авторизированы");
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Проверьте правильность логина или пароля");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox2.PasswordChar = (char)0; } else { textBox2.PasswordChar = (char)char.Parse("*"); }
        }
    }
}
