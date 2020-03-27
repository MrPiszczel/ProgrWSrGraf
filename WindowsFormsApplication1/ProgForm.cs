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
    public partial class ProgForm : Form
    {

        public ProgForm()
        {
            InitializeComponent();
        }

        public static Bitmap modify;

        private void Accept_Click(object sender, EventArgs e)
        {
            Form1.selectOperation = 1;

            modify = Form1.bitModify;

            int g;
            int r;
            int b;
            Color pixel;
            int a;
            for (int i = 0; i < modify.Width; i++)
            {
                for (int j = 0; j < modify.Height; j++)
                {
                    pixel = modify.GetPixel(i, j);
                    g = pixel.G;
                    r = pixel.R;
                    b = pixel.B;
                    a = (r + g + b) / 3;
                    if (a < numericUpDown1.Value)
                    {
                        pixel = Color.Black;
                    }
                    else if (a < numericUpDown2.Value)
                    {
                        pixel = Color.Gray;
                    }
                    else
                    {
                        pixel = Color.White;
                    }


                    modify.SetPixel(i, j, pixel);
                }
            }
            

            Close();
        }

      
    }
}
