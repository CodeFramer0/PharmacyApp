namespace WinFormsApp2
{
    partial class Login
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(358, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 66);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-51, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 107);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 172);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 2;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(214, 244);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GrayText;
            textBox1.Location = new Point(307, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.GrayText;
            textBox2.Location = new Point(307, 248);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("HoloLens MDL2 Assets", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(307, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(214, 348);
            button1.Name = "button1";
            button1.Size = new Size(386, 50);
            button1.TabIndex = 7;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(366, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нет аккаунта?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}