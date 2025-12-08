using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static ImgToText.ImgToText_Class;

namespace ImgToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "";

        }
        public static bool boleta = false;

        List<string> bruteforceCombinacoes = new List<string>();




        private void button1_Click(object sender, EventArgs e)
        {
            /*
              if (textBox1.Text.Length > 0)
            {
                richTextBox1.Text = ImgToText_Class.Com_OpenDialog.ImgtoText(textBox1.Text);
                pictureBox1.Image = ImgToText_Class.Sem_OpenDialog.Text_to_Img(richTextBox1.Text, textBox1.Text);

            }
            else
            {
                textBox1.BackColor = Color.FromArgb(250, 50, 50);
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* if (richTextBox1.Text.Length > 0)
             {
                 if (textBox1.Text.Length > 0)
                 {
                     pictureBox1.Image = ImgToText_Class.Sem_OpenDialog.Text_to_Img(richTextBox1.Text, textBox1.Text);
                 }
                 else
                 {
                     textBox1.BackColor = Color.FromArgb(250, 50, 50);
                 }
             }
             else
             {
                 richTextBox1.BackColor = Color.FromArgb(250, 50, 50);
             }*/
        }











        private void button3_Click(object sender, EventArgs e)
        {
            //ImgToText_Class.Diversos.SalvarTXT(richTextBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Processamento.converter_todas_imagens_da_pasta_para_txt(textBox1.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Processamento.converter_todos_txt_da_pasta_para_png(pictureBox1, textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Diversos.SalvarIMG(pictureBox1);
        }








        public static int ggggg = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //Habilita o botao de salvar a imagem, caso exista alguma imagen no picturebox
            if (pictureBox1.Image != null)
            {
                button6.Enabled = true;
            }
            else
            {
                button6.Enabled = false;
            }
            //------------------


            //Habilita o botao de salvar o arquivo de texto, caso exista algum texto no richtextbox
            if (richTextBox1.Text.Length > 0)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
            //------------------

            //Habilita os botoes de processar tudo, caso exista uma senha ja, no textbox2
            if (textBox1.Text.Length > 0)
            {
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                button5.Enabled = false;
            }
            //------------------






        }

        public static int bruteforceNumCaracteres = 0;







        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*
               if (textBox4.Text == "")
              {
                  return;
              }
              ConversorJPEG.ctOK = 0;
              ConversorJPEG.ctERRRO = 0;
              ConversorJPEG.ponteiro = 0;


              Array.Clear(ConversorJPEG.arquivos, 0, ConversorJPEG.arquivos.Length);

              ConversorJPEG.pasta = Properties.Settings.Default.PastaImagens;
              ConversorJPEG.arquivos = Directory.GetFiles(ConversorJPEG.pasta);
              ConversorJPEG.pastaConvertidas = Path.Combine(ConversorJPEG.pasta, "convertidas");

              MessageBox.Show("Será criada uma pasta como nome CONVERTIDAS na mesma pasta atual, com as imagens convertidas");

              if (!Directory.Exists(ConversorJPEG.pastaConvertidas))
                  Directory.CreateDirectory(ConversorJPEG.pastaConvertidas);


              //-----------------------


              timer2.Start();
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";


            textBox4.Text = Properties.Settings.Default.PastaImagens;
            textBox5.Text = Properties.Settings.Default.PastaVideo;
            textBox1.Text = Properties.Settings.Default.Senha;



        }


        private string GerarSenhaNumerica()
        {
            Random rnd = new Random();
            string senha = "";

            for (int i = 0; i < 5; i++)
            {
                senha += rnd.Next(0, 10).ToString();
            }

            return senha;
        }


        string nomeSemExt;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //var arquivosTxt = Directory.GetFiles(textBox4.Text, "*.txt", SearchOption.TopDirectoryOnly);
            try
            {
                using (System.Drawing.Image img = System.Drawing.Image.FromFile(ConversorJPEG.arquivos[ConversorJPEG.ponteiro]))
                {
                    nomeSemExt = Path.GetFileNameWithoutExtension(ConversorJPEG.arquivos[ConversorJPEG.ponteiro]);
                    string destino = Path.Combine(ConversorJPEG.pastaConvertidas, nomeSemExt + "_" + GerarSenhaNumerica() + ".jpg");

                    img.Save(destino, ImageFormat.Jpeg);

                    ConversorJPEG.ctOK++;
                }
            }
            catch
            {
                ConversorJPEG.ctERRRO++;
                richTextBox2.Text += "\n" + nomeSemExt;
            }

            ConversorJPEG.ponteiro++;

            label1.Text = $"Total de Imagens: {ConversorJPEG.arquivos.Count()} imagens \nPonteiro atual: {ConversorJPEG.ponteiro}\nConvertidos {ConversorJPEG.ctOK} arquivos\nErros: {ConversorJPEG.ctERRRO} erros";

            if (ConversorJPEG.arquivos.Count() == ConversorJPEG.ponteiro)
            {
                timer2.Stop();
                ConversorJPEG.ctOK = 0;
                ConversorJPEG.ctERRRO = 0;
                ConversorJPEG.ponteiro = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*
              if (textBox5.Text == "")
             {
                 return;
             }
             string folder = textBox5.Text;


             Encriptador_de_Video.files = Directory.GetFiles(folder, "*.mp4")
                                  .OrderBy(f =>
                                  {
                                      // tenta ordenar numericamente se nomes forem '1.mp4'
                                      var name = Path.GetFileNameWithoutExtension(f);
                                      if (int.TryParse(name, out var n)) return n;
                                      return int.MaxValue;
                                  });

             Encriptador_de_Video.ctOK = 0;
             Encriptador_de_Video.ctERRRO = 0;
             Encriptador_de_Video.ponteiro = 0;

             timer3.Start();
             */
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                Encriptador_de_Video.EncryptFile(Encriptador_de_Video.files.ToList()[Encriptador_de_Video.ponteiro], textBox1.Text);
                Encriptador_de_Video.ctOK++;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Erro ao encriptar {file}: {ex.Message}");
                Encriptador_de_Video.ctERRRO++;
            }

            Encriptador_de_Video.ponteiro++;

            label2.Text = $"Total de Videos: {Encriptador_de_Video.files.Count()} videos \nPonteiro atual: {Encriptador_de_Video.ponteiro}\nConvertidos {Encriptador_de_Video.ctOK} arquivos\nErros: {Encriptador_de_Video.ctERRRO} erros";


            if (Encriptador_de_Video.files.Count() == Encriptador_de_Video.ponteiro)
            {
                timer3.Stop();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
              string s = "[\n";
             foreach (var item in Encriptador_de_Video.files)
             {
                 s += "{\"index\":\"" + item + "\", \"title\":\"" + item + "\"},\n";
             }
             s += "{\"index\":\"\", \"title\":\"\"}\n";
             s += "]\n";
             richTextBox2.Text = s.Replace(".mp4", ".enc");s
             */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
              if (textBox5.Text == "")
             {
                 return;
             }
             string folder = textBox5.Text;


             Encriptador_de_Video.files = Directory.GetFiles(folder, "*.enc")
                                  .OrderBy(f =>
                                  {
                                      // tenta ordenar numericamente se nomes forem '1.mp4'
                                      var name = Path.GetFileNameWithoutExtension(f);
                                      if (int.TryParse(name, out var n)) return n;
                                      return int.MaxValue;
                                  });

             Encriptador_de_Video.ctOK = 0;
             Encriptador_de_Video.ctERRRO = 0;
             Encriptador_de_Video.ponteiro = 0;

             timer4.Start();
             */
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                Encriptador_de_Video.DecryptFile(Encriptador_de_Video.files.ToList()[Encriptador_de_Video.ponteiro], textBox1.Text);
                Encriptador_de_Video.ctOK++;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Erro ao encriptar {file}: {ex.Message}");
                Encriptador_de_Video.ctERRRO++;
            }

            Encriptador_de_Video.ponteiro++;

            label2.Text = $"Total de Videos: {Encriptador_de_Video.files.Count()} videos \nPonteiro atual: {Encriptador_de_Video.ponteiro}\nConvertidos {Encriptador_de_Video.ctOK} arquivos\nErros: {Encriptador_de_Video.ctERRRO} erros";


            if (Encriptador_de_Video.files.Count() == Encriptador_de_Video.ponteiro)
            {
                timer4.Stop();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
             var arquivosTxt = Directory.GetFiles(textBox4.Text, "*.txt", SearchOption.TopDirectoryOnly);

           foreach (var arquivo in arquivosTxt)
           {
               try
               {
                   File.Delete(arquivo);
               }
               catch (Exception ex)
               {
                   MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
               }
           }
           MessageBox.Show($"Finalizado"); 
             */

        }

        private void button12_Click(object sender, EventArgs e)
        {

            /*

                        string[] extensoes = {
                        "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp",
                        "*.webp", "*.webm", "*.tiff"
                    };

                        foreach (var ext in extensoes)
                        {
                            var arquivos = Directory.GetFiles(textBox4.Text, ext, SearchOption.TopDirectoryOnly);

                            foreach (var arquivo in arquivos)
                            {
                                try
                                {
                                    File.Delete(arquivo);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                                }
                            }
                        }
                        MessageBox.Show($"Finalizado"); 
             */
        }

        private void button13_Click(object sender, EventArgs e)
        {

            /*
             var arquivosTxt = Directory.GetFiles(textBox5.Text, "*.mp4", SearchOption.TopDirectoryOnly);

            foreach (var arquivo in arquivosTxt)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                }
            }
            MessageBox.Show($"Finalizado");
             */
        }

        private void button14_Click(object sender, EventArgs e)
        {

            /*
             var arquivosTxt = Directory.GetFiles(textBox5.Text, "*.enc", SearchOption.TopDirectoryOnly);

            foreach (var arquivo in arquivosTxt)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                }
            }
            MessageBox.Show($"Finalizado"); 
             */
        }

        public static string SelecionarPasta()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione uma pasta:";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }
            }

            return null; // usuário cancelou
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox4.Text = SelecionarPasta();
            if (textBox4.Text != "")
            {
                Properties.Settings.Default.PastaImagens = textBox4.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox5.Text = SelecionarPasta();
            if (textBox5.Text != "")
            {
                Properties.Settings.Default.PastaVideo = textBox5.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Senha = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void processarTodasImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Processamento.converter_todas_imagens_da_pasta_para_txt(textBox1.Text);
        }

        private void processarTodosTXTsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Processamento.converter_todos_txt_da_pasta_para_png(pictureBox1, textBox1.Text);
        }

        private void abrirImagemEGerarCodigoTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                richTextBox1.Text = ImgToText_Class.Com_OpenDialog.ImgtoText(textBox1.Text);
                pictureBox1.Image = ImgToText_Class.Sem_OpenDialog.Text_to_Img(richTextBox1.Text, textBox1.Text);

            }
            else
            {
                textBox1.BackColor = Color.FromArgb(250, 50, 50);
            }
        }

        private void decodificarTextoEExibirAImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if (textBox1.Text.Length > 0)
                {
                    pictureBox1.Image = ImgToText_Class.Sem_OpenDialog.Text_to_Img(richTextBox1.Text, textBox1.Text);
                }
                else
                {
                    textBox1.BackColor = Color.FromArgb(250, 50, 50);
                }
            }
            else
            {
                richTextBox1.BackColor = Color.FromArgb(250, 50, 50);
            }
        }

        private void salvarArquivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImgToText_Class.Diversos.SalvarTXT(richTextBox1.Text);
        }

        private void criptografarMP4ParaENCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                return;
            }
            string folder = textBox5.Text;


            Encriptador_de_Video.files = Directory.GetFiles(folder, "*.mp4")
                                 .OrderBy(f =>
                                 {
                                     // tenta ordenar numericamente se nomes forem '1.mp4'
                                     var name = Path.GetFileNameWithoutExtension(f);
                                     if (int.TryParse(name, out var n)) return n;
                                     return int.MaxValue;
                                 });

            Encriptador_de_Video.ctOK = 0;
            Encriptador_de_Video.ctERRRO = 0;
            Encriptador_de_Video.ponteiro = 0;

            timer3.Start();
        }

        private void descriptografarENCParaMP4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                return;
            }
            string folder = textBox5.Text;


            Encriptador_de_Video.files = Directory.GetFiles(folder, "*.enc")
                                 .OrderBy(f =>
                                 {
                                     // tenta ordenar numericamente se nomes forem '1.mp4'
                                     var name = Path.GetFileNameWithoutExtension(f);
                                     if (int.TryParse(name, out var n)) return n;
                                     return int.MaxValue;
                                 });

            Encriptador_de_Video.ctOK = 0;
            Encriptador_de_Video.ctERRRO = 0;
            Encriptador_de_Video.ponteiro = 0;

            timer4.Start();
        }

        private void gerarListaDeVideosParaOSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = "[\n";
            foreach (var item in Encriptador_de_Video.files)
            {
                string[] arraia = item.Split("\\");
                string formatado = arraia[arraia.Length - 1];



                    s += "{\"index\":\"videos/" + formatado + "\", \"title\":\"" + formatado + "\"},\n";
            }
            s += "{\"index\":\"\", \"title\":\"\"}\n";
            s += "]\n";
            richTextBox2.Text = s.Replace(".mp4", ".enc");
        }

        private void converterTodasImagensParaJPEGdiminueOTamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                return;
            }
            ConversorJPEG.ctOK = 0;
            ConversorJPEG.ctERRRO = 0;
            ConversorJPEG.ponteiro = 0;


            Array.Clear(ConversorJPEG.arquivos, 0, ConversorJPEG.arquivos.Length);

            ConversorJPEG.pasta = Properties.Settings.Default.PastaImagens;
            ConversorJPEG.arquivos = Directory.GetFiles(ConversorJPEG.pasta);
            ConversorJPEG.pastaConvertidas = Path.Combine(ConversorJPEG.pasta, "convertidas");

            MessageBox.Show("Será criada uma pasta como nome CONVERTIDAS na mesma pasta atual, com as imagens convertidas");

            if (!Directory.Exists(ConversorJPEG.pastaConvertidas))
                Directory.CreateDirectory(ConversorJPEG.pastaConvertidas);


            //-----------------------


            timer2.Start();
        }

        private void apagarTodosTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arquivosTxt = Directory.GetFiles(textBox4.Text, "*.txt", SearchOption.TopDirectoryOnly);

            foreach (var arquivo in arquivosTxt)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                }
            }
            MessageBox.Show($"Finalizado");
        }

        private void apagarTodasImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string[] extensoes = {
            "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp",
            "*.webp", "*.webm", "*.tiff"
        };

            foreach (var ext in extensoes)
            {
                var arquivos = Directory.GetFiles(textBox4.Text, ext, SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    try
                    {
                        File.Delete(arquivo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                    }
                }
            }
            MessageBox.Show($"Finalizado");
        }

        private void apagarTodosMP4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arquivosTxt = Directory.GetFiles(textBox5.Text, "*.mp4", SearchOption.TopDirectoryOnly);

            foreach (var arquivo in arquivosTxt)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                }
            }
            MessageBox.Show($"Finalizado");
        }

        private void apagarTodosENCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var arquivosTxt = Directory.GetFiles(textBox5.Text, "*.enc", SearchOption.TopDirectoryOnly);

            foreach (var arquivo in arquivosTxt)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao apagar {arquivo}: {ex.Message}");
                }
            }
            MessageBox.Show($"Finalizado");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
