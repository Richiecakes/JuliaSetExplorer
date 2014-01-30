using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace JuliaSetExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int imageWidth = 1000;
        static int imageHeight = 1000;
        static int iterations = 200;

        Bitmap drawingSurface = new Bitmap(imageWidth, imageHeight);

        private void renderJuliaSet()
        {
            Graphics GFX = Graphics.FromImage(drawingSurface);
            GFX.FillRectangle(Brushes.White, 0, 0, imageWidth, imageHeight);

            decimal Sx = (decimal)-1.5;
            decimal Sy = (decimal)-1.5;
            decimal Fx = (decimal)1.5;
            decimal Fy = (decimal)1.5;
            decimal x, y, x1, y1, xx = 0;
            decimal xmin, xmax, ymin, ymax = 0;
            decimal real = nmReal.Value;
            decimal imag = nmImaginary.Value;
            int looper, s, z = 0;
            decimal intigralX, intigralY = 0;
            xmin = Sx;
            ymin = Sy;
            xmax = Fx;
            ymax = Fy;
            intigralX = (xmax - xmin) / imageWidth;
            intigralY = (ymax - ymin) / imageHeight;
            x = xmin;
            for (s = 1; s < imageWidth; s++)
            {
                y = ymin;
                for (z = 1; z < imageHeight; z++)
                {
                    x1 = 0;
                    y1 = 0;
                    looper = 0;
                    while (looper < iterations && Math.Sqrt(((double)x1 * (double)x1) + ((double)y1 * (double)y1)) < 2)
                    {
                        if (looper == 0)
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + x;
                            y1 = 2 * x1 * y1 + y;
                            x1 = xx;
                        }
                        else
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + real;
                            y1 = 2 * x1 * y1 + imag;
                            x1 = xx;
                        }
                    }
                    if (looper == iterations)
                    {
                        drawingSurface.SetPixel(s, z, Color.Black);
                    }
                    else
                    {
                        if (looper > (iterations / 2))
                        {
                            double perc = (double)looper / (double)iterations;
                            drawingSurface.SetPixel(s, z, Color.FromArgb((int)((perc - 0.5) * 510), 255, (int)((perc - 0.5) * 510)));
                        }
                        else
                        {
                            double perc = (double)looper / (double)iterations;
                            drawingSurface.SetPixel(s, z, Color.FromArgb(0, (int)(perc * 510), 0));
                        }
                    }

                    y += intigralY;
                }
                x += intigralX;
            }
            pictureBox1.Image = drawingSurface;
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(renderJuliaSet));
            t1.IsBackground = true;
            t1.Start();            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nmReal.Value = (decimal)0.0;
            nmImaginary.Value = (decimal)0.0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".bmp";
            saveFileDialog1.Filter = "Bitmap Files (*.bmp)|.bmp";
            saveFileDialog1.FileName = imageWidth.ToString() + " x " + imageHeight.ToString() + " " + iterations.ToString() + " Iterations " + nmReal.Value.ToString() + " + " + nmImaginary.Value.ToString() + "i";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawingSurface.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            }
        }

        static Random r = new Random();


        private void btnRandom_Click(object sender, EventArgs e)
        {
            double x = r.NextDouble() * 4 - 2;
            double y = r.NextDouble() * 4 - 2;

            nmReal.Value = (decimal)x;
            nmImaginary.Value = (decimal)y;

        }
    }
}
