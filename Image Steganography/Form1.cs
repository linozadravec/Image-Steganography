using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganografija_slike
{
    public partial class Form1 : Form
    {
        public string fileContent;
        public byte[] byteoviSlike;
        public byte[] byteoviPoruke;
        public int brojBitovaEnkodiranja=1;
        string filepath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OdaberiSliku_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //openFileDialog.InitialDirectory = @"c:\users\lino\desktop\slike";
                openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|all files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;

                    lbl_ImeDatoteke.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void btn_Enkodiraj_Click(object sender, EventArgs e)
        {
            if(txt_Tekst.TextLength != 0)
            {
                string tekstPoruke = txt_Tekst.Text;
                byteoviPoruke = Encoding.ASCII.GetBytes(tekstPoruke);

                //string endDirectory = @"C:\Users\Lino\Desktop\Slike\EnkodiraneSlike";
                string endDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                using (FileStream SourceStream = File.Open(filepath, FileMode.Open))
                {
                    string endString = endDirectory + "\\" +  lbl_ImeDatoteke.Text.Substring(0,lbl_ImeDatoteke.Text.Length-4) + "_Enkodirano.bmp";

                    Bitmap slikaBitmap = new Bitmap(SourceStream);
                    BitArray bitoviPoruke = new BitArray(byteoviPoruke);

                    int brojacBita = 0;

                    for (int i = 0; i < slikaBitmap.Height && brojacBita < byteoviPoruke.Length * 8; i++)
                    {
                        for (int j = 0; j < slikaBitmap.Width && brojacBita < byteoviPoruke.Length * 8; j++)
                        {
                            Color boja = slikaBitmap.GetPixel(j, i); 
                            int brojBoje = boja.ToArgb();

                            for (int k = 0; k < brojBitovaEnkodiranja; k++)
                            {

                                if (bitoviPoruke.Get(brojacBita))
                                {
                                    brojBoje |= 1 << k;
                                }
                                else
                                {
                                    brojBoje &= ~(1 << k);
                                }

                                brojacBita++;
                            }
                            Color novaBoja = Color.FromArgb(brojBoje);
                            slikaBitmap.SetPixel(j, i, novaBoja);
                        }
                    }
                    slikaBitmap.Save(endString);
                    MessageBox.Show("Enkodiran bitmap uspješno kreiran na lokaciji: " + endString);
                }
            }
            else
            {
                MessageBox.Show("Prvo upišite neki tekst");
            }
        }


        private void btn_Dekodiraj_Click(object sender, EventArgs e)
        {
            string dekodiranaPoruka;

            using (FileStream SourceStream = File.Open(filepath, FileMode.Open))
            {
                Console.WriteLine(filepath);
                Bitmap slikaBitmap = new Bitmap(SourceStream);
                int rezolucijaSlike = slikaBitmap.Width * slikaBitmap.Height;
                BitArray bitoviPoruke = new BitArray(rezolucijaSlike * brojBitovaEnkodiranja);

                int brojacBita = 0;
                

                for (int i = 0; i < slikaBitmap.Height; i++)
                {
                    for (int j = 0; j < slikaBitmap.Width; j++)
                    {
                        Color boja = slikaBitmap.GetPixel(j, i);
                        int brojBoje = boja.ToArgb();

                        BitArray brojBojeBitovi = new BitArray(new int[] { brojBoje });

                        for (int k = 0; k < brojBitovaEnkodiranja; k++)
                        {                        
                            if (brojBojeBitovi.Get(k))
                            {
                                bitoviPoruke.Set(brojacBita, true);
                            }
                            else
                            {
                                bitoviPoruke.Set(brojacBita, false);
                            }

                            brojacBita++;
                        }
                    }
                }

                byte[] bytes = new byte[slikaBitmap.Width * slikaBitmap.Height];
                bitoviPoruke.CopyTo(bytes, 0);

                dekodiranaPoruka = Encoding.ASCII.GetString(bytes);
                txt_DekodiraniTekst.Text = dekodiranaPoruka;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            brojBitovaEnkodiranja = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}





