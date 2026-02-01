using ArquivoXTool.Properties;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static X;

namespace ArquivoXTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //--------------------------------
            textBox1.Text = Properties.Settings.Default.PastaImagens;
            textBox2.Text = Properties.Settings.Default.PastaVideos;
            textBox3.Text = Properties.Settings.Default.Senha;

            //----------------------------------
            if (textBox1.Text != "")
            {
                if (!Directory.Exists(textBox1.Text))
                {
                    MessageBox.Show("A pasta " + textBox1.Text + " não existe");
                }
                else
                {
                    pastaImagens = textBox1.Text;
                }
            }
            if (textBox2.Text != "")
            {
                if (!Directory.Exists(textBox2.Text))
                {
                    MessageBox.Show("A pasta " + textBox2.Text + " não existe");
                }
                else
                {
                    pastaVideos = textBox2.Text;
                }

            }
            if (textBox3.Text != "")
            {
                senhaPadrao = textBox3.Text;
            }
            //----------------------------------
            logLabel = label1;
            //----------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Utilitarios.Selecionar_Pasta();

            Properties.Settings.Default.PastaVideos = textBox2.Text;
            Properties.Settings.Default.PastaImagens = textBox1.Text;
            Properties.Settings.Default.Senha = textBox3.Text;
            Properties.Settings.Default.Save();

            pastaImagens = textBox1.Text;
            pastaVideos = textBox2.Text;
            senhaPadrao = textBox3.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Utilitarios.Selecionar_Pasta();

            Properties.Settings.Default.PastaVideos = textBox2.Text;
            Properties.Settings.Default.PastaImagens = textBox1.Text;
            Properties.Settings.Default.Senha = textBox3.Text;
            Properties.Settings.Default.Save();

            pastaImagens = textBox1.Text;
            pastaVideos = textBox2.Text;
            senhaPadrao = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOTE_com_Timer.img_to_txt(progressBar1, (int)numericUpDown1.Value * 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LOTE_com_Timer.txt_to_img(progressBar1, (int)numericUpDown1.Value * 1000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOTE_com_Timer.mp4_to_enc(progressBar1, (int)numericUpDown1.Value * 1000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOTE_com_Timer.enc_to_mp4(progressBar1, (int)numericUpDown1.Value * 1000);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Senha = textBox3.Text;
            Properties.Settings.Default.Save();

            pastaImagens = textBox1.Text;
            pastaVideos = textBox2.Text;
            senhaPadrao = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PastaVideos = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PastaImagens = textBox1.Text;
            Properties.Settings.Default.Save();

        }



        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = Imagens.Converter_para_Texto(Utilitarios.Selecionar_Arquivo());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Texto.Converter_para_imagem(Texto.Ler_txt(Utilitarios.Selecionar_Arquivo()));


        }

        private void button9_Click(object sender, EventArgs e)
        {
            MP4.Criptografar_para_ENC(Utilitarios.Selecionar_Arquivo());


        }

        private void button10_Click(object sender, EventArgs e)
        {
            ENC.Descriptografar_pra_MP4(Utilitarios.Selecionar_Arquivo());


        }




        //-----------------------
        public static int contadorProcessos = 0;
        public static int maximoProcessos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (contadorProcessos >= 0 && contadorProcessos < listaArquivosIMG.Count)
            {
                string codigo = Imagens.Converter_para_Texto(listaArquivosIMG[contadorProcessos]);

                Texto.criar_arquivo_e_gravar(pastaImagens + "/img (" + (contadorProcessos + 1)/*+1 pro nome começar no index 1*/ + ").txt", codigo);

                contadorProcessos++;
                progressBar1.Value = contadorProcessos;
            }
            else
            {
                timer1.Stop();

                MessageBox.Show(contadorProcessos + " imagens processadas");
                contadorProcessos = 0;
                maximoProcessos = 0;
                progressBar1.Value = 0;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            timer_compactador.Interval = (int)numericUpDown1.Value * 1000;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Imagens.Salvar_imagem(pictureBox1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Imagens.Apagar_Todas();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Texto.Apagar_Todos();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MP4.Apagar_Todos();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ENC.Apagar_Todos();
        }



        public static int contadorCompactador = 0;
        private void timer_compactador_Tick(object sender, EventArgs e)
        {


            if (contadorCompactador >= 0 && contadorCompactador < listaArquivosIMG.Count)
            {
                using (System.Drawing.Image img = System.Drawing.Image.FromFile(listaArquivosIMG[contadorCompactador]))
                {
                    string nomeSemExt = Path.GetFileNameWithoutExtension(listaArquivosIMG[contadorCompactador]);
                    string destino = Path.Combine(pastaImagens + "/Convertidas", nomeSemExt + "_" + Utilitarios.gerarSenha(5) + ".jpg");

                    img.Save(destino, ImageFormat.Jpeg);

                    contadorCompactador++;
                }

                progressBar1.Value = contadorCompactador;
            }
            else
            {


                timer_compactador.Stop();

                Utilitarios.Log(contadorProcessos + " imagens processadas");
                contadorProcessos = 0;
                maximoProcessos = 0;
                progressBar1.Value = 0;
                contadorCompactador = 0;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(pastaImagens + "/Convertidas"))
            {
                Directory.CreateDirectory(pastaImagens + "/Convertidas");
            }

            Imagens.alimentarImagens();
            maximoProcessos = Utilitarios.Contar_quantos_itens_tem_no_array(listaArquivosIMG);

            progressBar1.Maximum = maximoProcessos;
            timer_compactador.Start();

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }



        private void button11_Click_1(object sender, EventArgs e)
        {
            ENC.alimentarVideosENC();

            string s = "[\n";
            foreach (var item in listaArquivosENC)
            {
                string[] arraia = item.Split("\\");
                string formatado = arraia[arraia.Length - 1];



                s += "{\"index\":\"videos/" + formatado + "\", \"title\":\"" + formatado + "\"},\n";
            }
            s += "{\"index\":\"\", \"title\":\"\"}\n";
            s += "]\n";
            textBox4.Text = s.Replace(".mp4", ".enc");
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string final = openFileDialog.FileName.Replace(".mp4", ".png");

                    MessageBox.Show(openFileDialog.FileName);
                    MessageBox.Show(final);

                    var p = new Process();
                    p.StartInfo.FileName = "ffmpeg";
                    p.StartInfo.Arguments = $"-sseof -1 -i \"{openFileDialog.FileName}\" -vframes 1 \"{final}\"";

                    textBox4.Text = $"-sseof -1 -i \"{openFileDialog.FileName}\" -vframes 1 \"{final}\"";

                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    //p.WaitForExit();       // espera o FFmpeg terminar
                    p.Close();

                    MessageBox.Show("Concluido");
                    textBox4.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button19_Click(object sender, EventArgs e)
        {
            Utilitarios.Parar_todos_processos();
        }
    }
}
