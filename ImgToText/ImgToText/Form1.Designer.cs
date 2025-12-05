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
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox4 = new GroupBox();
            label1 = new Label();
            button7 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            groupBox5 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            label2 = new Label();
            button8 = new Button();
            timer3 = new System.Windows.Forms.Timer(components);
            richTextBox2 = new RichTextBox();
            timer4 = new System.Windows.Forms.Timer(components);
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            textBox4 = new TextBox();
            button15 = new Button();
            button16 = new Button();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(12, 75);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Senha Padrão";
            textBox1.Size = new Size(516, 20);
            textBox1.TabIndex = 0;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(5, 10);
            button1.Name = "button1";
            button1.Size = new Size(260, 25);
            button1.TabIndex = 1;
            button1.Text = "Abrir imagem e gerar codigo TXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(5, 41);
            button2.Name = "button2";
            button2.Size = new Size(260, 25);
            button2.TabIndex = 4;
            button2.Text = "Decodificar Texto e exibir a imagem";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(4, 235);
            button3.Name = "button3";
            button3.Size = new Size(261, 25);
            button3.TabIndex = 6;
            button3.Text = "Salvar arquivo de texto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(674, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 103);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 266);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.AppWorkspace;
            richTextBox1.Location = new Point(5, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(260, 157);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.Enabled = false;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(674, 423);
            button6.Name = "button6";
            button6.Size = new Size(308, 25);
            button6.TabIndex = 7;
            button6.Text = "Salvar Imagem";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(6, 53);
            button5.Name = "button5";
            button5.Size = new Size(151, 25);
            button5.TabIndex = 2;
            button5.Text = "Processar Todos TXTs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(6, 22);
            button4.Name = "button4";
            button4.Size = new Size(151, 25);
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
            groupBox4.Location = new Point(290, 103);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 145);
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
            button7.BackColor = SystemColors.AppWorkspace;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(6, 22);
            button7.Name = "button7";
            button7.Size = new Size(366, 25);
            button7.TabIndex = 7;
            button7.Text = "Converter Todas Imagens para JPEG (diminue o tamanho)";
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
            groupBox5.Controls.Add(button10);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(button9);
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(richTextBox2);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(12, 370);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(482, 183);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Encriptador de Videos";
            // 
            // button10
            // 
            button10.BackColor = SystemColors.AppWorkspace;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(6, 53);
            button10.Name = "button10";
            button10.Size = new Size(231, 25);
            button10.TabIndex = 13;
            button10.Text = "Descriptografar Videos pra MP4 novamente";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.AppWorkspace;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(243, 152);
            button9.Name = "button9";
            button9.Size = new Size(231, 25);
            button9.TabIndex = 10;
            button9.Text = "Gerar Lista de Videos para o Site";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(6, 22);
            button8.Name = "button8";
            button8.Size = new Size(231, 25);
            button8.TabIndex = 7;
            button8.Text = "Criptografar Todos Videos";
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
            richTextBox2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.AppWorkspace;
            richTextBox2.Location = new Point(243, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(231, 124);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "\n";
            // 
            // timer4
            // 
            timer4.Interval = 3000;
            timer4.Tick += timer4_Tick;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.AppWorkspace;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.Location = new Point(290, 254);
            button11.Name = "button11";
            button11.Size = new Size(378, 25);
            button11.TabIndex = 14;
            button11.Text = "Apagar todos TXT da pasta atual";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.AppWorkspace;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ActiveCaptionText;
            button12.Location = new Point(290, 285);
            button12.Name = "button12";
            button12.Size = new Size(378, 25);
            button12.TabIndex = 15;
            button12.Text = "Apagar todas imagens da pasta atual";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.AppWorkspace;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ActiveCaptionText;
            button13.Location = new Point(290, 315);
            button13.Name = "button13";
            button13.Size = new Size(378, 25);
            button13.TabIndex = 16;
            button13.Text = "Apagar todos videos da pasta atual";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.AppWorkspace;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button14.ForeColor = SystemColors.ActiveCaptionText;
            button14.Location = new Point(290, 344);
            button14.Name = "button14";
            button14.Size = new Size(378, 25);
            button14.TabIndex = 17;
            button14.Text = "Apagar todos videos ENC da pasta atual";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(50, 50, 50);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ButtonFace;
            textBox4.Location = new Point(12, 12);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Diretorio das Imagens";
            textBox4.Size = new Size(425, 20);
            textBox4.TabIndex = 18;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.AppWorkspace;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ActiveCaptionText;
            button15.Location = new Point(443, 12);
            button15.Name = "button15";
            button15.Size = new Size(85, 20);
            button15.TabIndex = 19;
            button15.Text = "Buscar";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.AppWorkspace;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ActiveCaptionText;
            button16.Location = new Point(443, 44);
            button16.Name = "button16";
            button16.Size = new Size(85, 20);
            button16.TabIndex = 21;
            button16.Text = "Buscar";
            button16.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(50, 50, 50);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.ButtonFace;
            textBox5.Location = new Point(12, 44);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Diretorio dos Videos";
            textBox5.Size = new Size(425, 20);
            textBox5.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(500, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 178);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encriptador de Imagens";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(992, 565);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button16);
            Controls.Add(textBox5);
            Controls.Add(button15);
            Controls.Add(textBox4);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(button6);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Opacity = 0.98D;
            Text = "3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
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
        private System.Windows.Forms.Timer timer3;
        private Button button9;
        private RichTextBox richTextBox2;
        private Button button10;
        private System.Windows.Forms.Timer timer4;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private TextBox textBox4;
        private Button button15;
        private Button button16;
        private TextBox textBox5;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
    }
}
