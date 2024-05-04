namespace WinFormsApp2
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button16 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label3 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            button6 = new Button();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox1.Location = new Point(12, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button16
            // 
            button16.ForeColor = SystemColors.ControlText;
            button16.Location = new Point(800, 247);
            button16.Name = "button16";
            button16.Size = new Size(348, 50);
            button16.TabIndex = 32;
            button16.Text = "Оформить заказ";
            button16.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(12, 247);
            button1.Name = "button1";
            button1.Size = new Size(176, 30);
            button1.TabIndex = 34;
            button1.Tag = "1";
            button1.Text = "В корзину";
            button1.UseVisualStyleBackColor = true;
            button1.Click += add_to_cart;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, price, amount });
            dataGridView1.Location = new Point(800, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(348, 180);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Товар";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Цена";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // amount
            // 
            amount.HeaderText = "Количество";
            amount.Name = "amount";
            amount.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 183);
            label1.Name = "label1";
            label1.Size = new Size(216, 42);
            label1.TabIndex = 36;
            label1.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(266, 183);
            label3.Name = "label3";
            label3.Size = new Size(216, 42);
            label3.TabIndex = 39;
            label3.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(266, 247);
            button2.Name = "button2";
            button2.Size = new Size(176, 30);
            button2.TabIndex = 38;
            button2.Tag = "2";
            button2.Text = "В корзину";
            button2.UseVisualStyleBackColor = true;
            button2.Click += add_to_cart;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox2.Location = new Point(266, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(510, 183);
            label4.Name = "label4";
            label4.Size = new Size(216, 42);
            label4.TabIndex = 42;
            label4.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(510, 247);
            button3.Name = "button3";
            button3.Size = new Size(176, 30);
            button3.TabIndex = 41;
            button3.Tag = "3";
            button3.Text = "В корзину";
            button3.UseVisualStyleBackColor = true;
            button3.Click += add_to_cart;
            // 
            // pictureBox3
            // 
            pictureBox3.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox3.Location = new Point(510, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(510, 450);
            label5.Name = "label5";
            label5.Size = new Size(216, 42);
            label5.TabIndex = 51;
            label5.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.ControlText;
            button4.ImeMode = ImeMode.NoControl;
            button4.Location = new Point(510, 514);
            button4.Name = "button4";
            button4.Size = new Size(176, 30);
            button4.TabIndex = 50;
            button4.Tag = "6";
            button4.Text = "В корзину";
            button4.UseVisualStyleBackColor = true;
            button4.Click += add_to_cart;
            // 
            // pictureBox4
            // 
            pictureBox4.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox4.Location = new Point(510, 313);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(176, 134);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(266, 450);
            label6.Name = "label6";
            label6.Size = new Size(216, 42);
            label6.TabIndex = 48;
            label6.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.ControlText;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(266, 514);
            button5.Name = "button5";
            button5.Size = new Size(176, 30);
            button5.TabIndex = 47;
            button5.Tag = "5";
            button5.Text = "В корзину";
            button5.UseVisualStyleBackColor = true;
            button5.Click += add_to_cart;
            // 
            // pictureBox5
            // 
            pictureBox5.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox5.Location = new Point(266, 313);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(176, 134);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 450);
            label7.Name = "label7";
            label7.Size = new Size(216, 42);
            label7.TabIndex = 45;
            label7.Text = "Бронхо-мунал капс 7мг N 10\r\nЦена: 664₽";
            // 
            // button6
            // 
            button6.ForeColor = SystemColors.ControlText;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(12, 514);
            button6.Name = "button6";
            button6.Size = new Size(176, 30);
            button6.TabIndex = 44;
            button6.Tag = "4";
            button6.Text = "В корзину";
            button6.UseVisualStyleBackColor = true;
            button6.Click += add_to_cart;
            // 
            // pictureBox6
            // 
            pictureBox6.ImageLocation = "https://apteka-kartinki.ru/wa-data/public/shop/products/36/56/25636/images/45520/45520.300x0.jpg";
            pictureBox6.Location = new Point(12, 313);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(176, 134);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 43;
            pictureBox6.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1151, 681);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(pictureBox5);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(pictureBox6);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button16);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1167, 720);
            Name = "Main";
            Text = "Добавить в корзину";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label16;
        private Button button17;
        private PictureBox pictureBox17;
        private Label label17;
        private Button button18;
        private PictureBox pictureBox18;
        private Label label18;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button16;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn amount;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button3;
        private PictureBox pictureBox3;
        private Label label5;
        private Button button4;
        private PictureBox pictureBox4;
        private Label label6;
        private Button button5;
        private PictureBox pictureBox5;
        private Label label7;
        private Button button6;
        private PictureBox pictureBox6;
    }
}