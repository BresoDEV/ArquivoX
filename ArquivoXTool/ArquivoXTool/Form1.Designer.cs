namespace ArquivoXTool
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button12 = new Button();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            groupBox3 = new GroupBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            groupBox4 = new GroupBox();
            button18 = new Button();
            button11 = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            timer_compactador = new System.Windows.Forms.Timer(components);
            button19 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 416);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(408, 5);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(121, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pasta de imagens";
            textBox1.Size = new Size(281, 16);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DimGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(121, 40);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Pasta de Videos";
            textBox2.Size = new Size(281, 16);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(408, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(121, 70);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Senha";
            textBox3.Size = new Size(362, 16);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(6, 22);
            button3.Name = "button3";
            button3.Size = new Size(129, 23);
            button3.TabIndex = 6;
            button3.Text = "IMG -> TXT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(6, 51);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 7;
            button4.Text = "TXT -> IMG";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(141, 22);
            button5.Name = "button5";
            button5.Size = new Size(129, 23);
            button5.TabIndex = 8;
            button5.Text = "MP4 -> ENC";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(141, 51);
            button6.Name = "button6";
            button6.Size = new Size(129, 23);
            button6.TabIndex = 9;
            button6.Text = "ENC -> MP4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 81);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todos arquivos da pasta";
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gray;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(6, 80);
            textBox4.MaxLength = 999999999;
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 109);
            textBox4.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 12;
            label2.Text = "Pasta de Imagens:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 13;
            label3.Text = "Pasta de Videos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 71);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 14;
            label4.Text = "Senha padrão:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(textBox4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 195);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Processar Arquivos Unitarios";
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(141, 51);
            button10.Name = "button10";
            button10.Size = new Size(129, 23);
            button10.TabIndex = 19;
            button10.Text = "ENC -> MP4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(6, 51);
            button9.Name = "button9";
            button9.Size = new Size(129, 23);
            button9.TabIndex = 18;
            button9.Text = "MP4 -> ENC";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(141, 22);
            button8.Name = "button8";
            button8.Size = new Size(129, 23);
            button8.TabIndex = 17;
            button8.Text = "TXT -> IMG";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(6, 22);
            button7.Name = "button7";
            button7.Size = new Size(129, 23);
            button7.TabIndex = 10;
            button7.Text = "IMG -> TXT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button12
            // 
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(489, 313);
            button12.Name = "button12";
            button12.Size = new Size(197, 23);
            button12.TabIndex = 20;
            button12.Text = "Salvar Img";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(489, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 390);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(674, 23);
            progressBar1.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button14);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button16);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(294, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 81);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Apagar Todos";
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(6, 22);
            button13.Name = "button13";
            button13.Size = new Size(89, 23);
            button13.TabIndex = 6;
            button13.Text = "IMG";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.FlatStyle = FlatStyle.Flat;
            button14.Location = new Point(101, 51);
            button14.Name = "button14";
            button14.Size = new Size(82, 23);
            button14.TabIndex = 9;
            button14.Text = "ENC";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.FlatStyle = FlatStyle.Flat;
            button15.Location = new Point(6, 51);
            button15.Name = "button15";
            button15.Size = new Size(89, 23);
            button15.TabIndex = 7;
            button15.Text = "TXT";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.FlatStyle = FlatStyle.Flat;
            button16.Location = new Point(101, 22);
            button16.Name = "button16";
            button16.Size = new Size(82, 23);
            button16.TabIndex = 8;
            button16.Text = "MP4";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.FlatStyle = FlatStyle.Flat;
            button17.Location = new Point(6, 22);
            button17.Name = "button17";
            button17.Size = new Size(177, 23);
            button17.TabIndex = 21;
            button17.Text = "Compactar imagens";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button18);
            groupBox4.Controls.Add(button11);
            groupBox4.Controls.Add(button17);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(294, 189);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(189, 195);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opcoes Diversas";
            // 
            // button18
            // 
            button18.FlatStyle = FlatStyle.Flat;
            button18.Location = new Point(6, 138);
            button18.Name = "button18";
            button18.Size = new Size(177, 26);
            button18.TabIndex = 23;
            button18.Text = "Extrair ultimo frame (ffmpeg)";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click_1;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(6, 109);
            button11.Name = "button11";
            button11.Size = new Size(177, 23);
            button11.TabIndex = 22;
            button11.Text = "Gerar lista de .ENC";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 59);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 19;
            label5.Text = "Intervalo de Processamento:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(64, 64, 64);
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.ForeColor = Color.White;
            numericUpDown1.Location = new Point(6, 80);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(177, 23);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // timer_compactador
            // 
            timer_compactador.Interval = 2000;
            timer_compactador.Tick += timer_compactador_Tick;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(140, 0, 0);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Location = new Point(489, 355);
            button19.Name = "button19";
            button19.Size = new Size(197, 23);
            button19.TabIndex = 23;
            button19.Text = "Parar todos processos ativos";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(692, 444);
            Controls.Add(button19);
            Controls.Add(button12);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
        private Button button9;
        private Button button10;
        private ProgressBar progressBar1;
        private Button button12;
        private GroupBox groupBox3;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private GroupBox groupBox4;
        private System.Windows.Forms.Timer timer_compactador;
        private Button button11;
        private Button button18;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button19;
    }
}
