namespace ImgToText
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button6 = new Button();
            groupBox2 = new GroupBox();
            button5 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4 = new GroupBox();
            label1 = new Label();
            button7 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            groupBox5 = new GroupBox();
            button9 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            button8 = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Senha";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Location = new Point(6, 55);
            button1.Name = "button1";
            button1.Size = new Size(180, 36);
            button1.TabIndex = 1;
            button1.Text = "Abrir imagem e gerar codigo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(50, 50, 50);
            richTextBox1.ForeColor = SystemColors.AppWorkspace;
            richTextBox1.Location = new Point(6, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(180, 115);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "\n";
            richTextBox1.MouseHover += richTextBox1_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.AppWorkspace;
            button2.Location = new Point(6, 140);
            button2.Name = "button2";
            button2.Size = new Size(180, 36);
            button2.TabIndex = 4;
            button2.Text = "Decodificar e exibir a imagem";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 50, 50);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.AppWorkspace;
            button3.Location = new Point(211, 53);
            button3.Name = "button3";
            button3.Size = new Size(308, 25);
            button3.TabIndex = 6;
            button3.Text = "Salvar arquivo de texto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(742, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 101);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Location = new Point(12, 119);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 191);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(50, 50, 50);
            button6.Enabled = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.AppWorkspace;
            button6.Location = new Point(211, 21);
            button6.Name = "button6";
            button6.Size = new Size(308, 25);
            button6.TabIndex = 7;
            button6.Text = "Salvar Imagem";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(12, 316);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 142);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(50, 50, 50);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.AppWorkspace;
            button5.Location = new Point(6, 97);
            button5.Name = "button5";
            button5.Size = new Size(180, 36);
            button5.TabIndex = 2;
            button5.Text = "Processar Todos TXTs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(50, 50, 50);
            textBox2.ForeColor = SystemColors.AppWorkspace;
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Senha";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(50, 50, 50);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.AppWorkspace;
            button4.Location = new Point(6, 55);
            button4.Name = "button4";
            button4.Size = new Size(180, 36);
            button4.TabIndex = 1;
            button4.Text = "Processar Todas Imagens";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(button7);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(211, 119);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(308, 141);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Converter Imagens para JPEG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(50, 50, 50);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.AppWorkspace;
            button7.Location = new Point(6, 22);
            button7.Name = "button7";
            button7.Size = new Size(296, 25);
            button7.TabIndex = 7;
            button7.Text = "Converter Imagens da Pasta do EXE";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button9);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(button8);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(211, 275);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(308, 183);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Encriptador de Videos";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(50, 50, 50);
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = SystemColors.AppWorkspace;
            button9.Location = new Point(6, 82);
            button9.Name = "button9";
            button9.Size = new Size(296, 25);
            button9.TabIndex = 10;
            button9.Text = "Gerar Lista de Videos para o Site";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(50, 50, 50);
            textBox3.ForeColor = SystemColors.ButtonFace;
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Senha";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 117);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(50, 50, 50);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.AppWorkspace;
            button8.Location = new Point(6, 51);
            button8.Name = "button8";
            button8.Size = new Size(296, 25);
            button8.TabIndex = 7;
            button8.Text = "Converter Videos da Pasta do EXE";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // timer3
            // 
            timer3.Interval = 3000;
            timer3.Tick += timer3_Tick;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(50, 50, 50);
            richTextBox2.ForeColor = SystemColors.AppWorkspace;
            richTextBox2.Location = new Point(525, 23);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(211, 296);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1013, 477);
            Controls.Add(richTextBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Opacity = 0.98D;
            Text = "3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox4;
        private Button button7;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
        private GroupBox groupBox5;
        private Label label2;
        private Button button8;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer3;
        private Button button9;
        private RichTextBox richTextBox2;
    }
}
