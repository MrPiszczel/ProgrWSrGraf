using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static Bitmap bitOriginal;
        public static Bitmap bitModify;
        public static int selectOperation;
        NumericUpDown nud;

        private void button7_Click(object sender, EventArgs e)
        {
            filePanel.BringToFront();
            if (filePanel.Height == 34)
            {
                filePanel.Height = 102;
            }
            else if (filePanel.Height == 102)
            {
                filePanel.Height = 34;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bitOriginal = new Bitmap(ofd.FileName);
                pictureBox2.Image = bitOriginal;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                bitModify = new Bitmap(bitOriginal);
                pictureBox1.Image = bitOriginal;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
              
              
              pictureBox2.Image = pictureBox1.Image;

                
        }

        private void Tools_Click(object sender, EventArgs e)
        {
            toolPanel.BringToFront();
            if (toolPanel.Height == 34)
            {
                toolPanel.Height = 170;
            }
            else if (toolPanel.Height == 170)
            {
                toolPanel.Height = 34;
            }
        }

        private void Mono_Click(object sender, EventArgs e)
        {
            Color pixel;
            int a;
             for (int i = 0; i < bitModify.Width; i++)
            {
                for (int j = 0; j< bitModify.Height; j++)
                {
                    pixel = bitModify.GetPixel(i, j);
                    a = (pixel.R + pixel.G + pixel.B) / 3;
                    pixel = Color.FromArgb(a, a, a);
                    bitModify.SetPixel(i,j,pixel);
                }
            }
             pictureBox2.Image = bitModify;             
        }

        private void Mono2_Click(object sender, EventArgs e)
        {
            int g;
            int r;
            int b;
            Color pixel;
            int dz;
            for (int i = 0; i < bitModify.Width; i++)
            {
                for (int j = 0; j < bitModify.Height; j++)
                {
                    pixel = bitModify.GetPixel(i, j);
                    dz = (pixel.G + pixel.R + pixel.B);
                    g = pixel.G;
                    r = pixel.R;
                    b = pixel.B;
                    if (dz != 0)
                    {
                        var a = (r * pixel.R / dz + g * pixel.G / dz + b * pixel.B / dz);
                        pixel = Color.FromArgb(a, a, a);
                        bitModify.SetPixel(i, j, pixel);
                    }
                    else
                    {
                        pixel = Color.FromArgb(0, 0, 0);
                        bitModify.SetPixel(i, j, pixel);
                    }
                }
            }
            pictureBox2.Image = bitModify;
        }

        private void Prog_Click(object sender, EventArgs e)
        {
            ProgForm pf = new ProgForm();
            pf.ShowDialog();

            
        }

        private void maska_Click(object sender, EventArgs e)
        {
            Maska m = new Maska();
            m.ShowDialog();
        }


        private void refresh_Click(object sender, EventArgs e)
        {
            if (selectOperation == 1)
            {
                bitModify = ProgForm.modify;
                pictureBox2.Image = bitModify;
            }
            else if (selectOperation == 2)
            {
                bitModify = Maska.modify;

                pictureBox2.Image = bitModify;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


    }
}
