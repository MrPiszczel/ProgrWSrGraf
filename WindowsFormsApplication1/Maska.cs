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
    public partial class Maska : Form
    {
        public Maska()
        {
            InitializeComponent();
        }

        public static Bitmap original;
        public static Bitmap modify;

        private void close_Click(object sender, EventArgs e)
        {
            Form1.selectOperation = 2;

            int[,] mask = new int[3, 3];
            mask[0, 0] = Int32.Parse(pixel1.Text);
            mask[0, 1] = Int32.Parse(pixel2.Text);
            mask[0, 2] = Int32.Parse(pixel3.Text);
            mask[1, 0] = Int32.Parse(pixel4.Text);
            mask[1, 1] = Int32.Parse(pixel5.Text);
            mask[1, 2] = Int32.Parse(pixel6.Text);
            mask[2, 0] = Int32.Parse(pixel7.Text);
            mask[2, 1] = Int32.Parse(pixel8.Text);
            mask[2, 2] = Int32.Parse(pixel9.Text);

            int sum = mask[0, 0] +
                mask[0, 1] +
                mask[0, 2] +
                mask[1, 0] +
                mask[1, 1] +
                mask[1, 2] +
                mask[2, 0] +
                mask[2, 1] +
                mask[2, 2];
            original = Form1.bitOriginal;
            modify = Form1.bitModify;

            Color k1;
            Color k2;
            Color k3;
            Color k4;
            Color k5;
            Color k6;
            Color k7;
            Color k8;
            Color k9;

            int r,g,b,s;
            

            for (int i = 1; i < original.Width - 1; i++)
            {
                for (int j = 1; j < original.Height - 1; j++)
                {
                    k1 = original.GetPixel(i - 1, j - 1);
                    k2 = original.GetPixel(i, j - 1);
                    k3 = original.GetPixel(i + 1, j - 1);
                    k4 = original.GetPixel(i - 1, j);
                    k5 = original.GetPixel(i, j);
                    k6 = original.GetPixel(i + 1, j);
                    k7 = original.GetPixel(i - 1, j + 1);
                    k8 = original.GetPixel(i, j + 1);
                    k9 = original.GetPixel(i + 1, j + 1);

                    

                    //r
                    s = k1.R * mask[0, 0] +
                        k2.R * mask[0, 1] +
                        k3.R * mask[0, 2] +
                        k4.R * mask[1, 0] +
                        k5.R * mask[1, 1] +
                        k6.R * mask[1, 2] +
                        k7.R * mask[2, 0] +
                        k8.R * mask[2, 1] +
                        k9.R * mask[2, 2];

                    try
                    {
                        r = s / sum;
                    }
                    catch (DivideByZeroException w)
                    {
                        r = s;
                    }

                    
                  

                    if (r > 255)
                    {
                        r = 255;
                    }
                    if(r < 0)
                    {
                        r = 0;
                    }

                    //g

                    s = k1.G * mask[0, 0] +
                        k2.G * mask[0, 1] +
                        k3.G * mask[0, 2] +
                        k4.G * mask[1, 0] +
                        k5.G * mask[1, 1] +
                        k6.G * mask[1, 2] +
                        k7.G * mask[2, 0] +
                        k8.G * mask[2, 1] +
                        k9.G * mask[2, 2];

                    try { 
                    g = s / sum;
                    }
                    catch (DivideByZeroException w)
                    {
                        g = s;
                    }

                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }

                    //b

                    s = k1.B * mask[0, 0] +
                        k2.B * mask[0, 1] +
                        k3.B * mask[0, 2] +
                        k4.B * mask[1, 0] +
                        k5.B * mask[1, 1] +
                        k6.B * mask[1, 2] +
                        k7.B * mask[2, 0] +
                        k8.B * mask[2, 1] +
                        k9.B * mask[2, 2];

                    try
                    {
                    b = s / sum;
                    }
                    catch (DivideByZeroException w)
                    {
                        b = s;
                    }

                    if (b > 255)
                    {
                        b = 255;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }

                    modify.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

                Close();
        }
    }
}
