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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button16.Location = new Point(908, 313);
            button16.Name = "button16";
            button16.Size = new Size(231, 30);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1151, 681);
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
    }
}