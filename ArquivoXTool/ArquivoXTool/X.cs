using ArquivoXTool.Properties;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class X
{
    public static string pastaImagens;
    public static string pastaVideos;
    public static string senhaPadrao;

    public static Label logLabel;

    public static List<string> listaArquivosIMG = new List<string>() ;
    public static List<string> listaArquivosMP4 = new List<string>() ;
    public static List<string> listaArquivosTXT = new List<string>() ;
    public static List<string> listaArquivosENC = new List<string>();


    public static List<System.Windows.Forms.Timer> listaTimers = new List<System.Windows.Forms.Timer>();


     /*
try
{
    
}
catch (Exception o)
{
    MessageBox.Show(o.ToString());
}
     */
    
    public class Utilitarios
    {
        public static void Parar_todos_processos()
        {
            foreach (var i in listaTimers)
            {
                i.Stop();
            }
            LOTE_com_Timer.contadorProcessos = 0;
            LOTE_com_Timer.maximoProcessos = 0;

        }
        public static void Log(string t)
        {
            if (t.Contains("ERRO:"))
            { 
                logLabel.ForeColor = Color.Red;
            }
            else
            {
                logLabel.ForeColor = Color.Cyan;
            }


            logLabel.Text = t;
            System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
            tt.Interval = 3000;
            tt.Start();
            tt.Tick += (s, e) =>
            {
                logLabel.ForeColor = Color.FromArgb(255, 255, 255); 
                logLabel.Text = ""; 
                tt.Stop();
            };
        }
        public static string Selecionar_Pasta()
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
        public static string Selecionar_Arquivo()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog { })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
        public static void LimparArray(List<string> a)
        {
            try
            {
                a.Clear();
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }  
        public static int Contar_quantos_itens_tem_no_array(List<string> a)
        {
            return a.Count;
        }
        public static string gerarSenha(int num_caracteres)
        {
            try
            {
                const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyz";
                StringBuilder senha = new StringBuilder();
                Random random = new Random();
                for (int i = 0; i < num_caracteres; i++)
                {
                    senha.Append(caracteresPermitidos[random.Next(caracteresPermitidos.Length)]);
                }
                return senha.ToString();
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
                return null;
            }

            
        }
    }   
    public class Imagens
    {
        public static void Apagar_Todas()
        {
            int contador = 0;
            try
            {
                string[] extensoes = {
                        "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp",
                        "*.webp", "*.webm", "*.tiff"
                    };

                foreach (var ext in extensoes)
                {
                    var arquivos = Directory.GetFiles(pastaImagens, ext, SearchOption.TopDirectoryOnly);

                    foreach (var arquivo in arquivos)
                    {
                        File.Delete(arquivo);
                        contador++;
                    }
                }
                Utilitarios.Log(contador + " arquivos deletados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static string Converter_para_Texto(string path)
        {
            try
            {
                byte[] imageBytes = File.ReadAllBytes(path);
                string base64String = Convert.ToBase64String(imageBytes);

                //---------------------
                string input = senhaPadrao;
                uint hash = 0;
                foreach (char c in input)
                {
                    hash += (uint)c;
                    hash += (hash << 10);
                    hash ^= (hash >> 6);
                }

                hash += (hash << 3);
                hash ^= (hash >> 11);
                hash += (hash << 15);

                //-------------------------
                string text = base64String;
                string key = "0x" + hash.ToString("X");
                StringBuilder e2 = new StringBuilder();
                int keyLength = key.Length;

                for (int i = 0; i < text.Length; i++)
                {
                    e2.Append((char)(text[i] ^ key[i % keyLength]));
                }
                Utilitarios.Log("Aquivo convertido");
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(e2.ToString()));
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
                return null;
            }
            
        }
        public static void alimentarImagens()
        {
             
            try
            {
                int ct = 0;
                Utilitarios.LimparArray(listaArquivosIMG);

                string[] extensoes = {
                        "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp",
                        "*.webp", "*.webm", "*.tiff", "*.heic"
                    };

                foreach (var ext in extensoes)
                {
                    var arquivos = Directory.GetFiles(pastaImagens, ext, SearchOption.TopDirectoryOnly);

                    foreach (var arquivo in arquivos)
                    {
                        listaArquivosIMG.Add(arquivo);
                        ct++;
                    }
                }
                Utilitarios.Log(ct + " imagens obtidas");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }

        }
        public static void Salvar_imagem(PictureBox picturebox,string path)
        {
            try
            {
                if (picturebox.Image != null)
                {
                    using (Bitmap copia = new Bitmap(picturebox.Image))
                    {
                        copia.Save(path+"/"+Utilitarios.gerarSenha(5)+".png", System.Drawing.Imaging.ImageFormat.Png);
                        Utilitarios.Log("Imagens salva com sucesso");
                    }
                }

            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());

            }
        } 
        public static void Salvar_imagem(PictureBox picturebox)
        {
            try
            {
                if (picturebox.Image != null)
                {
                    using (Bitmap copia = new Bitmap(picturebox.Image))
                    {
                        copia.Save(pastaImagens + "/"+Utilitarios.gerarSenha(5)+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        Utilitarios.Log("Imagens salva com sucesso");
                    }
                }

            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());

            }
        }
    }
    public class Texto
    {
        public static string Ler_txt(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "";
        }
        public static void Apagar_Todos()
        {
            int contador = 0;
            try
            {
                var arquivos = Directory.GetFiles(pastaImagens, "*.txt", SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    File.Delete(arquivo);
                    contador++;
                }
                Utilitarios.Log(contador + " arquivos de texto excluidos");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static void alimentarTXT()
        {
            int contador = 0;
            try
            {
                Utilitarios.LimparArray(listaArquivosTXT);
                string[] aa= Directory.GetFiles(pastaImagens, "*.txt", SearchOption.TopDirectoryOnly);

                foreach (var item in aa)
                {
                    listaArquivosTXT.Add(item);
                    contador++;
                }
                Utilitarios.Log(contador + " arquivos de texto carregados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static void criar_arquivo_e_gravar(string path,string conteudo)
        {
            try
            {
                File.WriteAllText(path, conteudo);
                Utilitarios.Log("Arquivo '"+path+"' gravado com sucesso");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static System.Drawing.Image Converter_para_imagem(string texto)
        {
            try
            {
                string input = senhaPadrao;
                uint hash = 0;
                foreach (char c in input)
                {
                    hash += (uint)c;
                    hash += (hash << 10);
                    hash ^= (hash >> 6);
                }

                hash += (hash << 3);
                hash ^= (hash >> 11);
                hash += (hash << 15);


                string key = "0x" + hash.ToString("X");
                string base64Decoded = Encoding.UTF8.GetString(Convert.FromBase64String(texto));


                StringBuilder d = new StringBuilder();
                for (int i = 0; i < base64Decoded.Length; i++)
                {
                    d.Append((char)(base64Decoded[i] ^ key[i % key.Length]));
                }



                byte[] imageBytes = Convert.FromBase64String(d.ToString());

                // Cria um stream a partir dos bytes da imagem
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Utilitarios.Log("Imagem renderizada com sucesso");
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
                return null;
            }
        }
    }
    public class MP4
    {
        static readonly byte[] MAGIC = Encoding.ASCII.GetBytes("VIDENC01"); // 8 bytes
        const int SALT_LEN = 16;
        const int IV_LEN = 12; // recomendado para AES-GCM
        const int TAG_LEN = 16; // AES-GCM tag
        const int PBKDF2_ITER = 200_000; // ajuste conforme necessidade
        const int KEY_LEN = 32; // 256 bits

        public static void alimentarVideos()
        {
            int contador = 0;
            try
            {
                Utilitarios.LimparArray(listaArquivosMP4);
                var arquivos = Directory.GetFiles(pastaVideos, "*.mp4", SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    listaArquivosMP4.Add(arquivo);
                    contador++;
                }
                Utilitarios.Log(contador + " videos carregados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }

        }
        public static void Apagar_Todos()
        {
            int contador = 0;
            try
            {
                var arquivos = Directory.GetFiles(pastaVideos, "*.mp4", SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    File.Delete(arquivo);
                    contador++;
                }
                Utilitarios.Log(contador + " arquivos de video deletados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static void Criptografar_para_ENC(string filepath)
        {
            byte[] plain = File.ReadAllBytes(filepath);
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[SALT_LEN];
            rng.GetBytes(salt);
            byte[] iv = new byte[IV_LEN];
            rng.GetBytes(iv);

            // Deriva chave com PBKDF2 (Rfc2898)
            using var kdf = new Rfc2898DeriveBytes(senhaPadrao, salt, PBKDF2_ITER, HashAlgorithmName.SHA256);
            byte[] key = kdf.GetBytes(KEY_LEN);

            // Cria AES-GCM e encripta
            byte[] cipher = new byte[plain.Length];
            byte[] tag = new byte[TAG_LEN];
            using (var aes = new AesGcm(key))
            {
                aes.Encrypt(iv, plain, cipher, tag);
            }

            // Layout: MAGIC(8) | saltLen(1) | salt | ivLen(1) | iv | tagLen(1) | tag | ciphertext
            using var ms = new MemoryStream();
            ms.Write(MAGIC, 0, MAGIC.Length);
            ms.WriteByte((byte)SALT_LEN);
            ms.Write(salt, 0, salt.Length);
            ms.WriteByte((byte)IV_LEN);
            ms.Write(iv, 0, iv.Length);
            ms.WriteByte((byte)TAG_LEN);
            ms.Write(tag, 0, tag.Length);
            ms.Write(cipher, 0, cipher.Length);

            string outPath = Path.Combine(Path.GetDirectoryName(filepath), Path.GetFileNameWithoutExtension(filepath) + ".enc");
            File.WriteAllBytes(outPath, ms.ToArray());

            Utilitarios.Log("Arquivo '"+outPath+"' criptografado com sucesso");
        }
    }
    public class ENC
    {
        static readonly byte[] MAGIC = Encoding.ASCII.GetBytes("VIDENC01"); // 8 bytes
        const int SALT_LEN = 16;
        const int IV_LEN = 12; // recomendado para AES-GCM
        const int TAG_LEN = 16; // AES-GCM tag
        const int PBKDF2_ITER = 200_000; // ajuste conforme necessidade
        const int KEY_LEN = 32; // 256 bits

        public static void alimentarVideosENC()
        {
            int contador = 0;
            try
            {
                Utilitarios.LimparArray(listaArquivosENC);
                var arquivos = Directory.GetFiles(pastaVideos, "*.enc", SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    listaArquivosENC.Add(arquivo);
                    contador++;
                }
                Utilitarios.Log(contador + " arquivos ENC carregados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }

        }
        public static void Apagar_Todos()
        {
            int contador = 0;
            try
            {
                var arquivos = Directory.GetFiles(pastaVideos, "*.enc", SearchOption.TopDirectoryOnly);

                foreach (var arquivo in arquivos)
                {
                    File.Delete(arquivo);
                    contador++;
                }
                Utilitarios.Log(contador + " arquivos ENC deletados");
            }
            catch (Exception o)
            {
                MessageBox.Show(o.ToString());
            }
        }
        public static void Descriptografar_pra_MP4(string filepath)
        {
            byte[] data = File.ReadAllBytes(filepath);
            int offset = 0;

            // --- MAGIC ---
            if (data.Length < MAGIC.Length)
                throw new Exception("Arquivo inválido ou corrompido.");

            for (int i = 0; i < MAGIC.Length; i++)
                if (data[offset + i] != MAGIC[i])
                    throw new Exception("MAGIC inválido: arquivo não foi criptografado por este sistema.");

            offset += MAGIC.Length;

            // --- SALT ---
            int saltLen = data[offset++];
            byte[] salt = data.AsSpan(offset, saltLen).ToArray();
            offset += saltLen;

            // --- IV ---
            int ivLen = data[offset++];
            byte[] iv = data.AsSpan(offset, ivLen).ToArray();
            offset += ivLen;

            // --- TAG ---
            int tagLen = data[offset++];
            byte[] tag = data.AsSpan(offset, tagLen).ToArray();
            offset += tagLen;

            // --- CIPHERTEXT ---
            byte[] ciphertext = data.AsSpan(offset).ToArray();

            // Deriva chave
            using var kdf = new Rfc2898DeriveBytes(senhaPadrao, salt, PBKDF2_ITER, HashAlgorithmName.SHA256);
            byte[] key = kdf.GetBytes(KEY_LEN);

            // AES-GCM decrypt
            byte[] plain = new byte[ciphertext.Length];
            using (var aes = new AesGcm(key))
            {
                try
                {
                    aes.Decrypt(iv, ciphertext, tag, plain);
                }
                catch (CryptographicException)
                {
                    throw new Exception("Senha incorreta ou arquivo corrompido.");
                }
            }

            // Salvar como MP4
            string outPath = Path.Combine(
                Path.GetDirectoryName(filepath),
                Path.GetFileNameWithoutExtension(filepath) + "_dec.mp4"
            );

            File.WriteAllBytes(outPath, plain);
            Utilitarios.Log("Arquivo '" + outPath + "' gerado com sucesso");
            // Console.WriteLine($"Decrypted: {Path.GetFileName(filepath)} -> {Path.GetFileName(outPath)}");
        }
    }
    public class Lote
    {
        public static void Converter_todas_imagens_para_texto()
        {
            Imagens.alimentarImagens();
            //img (1)
            int ct1 = 1;
            int ct = 0;
            for (int i = 1; i < 2000; i++)
            {
                if (!File.Exists(pastaImagens+"/img ("+i+").txt"))
                {
                    ct = i;
                    break;
                }
            }

            foreach (var item in listaArquivosIMG)
            {
                string codigo = Imagens.Converter_para_Texto(item);
                Texto.criar_arquivo_e_gravar(pastaImagens + "/img (" + ct + ").txt", codigo);
                ct1++;
                ct++;
            }
            Utilitarios.Log($"Convertidas do index {ct-ct1} ate {ct-1}");


        }
        public static void Converter_todos_textos_para_imagens()
        {
            Texto.alimentarTXT();


            int ct = 0;
            for (int i = 1; i < 2000; i++)
            {
                if (File.Exists(pastaImagens + "/img (" + i + ").txt"))
                {
                    PictureBox p = new PictureBox();
                    p.Image = new Bitmap(Texto.Converter_para_imagem(File.ReadAllText(pastaImagens + "/img (" + i + ").txt")));
                    Imagens.Salvar_imagem(p, pastaImagens + "/img (" + i + ").png");
                    ct++;
                }
                else
                {
                    break;
                }
            }

            Utilitarios.Log($"Convertidas {ct} imagens");

        }
        public static void Converter_todos_mp4_para_ENC()
        {
            int ct = 0;
            MP4.alimentarVideos();
            foreach (var item in listaArquivosMP4)
            {
                MP4.Criptografar_para_ENC(item);
                ct++;
            }
            Utilitarios.Log($"Convertidas {ct} videos");
        }
        public static void Converter_todos_ENC_para_mp4()
        {
            int ct = 0;
            ENC.alimentarVideosENC();
            foreach (var item in listaArquivosENC)
            {
                ENC.Descriptografar_pra_MP4(item);
                ct++;
            }
            MessageBox.Show($"Convertidas {ct} videos");

        }
    }

    




    public class LOTE_com_Timer
    {
        public static int contadorProcessos = 0;
        public static int maximoProcessos = 0;
        public static void txt_to_img(System.Windows.Forms.ProgressBar barra, int intervalo = 2000)
        {

            Texto.alimentarTXT();
            maximoProcessos = Utilitarios.Contar_quantos_itens_tem_no_array(listaArquivosTXT);

            barra.Maximum = maximoProcessos;
             

            System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
            tt.Interval = intervalo;

            listaTimers.Add(tt);

            tt.Start();
            tt.Tick += (s, e) =>
            {
                if (contadorProcessos >= 0 && contadorProcessos < listaArquivosTXT.Count)
                {
                    string codigo = Texto.Ler_txt(listaArquivosTXT[contadorProcessos]);

                    PictureBox img = new PictureBox();
                    img.Image = Texto.Converter_para_imagem(codigo);
                    Imagens.Salvar_imagem(img);


                    contadorProcessos++;
                    barra.Value = contadorProcessos;
                }
                else
                {
                    tt.Stop();

                    MessageBox.Show(contadorProcessos + " imagens processadas");
                    contadorProcessos = 0;
                    maximoProcessos = 0;
                    barra.Value = 0;
                }
            };
        }




        public static void img_to_txt(System.Windows.Forms.ProgressBar barra, int intervalo = 2000)
        {
            Imagens.alimentarImagens();
            maximoProcessos = Utilitarios.Contar_quantos_itens_tem_no_array(listaArquivosIMG);
            barra.Maximum = maximoProcessos;
           

            System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
            tt.Interval = intervalo;

            listaTimers.Add(tt);


            //---Ve qual o ultimo TXT pra continuar a partir dele (pra nao precisar fazer o processo com todas denovo)------------------------------
            int ponteiro = 1;
            while(File.Exists(pastaImagens + "/img (" + ponteiro + ").txt"))
            {
                ponteiro++;
            }
            
            //---------------------------------


            tt.Start();
            tt.Tick += (s, e) =>
            {
                if (contadorProcessos >= 0 && contadorProcessos < listaArquivosIMG.Count)
                {
                    string codigo = Imagens.Converter_para_Texto(listaArquivosIMG[contadorProcessos]);

                    Texto.criar_arquivo_e_gravar(pastaImagens + "/img (" + ponteiro + ").txt", codigo);
                    ponteiro++;

                    contadorProcessos++;
                    barra.Value = contadorProcessos;
                }
                else
                {
                    tt.Stop();

                    MessageBox.Show(contadorProcessos + " imagens processadas");
                    contadorProcessos = 0;
                    maximoProcessos = 0;
                    barra.Value = 0;
                }
            };
        }
        

        public static void mp4_to_enc(System.Windows.Forms.ProgressBar barra, int intervalo = 2000)
        {
            MP4.alimentarVideos();
            maximoProcessos = Utilitarios.Contar_quantos_itens_tem_no_array(listaArquivosMP4);
            barra.Maximum = maximoProcessos; 


            System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
            tt.Interval = intervalo;

            listaTimers.Add(tt);


            tt.Start();
            tt.Tick += (s, e) =>
            {
                if (contadorProcessos >= 0 && contadorProcessos < listaArquivosMP4.Count)
                {

                    ///ENC.Descriptografar_pra_MP4(listaArquivosMP4[contadorProcessos]);
                    MP4.Criptografar_para_ENC(listaArquivosMP4[contadorProcessos]);

                    contadorProcessos++;
                    barra.Value = contadorProcessos;
                }
                else
                {


                    tt.Stop();
                    MessageBox.Show(contadorProcessos + " videos processadas");
                    contadorProcessos = 0;
                    maximoProcessos = 0;
                    barra.Value = 0;

                }
            };
        }
        

        public static void enc_to_mp4(System.Windows.Forms.ProgressBar barra, int intervalo = 2000)
        {
            ENC.alimentarVideosENC();
            maximoProcessos = Utilitarios.Contar_quantos_itens_tem_no_array(listaArquivosENC);
            barra.Maximum = maximoProcessos;
             


            System.Windows.Forms.Timer tt = new System.Windows.Forms.Timer();
            tt.Interval = intervalo;

            listaTimers.Add(tt);


            tt.Start();
            tt.Tick += (s, e) =>
            {
                if (contadorProcessos >= 0 && contadorProcessos < listaArquivosENC.Count)
                {

                    ENC.Descriptografar_pra_MP4(listaArquivosENC[contadorProcessos]);

                    contadorProcessos++;
                    barra.Value = contadorProcessos;
                }
                else
                {
                    tt.Stop();

                    MessageBox.Show(contadorProcessos + " videos processadas");
                    contadorProcessos = 0;
                    maximoProcessos = 0;
                    barra.Value = 0;
                }
            };
        }





    }
}
