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
            label2 = new Label();
            button10 = new Button();
            button8 = new Button();
            button9 = new Button();
            richTextBox2 = new RichTextBox();
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            textBox4 = new TextBox();
            button15 = new Button();
            button16 = new Button();
            textBox5 = new TextBox();
            menuStrip1 = new MenuStrip();
            imagensToolStripMenuItem = new ToolStripMenuItem();
            processarTodasImagensToolStripMenuItem = new ToolStripMenuItem();
            processarTodosTXTsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            abrirImagemEGerarCodigoTXTToolStripMenuItem = new ToolStripMenuItem();
            decodificarTextoEExibirAImagemToolStripMenuItem = new ToolStripMenuItem();
            salvarArquivoDeTextoToolStripMenuItem = new ToolStripMenuItem();
            videosToolStripMenuItem = new ToolStripMenuItem();
            criptografarMP4ParaENCToolStripMenuItem = new ToolStripMenuItem();
            descriptografarENCParaMP4ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            gerarListaDeVideosParaOSiteToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem = new ToolStripMenuItem();
            apagarToolStripMenuItem = new ToolStripMenuItem();
            apagarTodosTXTToolStripMenuItem = new ToolStripMenuItem();
            apagarTodasImagensToolStripMenuItem = new ToolStripMenuItem();
            apagarTodosMP4ToolStripMenuItem = new ToolStripMenuItem();
            apagarTodosENCToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(12, 102);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Senha Padrão";
            textBox1.Size = new Size(530, 20);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(793, 188);
            button1.Name = "button1";
            button1.Size = new Size(187, 25);
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
            button2.Location = new Point(793, 219);
            button2.Name = "button2";
            button2.Size = new Size(187, 25);
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
            button3.Location = new Point(792, 334);
            button3.Name = "button3";
            button3.Size = new Size(188, 25);
            button3.TabIndex = 6;
            button3.Text = "Salvar arquivo de texto";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Location = new Point(548, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.AppWorkspace;
            richTextBox1.Location = new Point(271, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(130, 181);
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
            button6.Location = new Point(350, 411);
            button6.Name = "button6";
            button6.Size = new Size(180, 25);
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
            button5.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(793, 425);
            button5.Name = "button5";
            button5.Size = new Size(186, 25);
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
            button4.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(793, 395);
            button4.Name = "button4";
            button4.Size = new Size(186, 25);
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
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(12, 134);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(253, 87);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Converter Imagens para JPEG";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(23, 60);
            label1.TabIndex = 8;
            label1.Text = "bla\r\nbla\r\nbla\r\nbla";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.AppWorkspace;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(793, 134);
            button7.Name = "button7";
            button7.Size = new Size(194, 25);
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
            groupBox5.Controls.Add(label2);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(12, 227);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(253, 88);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Encriptador de Videos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(23, 60);
            label2.TabIndex = 8;
            label2.Text = "bla\r\nbla\r\nbla\r\nbla";
            // 
            // button10
            // 
            button10.BackColor = SystemColors.AppWorkspace;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(793, 70);
            button10.Name = "button10";
            button10.Size = new Size(194, 25);
            button10.TabIndex = 13;
            button10.Text = "Descriptografar ENC para MP4";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(793, 39);
            button8.Name = "button8";
            button8.Size = new Size(194, 25);
            button8.TabIndex = 7;
            button8.Text = "Criptografar MP4 para ENC";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.AppWorkspace;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(567, 425);
            button9.Name = "button9";
            button9.Size = new Size(180, 25);
            button9.TabIndex = 10;
            button9.Text = "Gerar Lista de Videos para o Site";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.AppWorkspace;
            richTextBox2.Location = new Point(412, 133);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(130, 181);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "\n";
            // 
            // timer3
            // 
            timer3.Interval = 3000;
            timer3.Tick += timer3_Tick;
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
            button11.Location = new Point(162, 363);
            button11.Name = "button11";
            button11.Size = new Size(134, 25);
            button11.TabIndex = 14;
            button11.Text = "Apagar todos TXT";
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
            button12.Location = new Point(162, 394);
            button12.Name = "button12";
            button12.Size = new Size(134, 25);
            button12.TabIndex = 15;
            button12.Text = "Apagar todas imagens";
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
            button13.Location = new Point(162, 425);
            button13.Name = "button13";
            button13.Size = new Size(134, 25);
            button13.TabIndex = 16;
            button13.Text = "Apagar todos MP4";
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
            button14.Location = new Point(162, 456);
            button14.Name = "button14";
            button14.Size = new Size(134, 25);
            button14.TabIndex = 17;
            button14.Text = "Apagar todos ENC";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(50, 50, 50);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ButtonFace;
            textBox4.Location = new Point(12, 39);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Diretorio das Imagens";
            textBox4.Size = new Size(427, 20);
            textBox4.TabIndex = 18;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.AppWorkspace;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ActiveCaptionText;
            button15.Location = new Point(457, 38);
            button15.Name = "button15";
            button15.Size = new Size(85, 20);
            button15.TabIndex = 19;
            button15.Text = "Buscar";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.AppWorkspace;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = SystemColors.ActiveCaptionText;
            button16.Location = new Point(457, 70);
            button16.Name = "button16";
            button16.Size = new Size(85, 20);
            button16.TabIndex = 21;
            button16.Text = "Buscar";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(50, 50, 50);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.ButtonFace;
            textBox5.Location = new Point(12, 71);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Diretorio dos Videos";
            textBox5.Size = new Size(427, 20);
            textBox5.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { imagensToolStripMenuItem, videosToolStripMenuItem, opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(756, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // imagensToolStripMenuItem
            // 
            imagensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { processarTodasImagensToolStripMenuItem, processarTodosTXTsToolStripMenuItem, toolStripSeparator2, abrirImagemEGerarCodigoTXTToolStripMenuItem, decodificarTextoEExibirAImagemToolStripMenuItem, salvarArquivoDeTextoToolStripMenuItem });
            imagensToolStripMenuItem.Name = "imagensToolStripMenuItem";
            imagensToolStripMenuItem.Size = new Size(64, 20);
            imagensToolStripMenuItem.Text = "Imagens";
            // 
            // processarTodasImagensToolStripMenuItem
            // 
            processarTodasImagensToolStripMenuItem.Name = "processarTodasImagensToolStripMenuItem";
            processarTodasImagensToolStripMenuItem.Size = new Size(262, 22);
            processarTodasImagensToolStripMenuItem.Text = "Processar Todas Imagens";
            processarTodasImagensToolStripMenuItem.Click += processarTodasImagensToolStripMenuItem_Click;
            // 
            // processarTodosTXTsToolStripMenuItem
            // 
            processarTodosTXTsToolStripMenuItem.Name = "processarTodosTXTsToolStripMenuItem";
            processarTodosTXTsToolStripMenuItem.Size = new Size(262, 22);
            processarTodosTXTsToolStripMenuItem.Text = "Processar Todos TXTs";
            processarTodosTXTsToolStripMenuItem.Click += processarTodosTXTsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(259, 6);
            // 
            // abrirImagemEGerarCodigoTXTToolStripMenuItem
            // 
            abrirImagemEGerarCodigoTXTToolStripMenuItem.Name = "abrirImagemEGerarCodigoTXTToolStripMenuItem";
            abrirImagemEGerarCodigoTXTToolStripMenuItem.Size = new Size(262, 22);
            abrirImagemEGerarCodigoTXTToolStripMenuItem.Text = "Abrir imagem e gerar codigo TXT";
            abrirImagemEGerarCodigoTXTToolStripMenuItem.Click += abrirImagemEGerarCodigoTXTToolStripMenuItem_Click;
            // 
            // decodificarTextoEExibirAImagemToolStripMenuItem
            // 
            decodificarTextoEExibirAImagemToolStripMenuItem.Name = "decodificarTextoEExibirAImagemToolStripMenuItem";
            decodificarTextoEExibirAImagemToolStripMenuItem.Size = new Size(262, 22);
            decodificarTextoEExibirAImagemToolStripMenuItem.Text = "Decodificar Texto e exibir a imagem";
            decodificarTextoEExibirAImagemToolStripMenuItem.Click += decodificarTextoEExibirAImagemToolStripMenuItem_Click;
            // 
            // salvarArquivoDeTextoToolStripMenuItem
            // 
            salvarArquivoDeTextoToolStripMenuItem.Name = "salvarArquivoDeTextoToolStripMenuItem";
            salvarArquivoDeTextoToolStripMenuItem.Size = new Size(262, 22);
            salvarArquivoDeTextoToolStripMenuItem.Text = "Salvar arquivo de texto";
            salvarArquivoDeTextoToolStripMenuItem.Click += salvarArquivoDeTextoToolStripMenuItem_Click;
            // 
            // videosToolStripMenuItem
            // 
            videosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criptografarMP4ParaENCToolStripMenuItem, descriptografarENCParaMP4ToolStripMenuItem, toolStripSeparator1, gerarListaDeVideosParaOSiteToolStripMenuItem });
            videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            videosToolStripMenuItem.Size = new Size(54, 20);
            videosToolStripMenuItem.Text = "Videos";
            // 
            // criptografarMP4ParaENCToolStripMenuItem
            // 
            criptografarMP4ParaENCToolStripMenuItem.Name = "criptografarMP4ParaENCToolStripMenuItem";
            criptografarMP4ParaENCToolStripMenuItem.Size = new Size(241, 22);
            criptografarMP4ParaENCToolStripMenuItem.Text = "Criptografar MP4 para ENC";
            criptografarMP4ParaENCToolStripMenuItem.Click += criptografarMP4ParaENCToolStripMenuItem_Click;
            // 
            // descriptografarENCParaMP4ToolStripMenuItem
            // 
            descriptografarENCParaMP4ToolStripMenuItem.Name = "descriptografarENCParaMP4ToolStripMenuItem";
            descriptografarENCParaMP4ToolStripMenuItem.Size = new Size(241, 22);
            descriptografarENCParaMP4ToolStripMenuItem.Text = "Descriptografar ENC para MP4";
            descriptografarENCParaMP4ToolStripMenuItem.Click += descriptografarENCParaMP4ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(238, 6);
            // 
            // gerarListaDeVideosParaOSiteToolStripMenuItem
            // 
            gerarListaDeVideosParaOSiteToolStripMenuItem.Name = "gerarListaDeVideosParaOSiteToolStripMenuItem";
            gerarListaDeVideosParaOSiteToolStripMenuItem.Size = new Size(241, 22);
            gerarListaDeVideosParaOSiteToolStripMenuItem.Text = "Gerar Lista de Videos para o Site";
            gerarListaDeVideosParaOSiteToolStripMenuItem.Click += gerarListaDeVideosParaOSiteToolStripMenuItem_Click;
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem, apagarToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem
            // 
            converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem.Name = "converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem";
            converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem.Size = new Size(377, 22);
            converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem.Text = "Converter Todas Imagens para JPEG (diminue o tamanho)";
            converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem.Click += converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem_Click;
            // 
            // apagarToolStripMenuItem
            // 
            apagarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { apagarTodosTXTToolStripMenuItem, apagarTodasImagensToolStripMenuItem, apagarTodosMP4ToolStripMenuItem, apagarTodosENCToolStripMenuItem });
            apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            apagarToolStripMenuItem.Size = new Size(377, 22);
            apagarToolStripMenuItem.Text = "Apagar";
            // 
            // apagarTodosTXTToolStripMenuItem
            // 
            apagarTodosTXTToolStripMenuItem.Name = "apagarTodosTXTToolStripMenuItem";
            apagarTodosTXTToolStripMenuItem.Size = new Size(192, 22);
            apagarTodosTXTToolStripMenuItem.Text = "Apagar todos TXT";
            apagarTodosTXTToolStripMenuItem.Click += apagarTodosTXTToolStripMenuItem_Click;
            // 
            // apagarTodasImagensToolStripMenuItem
            // 
            apagarTodasImagensToolStripMenuItem.Name = "apagarTodasImagensToolStripMenuItem";
            apagarTodasImagensToolStripMenuItem.Size = new Size(192, 22);
            apagarTodasImagensToolStripMenuItem.Text = "Apagar todas imagens";
            apagarTodasImagensToolStripMenuItem.Click += apagarTodasImagensToolStripMenuItem_Click;
            // 
            // apagarTodosMP4ToolStripMenuItem
            // 
            apagarTodosMP4ToolStripMenuItem.Name = "apagarTodosMP4ToolStripMenuItem";
            apagarTodosMP4ToolStripMenuItem.Size = new Size(192, 22);
            apagarTodosMP4ToolStripMenuItem.Text = "Apagar todos MP4";
            apagarTodosMP4ToolStripMenuItem.Click += apagarTodosMP4ToolStripMenuItem_Click;
            // 
            // apagarTodosENCToolStripMenuItem
            // 
            apagarTodosENCToolStripMenuItem.Name = "apagarTodosENCToolStripMenuItem";
            apagarTodosENCToolStripMenuItem.Size = new Size(192, 22);
            apagarTodosENCToolStripMenuItem.Text = "Apagar todos ENC";
            apagarTodosENCToolStripMenuItem.Click += apagarTodosENCToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(756, 325);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(button10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button16);
            Controls.Add(textBox5);
            Controls.Add(richTextBox2);
            Controls.Add(button15);
            Controls.Add(textBox4);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Opacity = 0.98D;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imagensToolStripMenuItem;
        private ToolStripMenuItem processarTodasImagensToolStripMenuItem;
        private ToolStripMenuItem processarTodosTXTsToolStripMenuItem;
        private ToolStripMenuItem videosToolStripMenuItem;
        private ToolStripMenuItem criptografarMP4ParaENCToolStripMenuItem;
        private ToolStripMenuItem descriptografarENCParaMP4ToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem;
        private ToolStripMenuItem apagarToolStripMenuItem;
        private ToolStripMenuItem apagarTodosTXTToolStripMenuItem;
        private ToolStripMenuItem apagarTodasImagensToolStripMenuItem;
        private ToolStripMenuItem apagarTodosMP4ToolStripMenuItem;
        private ToolStripMenuItem apagarTodosENCToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem gerarListaDeVideosParaOSiteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem abrirImagemEGerarCodigoTXTToolStripMenuItem;
        private ToolStripMenuItem decodificarTextoEExibirAImagemToolStripMenuItem;
        private ToolStripMenuItem salvarArquivoDeTextoToolStripMenuItem;
    }
}
