using System.Diagnostics;
using System.IO;
using System.Text;

namespace Compactador_de_videos_em_massa_FFMPEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog b = new FolderBrowserDialog())
            {
                if (b.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = b.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog b = new FolderBrowserDialog())
            {
                if (b.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = b.SelectedPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var arquivosMp4 = Directory.EnumerateFiles(textBox1.Text, "*.mp4", SearchOption.AllDirectories);

            textBox3.Text = "";


            string s = "";
            foreach (var arquivo in arquivosMp4)
            {
                s += $"ffmpeg -i \"{arquivo}\" -c:v libx264 -crf 28 -preset slow -c:a aac -b:a 128k \"{textBox2.Text}\\compactado_{arquivo.Split('\\').Last().Trim()}\"" + Environment.NewLine;

                if (checkBox1.Checked)
                {
                    s += $"del /f /q \"{arquivo}\"" + Environment.NewLine;

                }

            }
            textBox3.Text = s;

            Thread.Sleep(2000);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo Batch (*.bat)|*.bat";
            saveFileDialog.Title = "Salvar arquivo BAT";
            saveFileDialog.DefaultExt = "bat";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Conteúdo do TextBox
                string conteudo = textBox3.Text;

                // Salva o arquivo
                File.WriteAllText(saveFileDialog.FileName, conteudo, Encoding.ASCII);
                // ou Encoding.UTF8 se preferir

                MessageBox.Show("Arquivo salvo com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

    }
}