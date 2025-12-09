using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImgToText
{
    internal class ImgToText_Class
    {
        public class Diversos
        { 
            public static string gerarSenha(int num_caracteres)
            {
                const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder senha = new StringBuilder();

                // Instanciar um gerador de números aleatórios
                Random random = new Random();

                // Gerar a senha
                for (int i = 0; i < num_caracteres; i++)
                {
                    // Escolher um caractere aleatório da string de caracteresPermitidos
                    int indice = random.Next(caracteresPermitidos.Length);
                    senha.Append(caracteresPermitidos[indice]);
                }

                return senha.ToString();
            }
            public static void SalvarTXT(string imagem_convertida)
            {
                if (imagem_convertida.Length != 0)
                {
                    int ct = 1;
                    for (int i = 1; i < 1000; i++)
                    {
                        if (!File.Exists(Properties.Settings.Default.PastaImagens+"/img (" + i + ").txt"))
                        {
                            ct = i;
                            break;
                        }
                    }
                    File.WriteAllText(Properties.Settings.Default.PastaImagens+"/img (" + ct + ").txt", imagem_convertida);
                }
                
            } 
            public static void SalvarIMG(PictureBox picturebox)
            {
                try
                {
                    const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    StringBuilder senha = new StringBuilder();

                    // Instanciar um gerador de números aleatórios
                    Random random = new Random();

                    // Gerar a senha
                    for (int i = 0; i < 10; i++)
                    {
                        // Escolher um caractere aleatório da string de caracteresPermitidos
                        int indice = random.Next(caracteresPermitidos.Length);
                        senha.Append(caracteresPermitidos[indice]);
                    }

                    string filePath = Properties.Settings.Default.PastaImagens+"/"+senha.ToString() + ".png";

                    if(picturebox.Image != null)
                    {
                        using (Bitmap copia = new Bitmap(picturebox.Image))
                        {
                            copia.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                    
                }
                catch(Exception o) {
                    MessageBox.Show(o.ToString());

                }
            }
            public static string joaat_hexadecimal(string input)
            {
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

                return "0x" + hash.ToString("X");
            }
            public static string joaat_decimal(string input)
            {
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

                return hash.ToString();
            }
        }
        public class Com_OpenDialog
        {
            public static string ImgtoText(string password)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog {  })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                        string base64String = Convert.ToBase64String(imageBytes);

                        //---------------------
                        string input = password;
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


                        return Convert.ToBase64String(Encoding.UTF8.GetBytes(e2.ToString()));
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
        public class Sem_OpenDialog
        {
            public static string ImgtoText(string caminho_img,string password)
            {
                byte[] imageBytes = File.ReadAllBytes(caminho_img);
                        string base64String = Convert.ToBase64String(imageBytes);

                        //---------------------
                        string input = password;
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

                        return Convert.ToBase64String(Encoding.UTF8.GetBytes(e2.ToString()));
                    
                   
            }
            public static Image Text_to_Img(string texto, string password)
            {
                try
                {
                    string input = password;
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
                        // Carrega a imagem no PictureBox
                        return System.Drawing.Image.FromStream(ms);
                    }
                }
                catch { return null; }
            }
        }
 
        public class Processamento
        {
            public static int ctOK = 0;
            public static int ctERRRO = 0;
            public static int ponteiro = 0;

            public static void converter_imagen_para_txt(string caminho_img, string password)
            {
                byte[] imageBytes = File.ReadAllBytes(caminho_img);
                string base64String = Convert.ToBase64String(imageBytes);

                //---------------------
                string input = password;
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

                
                Diversos.SalvarTXT(Convert.ToBase64String(Encoding.UTF8.GetBytes(e2.ToString())));
            }

            public static void converter_todas_imagens_da_pasta_para_txt(string password)
            {
                string diretorio = Properties.Settings.Default.PastaImagens;
                string[] extensoesImagem = new string[] { "*.jpg", "*.jpeg", "*.png", "*.bmp", "*.gif" };
                string[] arquivosImagens = new string[0];
                foreach (var extensao in extensoesImagem)
                {
                    arquivosImagens = arquivosImagens.Concat(Directory.GetFiles(diretorio, extensao)).ToArray();
                }

                int ct = 0;
                foreach (var imagem in arquivosImagens)
                {
                    
                    Diversos.SalvarTXT(Sem_OpenDialog.ImgtoText(imagem, password));
                    ct++;
                    
                }
                MessageBox.Show(ct + " imagens convertidas");
                 
            }
            public static void converter_txt_para_png(PictureBox pictureBox,string password)
            {
                 
                 
            }
            public static void converter_todos_txt_da_pasta_para_png(PictureBox pictureBox,string password)
            {
                int ct = 1;

              

                while (File.Exists(Properties.Settings.Default.PastaImagens+"/img (" + ct + ").txt"))
                {
                    pictureBox.Image = Sem_OpenDialog.Text_to_Img(File.ReadAllText(Properties.Settings.Default.PastaImagens + "/img (" + ct + ").txt"), password);
                     
                    Diversos.SalvarIMG(pictureBox);

                    ct++;


                }


                MessageBox.Show(ct + " imagens convertidas");
            }
        }

        public class ConversorJPEG
        {

            public static string pasta = "";
            public static string[] arquivos  = { "" };
            public static string pastaConvertidas="";
            public static int ctOK = 0;
            public static int ctERRRO = 0;
            public static int ponteiro = 0;

        }

        


        public class Encriptador_de_Video
        {
              

            static readonly byte[] MAGIC = Encoding.ASCII.GetBytes("VIDENC01"); // 8 bytes
            const int SALT_LEN = 16;
            const int IV_LEN = 12; // recomendado para AES-GCM
            const int TAG_LEN = 16; // AES-GCM tag
            const int PBKDF2_ITER = 200_000; // ajuste conforme necessidade
            const int KEY_LEN = 32; // 256 bits

            public static System.Linq.IOrderedEnumerable<string> files;

            public static int ctOK = 0;
            public static int ctERRRO = 0;
            public static int ponteiro = 0;


            public static void DecryptFile(string filepath, string password)
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
                using var kdf = new Rfc2898DeriveBytes(password, salt, PBKDF2_ITER, HashAlgorithmName.SHA256);
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
                
               // Console.WriteLine($"Decrypted: {Path.GetFileName(filepath)} -> {Path.GetFileName(outPath)}");
            }


            public static void EncryptFile(string filepath, string password)
            {
                byte[] plain = File.ReadAllBytes(filepath);
                using var rng = RandomNumberGenerator.Create();
                byte[] salt = new byte[SALT_LEN];
                rng.GetBytes(salt);
                byte[] iv = new byte[IV_LEN];
                rng.GetBytes(iv);

                // Deriva chave com PBKDF2 (Rfc2898)
                using var kdf = new Rfc2898DeriveBytes(password, salt, PBKDF2_ITER, HashAlgorithmName.SHA256);
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
                Console.WriteLine($"Encrypted: {Path.GetFileName(filepath)} -> {Path.GetFileName(outPath)}");
            }
        }

    }
}


