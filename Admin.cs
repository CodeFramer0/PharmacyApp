using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Form.ActiveForm.BackColor = Color.FromName("DarkSlateGray");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Buyers().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Offers().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Peoples().Show();
            this.Hide();
        }
    }
}
