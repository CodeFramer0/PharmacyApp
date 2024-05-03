namespace WinFormsApp2
{
    partial class SignUp
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(182, 320);
            button1.Name = "button1";
            button1.Size = new Size(386, 50);
            button1.TabIndex = 15;
            button1.Text = "Создать аккаунт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("HoloLens MDL2 Assets", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(320, 233);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 204);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(293, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 23);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-122, 258);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 11;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-122, 186);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 10;
            label2.Text = "Логин:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-397, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 107);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(646, 10);
            label1.Name = "label1";
            label1.Size = new Size(256, 66);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("HoloLens MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(182, 388);
            button2.Name = "button2";
            button2.Size = new Size(386, 50);
            button2.TabIndex = 16;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(157, 204);
            label4.Name = "label4";
            label4.Size = new Size(86, 27);
            label4.TabIndex = 18;
            label4.Text = "Пароль:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(157, 148);
            label5.Name = "label5";
            label5.Size = new Size(74, 27);
            label5.TabIndex = 17;
            label5.Text = "Логин:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(157, 268);
            label6.Name = "label6";
            label6.Size = new Size(66, 27);
            label6.TabIndex = 20;
            label6.Text = "ФИО:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 23);
            textBox3.TabIndex = 21;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
    }
}