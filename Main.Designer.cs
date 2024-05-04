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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://12bb6ecf-bda5-4c99-816b-12bda79f6bd9.selcdn.net/upload//Photo_Tovar/1457400.jpg";
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
            button16.Location = new Point(800, 313);
            button16.Name = "button16";
            button16.Size = new Size(348, 50);
            button16.TabIndex = 32;
            button16.Text = "Оформить заказ";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
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
            label3.Size = new Size(201, 42);
            label3.TabIndex = 39;
            label3.Text = "Гептрал тб п/о 400мг N 20\r\nЦена: 1521₽";
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
            pictureBox2.ImageLocation = "https://12bb6ecf-bda5-4c99-816b-12bda79f6bd9.selcdn.net/upload//Photo_Tovar/1192600_1711540963.jpg";
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
            pictureBox3.ImageLocation = "https://12bb6ecf-bda5-4c99-816b-12bda79f6bd9.selcdn.net/upload//Photo_Tovar/1864700.jpg";
            pictureBox3.Location = new Point(510, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1151, 681);
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
    }
}