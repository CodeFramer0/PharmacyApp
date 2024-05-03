namespace WinFormsApp2
{
    partial class Admin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HoloLens MDL2 Assets", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(560, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 48);
            label1.TabIndex = 3;
            label1.Text = "АПТЕКА";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(521, 167);
            button1.Name = "button1";
            button1.Size = new Size(230, 82);
            button1.TabIndex = 4;
            button1.Text = "Покупатели";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(521, 282);
            button2.Name = "button2";
            button2.Size = new Size(230, 82);
            button2.TabIndex = 5;
            button2.Text = "Заказы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(521, 395);
            button3.Name = "button3";
            button3.Size = new Size(230, 82);
            button3.TabIndex = 6;
            button3.Text = "Сотрудники";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1035, 577);
            button4.Name = "button4";
            button4.Size = new Size(230, 82);
            button4.TabIndex = 7;
            button4.Text = "Аналитика";
            button4.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1321, 671);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}