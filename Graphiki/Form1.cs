using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Graphiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            getCoordinats();
            this.checkBox1.CheckedChanged += new System.EventHandler(button1_Click);
            this.checkBox2.CheckedChanged += new System.EventHandler(button2_Click);
            this.checkBox3.CheckedChanged += new System.EventHandler(button3_Click);
            this.checkBox4.CheckedChanged += new System.EventHandler(button4_Click);
            this.label2.Click += new System.EventHandler(button1_Click);
            this.label3.Click += new System.EventHandler(button2_Click);
            this.label4.Click += new System.EventHandler(button3_Click);
            this.label5.Click += new System.EventHandler(button4_Click);
            this.button6.Click += new System.EventHandler(button1_Click);
            this.button6.Click += new System.EventHandler(button2_Click);
            this.button6.Click += new System.EventHandler(button3_Click);
            this.button6.Click += new System.EventHandler(button4_Click);
            this.button6.Click += new System.EventHandler(button6_Click);
        }
        int y, x;
        int[] xs = new int[161];
        int[] ys = new int[161];
        Pen parab = new Pen(Color.Red, 1);
        Pen hyp = new Pen(Color.DodgerBlue, 1);
        Pen sin = new Pen(Color.LimeGreen, 1);
        Pen qparab = new Pen(Color.BlueViolet, 1);
        void getCoordinats()
        {
            y = pictureBox1.Width / 2;
            for (x = 0; x < pictureBox1.Width; x++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.Black);
            }
            x = pictureBox1.Height / 2;
            for (y = 0; y < pictureBox1.Height; y++)
            {
                ((Bitmap)pictureBox1.Image).SetPixel(x, y, Color.Black);
            }
            pictureBox1.Refresh();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "Парабола";
            getCoordinats();

            x = -80;
            for (int i = 0; i < xs.Length; i++)
            {
                y = (x * x) / 13;
                xs[i] = x;
                ys[i] = y;
                x++;
            }
            int h = 1;
            for (int j = 1; j < ys.Length; j++)
            {
                using (var graphics = Graphics.FromImage(((Bitmap)pictureBox1.Image)))
                {
                    graphics.DrawLine(parab, 300 - xs[h], 300 - ys[j], 300 - xs[h - 1], 300 - ys[j - 1]);
                }
                h++;
            }
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Гипербола";
            getCoordinats();
            float k = 60;
            int xMin = -(int)k;
            int xMax = (int)k;
            int yMax = (int)k;
            int yMin = -(int)k;
            int dx = pictureBox1.Width / (xMax - xMin);
            int dy = pictureBox1.Height / (yMax - yMin);
            float lastx = -100, lasty = -100;
            for (float x = xMin; x < xMax; x = (float)(x + dx * 0.01))
            {
                float y = k / x;
                float xg = dx * (x - xMin);
                float yg = dy * (yMax - y);
                using (var hyper = Graphics.FromImage(((Bitmap)pictureBox1.Image)))
                {
                    hyper.DrawLine(hyp, xg, yg, lastx, lasty);
                }
                lastx = xg;
                lasty = yg;
            }
            getCoordinats();
            pictureBox1.Refresh();
        }
        float[] sinxs = new float[600];
        float[] sinys = new float[600];
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Синусоида";
            getCoordinats();
            float sinx = 0;
            for (int i = 0; i < sinxs.Length; i++)
            {
                float siny = (float)Math.Sin(sinx) * 7;
                sinxs[i] = sinx;
                sinys[i] = siny;
                sinx += 0.07f;
            }
            int k = 1;
            for (int j = 1; j < sinxs.Length; j++)
            {
                using (var sinusida = Graphics.FromImage(((Bitmap)pictureBox1.Image)))
                {
                    sinusida.DrawLine(sin, sinxs[k] * 17, 300 - sinys[j] * 11, sinxs[k - 1] * 17, 300 - sinys[j - 1] * 11);
                }
                k++;
            }
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getCoordinats();
            label1.Text = "Кубическая парабола";
            x = 80;
            for (int i = 0; i < xs.Length; i++)
            {
                y = (x * x * x) / 1700;
                xs[i] = x;
                ys[i] = y;
                x--;
            }
            int h = 1;
            for (int j = 1; j < ys.Length; j++)
            {
                using (var graphics = Graphics.FromImage(((Bitmap)pictureBox1.Image)))
                {
                    graphics.DrawLine(qparab, 300 - xs[h], 300 - ys[j], 300 - xs[h - 1], 300 - ys[j - 1]);
                }
                h++;
            }
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                getCoordinats();
                label1.Text = null;
                checkBox1.CheckState = default;
                checkBox2.CheckState = default;
                checkBox3.CheckState = default;
                checkBox4.CheckState = default;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "I AM THE GOD";
        }
    }
}