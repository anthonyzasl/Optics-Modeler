using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova
{
    public partial class Pobudova : Form
    {
        public Pobudova()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

            Pen mirrorPen = new Pen(Color.Blue, 2);
            Pen dashedPen = new Pen(Color.Orange, 1) { DashPattern = new float[] { 5, 5 } };

            if (radioButton1.Checked == true) 
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300);
                gr.DrawLine(mirrorPen, 250, 300, 250, 150);

                gr.FillEllipse(Brushes.Red, 320, 195, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(330, 190));
                gr.DrawLine(dashedPen, 325, 200, 175, 200);

                gr.FillEllipse(Brushes.Orange, 170, 195, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(145, 190));
                gr.DrawLine(dashedPen, 175, 200, 175, 400);

                gr.FillEllipse(Brushes.Orange, 170, 395, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(145, 390));
                gr.DrawLine(dashedPen, 175, 400, 325, 400);

                gr.FillEllipse(Brushes.Orange, 320, 395, 10, 10);
                gr.DrawString("S3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(330, 390));
                gr.DrawLine(dashedPen, 325, 400, 325, 200);
            }

            if (radioButton2.Checked == true)
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300); 
                gr.DrawLine(mirrorPen, 250, 300, (float)(250 + 150 * Math.Cos(120 * Math.PI / 180)), (float)(300 - 150 * Math.Sin(120 * Math.PI / 180)));

                gr.FillEllipse(Brushes.Red, (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)) - 5, (float)(300 - 75 * Math.Sin(60 * Math.PI / 180)) - 5, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(295, 220));
                gr.DrawLine(dashedPen, (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)), (float)(300 - 75 * Math.Sin(60 * Math.PI / 180)), 165, 300);

                gr.FillEllipse(Brushes.Orange, 160, 295, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(135, 300));
                gr.DrawLine(dashedPen, 165, 300, (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)), (float)(438 - 75 * Math.Sin(60 * Math.PI / 180)));

                gr.FillEllipse(Brushes.Orange, (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)) - 5, (float)(438 - 75 * Math.Sin(60 * Math.PI / 180)) - 5, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(295, 365));
                gr.DrawLine(dashedPen, (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)), (float)(300 - 75 * Math.Sin(60 * Math.PI / 180)), (float)(250 + 75 * Math.Cos(60 * Math.PI / 180)), (float)(438 - 75 * Math.Sin(60 * Math.PI / 180)));
            }

            if (radioButton3.Checked == true)
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300);
                gr.DrawLine(mirrorPen, 250, 300, 250 + 150 * (float)Math.Cos(72 * Math.PI / 180), 300 - 150 * (float)Math.Sin(72 * Math.PI / 180));

                gr.FillEllipse(Brushes.Red, 250 + 100 * (float)Math.Cos(36 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(36 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(325, 220));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(36 * Math.PI / 180), 300 - 100 * (float)Math.Sin(36 * Math.PI / 180), 250 + 100 * (float)Math.Cos(36 * Math.PI / 180), 300 + 100 * (float)Math.Sin(36 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(36 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(36 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(335, 350));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(36 * Math.PI / 180), 300 + 100 * (float)Math.Sin(36 * Math.PI / 180), 250 + 100 * (float)Math.Cos(108 * Math.PI / 180), 300 + 100 * (float)Math.Sin(108 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(108 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(108 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 405));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(108 * Math.PI / 180), 300 + 100 * (float)Math.Sin(108 * Math.PI / 180), 250 - 100, 300);

                gr.FillEllipse(Brushes.Orange, 250 - 100 - 5, 300 - 5, 10, 10);
                gr.DrawString("S4", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(115, 290));
                gr.DrawLine(dashedPen, 250 - 100, 300, 250 + 100 * (float)Math.Cos(108 * Math.PI / 180), 300 - 100 * (float)Math.Sin(108 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(108 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(108 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 175));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(108 * Math.PI / 180), 300 - 100 * (float)Math.Sin(108 * Math.PI / 180), 250 + 100 * (float)Math.Cos(36 * Math.PI / 180), 300 - 100 * (float)Math.Sin(36 * Math.PI / 180));
            }

            if (radioButton5.Checked == true)
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300);
                gr.DrawLine(mirrorPen, 250, 300, 250 + 150 * (float)Math.Cos(45 * Math.PI / 180), 300 - 150 * (float)Math.Sin(45 * Math.PI / 180));

                gr.FillEllipse(Brushes.Red, 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(22.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 250));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(22.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(22.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(22.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 325));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(22.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(67.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(67.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S7", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(275, 400));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(67.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(112.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(112.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S6", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 400));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(112.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(157.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(157.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S5", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(125, 325));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180), 300 + 100 * (float)Math.Sin(157.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(157.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(157.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S4", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(125, 250));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(157.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(157.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(112.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(112.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 180));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(112.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(112.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(67.5 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(67.5 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(275, 180));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(67.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(67.5 * Math.PI / 180), 250 + 100 * (float)Math.Cos(22.5 * Math.PI / 180), 300 - 100 * (float)Math.Sin(22.5 * Math.PI / 180));
            }

            if (radioButton6.Checked == true)
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300);
                gr.DrawLine(mirrorPen, 250, 300, 250 + 150 * (float)Math.Cos(60 * Math.PI / 180), 300 - 150 * (float)Math.Sin(60 * Math.PI / 180));

                gr.FillEllipse(Brushes.Red, 250 + 100 * (float)Math.Cos(30 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(30 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(345, 235));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(30 * Math.PI / 180), 300 - 100 * (float)Math.Sin(30 * Math.PI / 180), 250 + 100 * (float)Math.Cos(30 * Math.PI / 180), 300 + 100 * (float)Math.Sin(30 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(30 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(30 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(345, 335));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(30 * Math.PI / 180), 300 + 100 * (float)Math.Sin(30 * Math.PI / 180), 250, 300 + 100);

                gr.FillEllipse(Brushes.Orange, 250 - 5, 300 + 100 - 5, 10, 10);
                gr.DrawString("S5", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(245, 410));
                gr.DrawLine(dashedPen, 250, 300 + 100, 250 + 100 * (float)Math.Cos(150 * Math.PI / 180), 300 + 100 * (float)Math.Sin(150 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(150 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(150 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S4", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(130, 335));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(150 * Math.PI / 180), 300 + 100 * (float)Math.Sin(150 * Math.PI / 180), 250 + 100 * (float)Math.Cos(150 * Math.PI / 180), 300 - 100 * (float)Math.Sin(150 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(150 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(150 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(130, 235));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(150 * Math.PI / 180), 300 - 100 * (float)Math.Sin(150 * Math.PI / 180), 250, 300 - 100);

                gr.FillEllipse(Brushes.Orange, 250 - 5, 300 - 100 - 5, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(245, 175));
                gr.DrawLine(dashedPen, 250, 300 - 100, 250 + 100 * (float)Math.Cos(30 * Math.PI / 180), 300 - 100 * (float)Math.Sin(30 * Math.PI / 180));
            }

            if (radioButton4.Checked == true)
            {
                gr.DrawLine(mirrorPen, 250, 300, 400, 300);
                gr.DrawLine(mirrorPen, 250, 300, 250 + 150 * (float)Math.Cos(30 * Math.PI / 180), 300 - 150 * (float)Math.Sin(30 * Math.PI / 180));

                gr.FillEllipse(Brushes.Red, 250 + 100 * (float)Math.Cos(15 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(15 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(355, 255));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(15 * Math.PI / 180), 300 - 100 * (float)Math.Sin(15 * Math.PI / 180), 250 + 100 * (float)Math.Cos(15 * Math.PI / 180), 300 + 100 * (float)Math.Sin(15 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(15 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(15 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(355, 305));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(15 * Math.PI / 180), 300 + 100 * (float)Math.Sin(15 * Math.PI / 180), 250 + 100 * (float)Math.Cos(45 * Math.PI / 180), 300 + 100 * (float)Math.Sin(45 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(45 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(45 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S11", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(325, 360));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(45 * Math.PI / 180), 300 + 100 * (float)Math.Sin(45 * Math.PI / 180), 250 + 100 * (float)Math.Cos(75 * Math.PI / 180), 300 + 100 * (float)Math.Sin(75 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(75 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(75 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S10", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(285, 395));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(75 * Math.PI / 180), 300 + 100 * (float)Math.Sin(75 * Math.PI / 180), 250 + 100 * (float)Math.Cos(105 * Math.PI / 180), 300 + 100 * (float)Math.Sin(105 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(105 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(105 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S9", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(220, 405));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(105 * Math.PI / 180), 300 + 100 * (float)Math.Sin(105 * Math.PI / 180), 250 + 100 * (float)Math.Cos(135 * Math.PI / 180), 300 + 100 * (float)Math.Sin(135 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(135 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(135 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S8", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(145, 360));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(135 * Math.PI / 180), 300 + 100 * (float)Math.Sin(135 * Math.PI / 180), 250 + 100 * (float)Math.Cos(165 * Math.PI / 180), 300 + 100 * (float)Math.Sin(165 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(165 * Math.PI / 180) - 5, 300 + 100 * (float)Math.Sin(165 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S7", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(125, 305));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(165 * Math.PI / 180), 300 + 100 * (float)Math.Sin(165 * Math.PI / 180), 250 + 100 * (float)Math.Cos(165 * Math.PI / 180), 300 - 100 * (float)Math.Sin(165 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(165 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(165 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S6", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(125, 255));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(165 * Math.PI / 180), 300 - 100 * (float)Math.Sin(165 * Math.PI / 180), 250 + 100 * (float)Math.Cos(135 * Math.PI / 180), 300 - 100 * (float)Math.Sin(135 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(135 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(135 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S5", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(145, 200));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(135 * Math.PI / 180), 300 - 100 * (float)Math.Sin(135 * Math.PI / 180), 250 + 100 * (float)Math.Cos(105 * Math.PI / 180), 300 - 100 * (float)Math.Sin(105 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(105 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(105 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S4", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(220, 170));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(105 * Math.PI / 180), 300 - 100 * (float)Math.Sin(105 * Math.PI / 180), 250 + 100 * (float)Math.Cos(75 * Math.PI / 180), 300 - 100 * (float)Math.Sin(75 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(75 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(75 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(285, 170));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(75 * Math.PI / 180), 300 - 100 * (float)Math.Sin(75 * Math.PI / 180), 250 + 100 * (float)Math.Cos(45 * Math.PI / 180), 300 - 100 * (float)Math.Sin(45 * Math.PI / 180));

                gr.FillEllipse(Brushes.Orange, 250 + 100 * (float)Math.Cos(45 * Math.PI / 180) - 5, 300 - 100 * (float)Math.Sin(45 * Math.PI / 180) - 5, 10, 10);
                gr.DrawString("S2", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(335, 200));
                gr.DrawLine(dashedPen, 250 + 100 * (float)Math.Cos(45 * Math.PI / 180), 300 - 100 * (float)Math.Sin(45 * Math.PI / 180), 250 + 100 * (float)Math.Cos(15 * Math.PI / 180), 300 - 100 * (float)Math.Sin(15 * Math.PI / 180));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;

            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            
            int x = Convert.ToInt32(textBox1.Text);

            int d = 340 - x;
            int f = (80 * d) / (d - 80);
            int H = -(40 * f / d);

            if (d == 78)
            {
                MessageBox.Show("Предмет знаходиться у фокусі. Пoбудова не відбувається", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                Pen mirrorPen = new Pen(Color.Blue, 2);
                Pen dashedPen = new Pen(Color.Orange, 2) { DashPattern = new float[] { 5, 5 } };
                Pen rayPen = new Pen(Color.Green, 2);
                Pen blackPen = new Pen(Color.Black, 2);
                Pen redPen = new Pen(Color.Red, 2);

                gr.DrawArc(mirrorPen, pictureBox1.Width / 2 - 50, pictureBox1.Height / 2 - 100, 75, 200, 280, 160);
                gr.DrawLine(dashedPen, 0, 265, 844, 265);

                gr.DrawLine(blackPen, x, 265, x, 225);

                gr.FillEllipse(Brushes.Black, 260, 265 - 5, 10, 10);
                gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(255, 240));
                gr.FillEllipse(Brushes.Black, 180, 265 - 5, 10, 10);
                gr.DrawString("О", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(175, 240));
                gr.FillEllipse(Brushes.Black, 335, 265 - 5, 10, 10);
                gr.DrawString("P", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(340, 240));

                gr.DrawLine(redPen, 340 - f, 265, 340 - f, 265 - H);

                label3.Text = $"Положення предмету: {ClassifyPosition(d, 78)}";

                if (d < 78)
                {
                    gr.DrawLine(rayPen, 340 - f, 265 - H, 340 - 2 * 80, 265);
                    gr.DrawLine(rayPen, 340 - d, 265 - 40, 340, 265 - 40);
                    gr.DrawLine(rayPen, 340 - f, 265 - H, 340 - 80, 265);
                    label4.Text = $"Зображення предмету: уявне, збільшене, пряме";
                }
                else
                {
                    gr.DrawLine(rayPen, 340 - d, 265 - 40, 340, 265 - 40);
                    gr.DrawLine(rayPen, 340, 265 - 40, 340 - f, 265 - H);
                    gr.DrawLine(rayPen, 340 - d, 265 - 40, 340, 265 + H / -1);
                    gr.DrawLine(rayPen, 340, 265 + H / -1, 340 - f, 265 - H);
                    if (d > 78 && d < 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, збільшене, перевернуте";
                    }
                    else if (d == 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, рівне, перевернуте";
                    }
                    else if (d > 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, зменшене, перевернуте";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;

            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

            int x = Convert.ToInt32(textBox1.Text);

            int d = 261 - x;
            int f = (78 * d) / (d + 78);
            int H = (40 * f / d);

            Pen mirrorPen = new Pen(Color.Blue, 2);
            Pen dashedPen = new Pen(Color.Orange, 2) { DashPattern = new float[] { 5, 5 } };
            Pen rayPen = new Pen(Color.Green, 2);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen redPen = new Pen(Color.Red, 2);

            gr.DrawArc(mirrorPen, pictureBox1.Width / 2 - 50, pictureBox1.Height / 2 - 100, 75, 200, 100, 160);
            gr.DrawLine(dashedPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

            gr.DrawLine(blackPen, x, 265, x, 225);

            gr.FillEllipse(Brushes.Black, 340, 265 - 5, 10, 10);
            gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(345, 240));
            gr.FillEllipse(Brushes.Black, 418, 265 - 5, 10, 10);
            gr.DrawString("О", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(423, 240));
            gr.FillEllipse(Brushes.Black, 262, 265 - 5, 10, 10);
            gr.DrawString("P", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(267, 240));

            gr.DrawLine(redPen, 261 + f, 265, 261 + f, 265 - H);

            label3.Text = $"Положення предмету: {ClassifyPosition(d, 78)}";
            label4.Text = $"Зображення предмету: уявне, зменшене, пряме";

            gr.DrawLine(rayPen, 261 - d, 265 - 40, 261 + 2 * 78, 265);
            gr.DrawLine(rayPen, 261 - d, 265 - 40, 261, 265);
            gr.DrawLine(rayPen, 261 - d, 265 + 40, 261 + 2 * f, 265 - 2 * H);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;

            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

            int d = Convert.ToInt32(textBox2.Text);

            int f = (78 * d) / (d + 78);
            int H = (40 * f / d);

            Pen mirrorPen = new Pen(Color.Blue, 2);
            Pen dashedPen = new Pen(Color.Orange, 2) { DashPattern = new float[] { 5, 5 } };
            Pen rayPen = new Pen(Color.Green, 2);
            Pen rayDashedPen = new Pen(Color.Green, 2) { DashPattern = new float[] { 5, 5 } };
            Pen blackPen = new Pen(Color.Black, 2);
            Pen redPen = new Pen(Color.Red, 2);

            void DrawArrow(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
            {
                g.DrawLine(pen, x1, y1, x2, y2);
                double angle = Math.Atan2(y2 - y1, x2 - x1) + Math.PI;
                PointF arrowP1 = new PointF(x2 - (float)(10 * Math.Cos(angle - Math.PI / 6)), y2 - (float)(10 * Math.Sin(angle - Math.PI / 6)));
                PointF arrowP2 = new PointF(x2 - (float)(10 * Math.Cos(angle + Math.PI / 6)), y2 - (float)(10 * Math.Sin(angle + Math.PI / 6)));
                g.DrawLine(pen, x2, y2, (int)arrowP1.X, (int)arrowP1.Y);
                g.DrawLine(pen, x2, y2, (int)arrowP2.X, (int)arrowP2.Y);
            }

            DrawArrow(gr, mirrorPen, pictureBox1.Width / 2, pictureBox1.Height / 2 + 100, pictureBox1.Width / 2, pictureBox1.Height / 2 - 100);
            DrawArrow(gr, mirrorPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 100, pictureBox1.Width / 2, pictureBox1.Height / 2 + 100);

            gr.DrawLine(dashedPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

            gr.DrawLine(blackPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50);

            gr.FillEllipse(Brushes.Black, 233, 265 - 5, 10, 10);
            gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(238, 240));
            gr.FillEllipse(Brushes.Black, 389, 265 - 5, 10, 10);
            gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(394, 240));

            gr.FillEllipse(Brushes.Black, 156, 265 - 5, 10, 10);
            gr.DrawString("2F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(161, 240));
            gr.FillEllipse(Brushes.Black, 467, 265 - 5, 10, 10);
            gr.DrawString("2F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(472, 240));

            gr.DrawLine(redPen, pictureBox1.Width / 2 - f, pictureBox1.Height / 2, pictureBox1.Width / 2 - f, pictureBox1.Height / 2 - H);

            label3.Text = $"Положення предмету: {ClassifyPosition(d, 78)}";
            label4.Text = $"Зображення предмету: уявне, зменшене, пряме";

            gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50);
            gr.DrawLine(rayPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + 78, pictureBox1.Height / 2 - 100);
            gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + 78, pictureBox1.Height / 2 + 78 * 50 / d);
            gr.DrawLine(rayDashedPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 - 78, pictureBox1.Height / 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;

            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

            int d = Convert.ToInt32(textBox2.Text);
            if (d == 78)
            {
                MessageBox.Show("Предмет знаходиться у фокусі. Пoбудова не відбувається", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int f = (78 * d) / (d - 78);
                int H = (40 * f / d);

                Pen mirrorPen = new Pen(Color.Blue, 2);
                Pen dashedPen = new Pen(Color.Orange, 2) { DashPattern = new float[] { 5, 5 } };
                Pen rayPen = new Pen(Color.Green, 2);
                Pen rayDashedPen = new Pen(Color.Green, 2) { DashPattern = new float[] { 5, 5 } };
                Pen blackPen = new Pen(Color.Black, 2);
                Pen redPen = new Pen(Color.Red, 2);

                void DrawArrow(Graphics g, Pen pen, int x1, int y1, int x2, int y2)
                {
                    g.DrawLine(pen, x1, y1, x2, y2);
                    double angle = Math.Atan2(y2 - y1, x2 - x1);
                    PointF arrowP1 = new PointF(x2 - (float)(10 * Math.Cos(angle - Math.PI / 6)), y2 - (float)(10 * Math.Sin(angle - Math.PI / 6)));
                    PointF arrowP2 = new PointF(x2 - (float)(10 * Math.Cos(angle + Math.PI / 6)), y2 - (float)(10 * Math.Sin(angle + Math.PI / 6)));
                    g.DrawLine(pen, x2, y2, (int)arrowP1.X, (int)arrowP1.Y);
                    g.DrawLine(pen, x2, y2, (int)arrowP2.X, (int)arrowP2.Y);
                }

                DrawArrow(gr, mirrorPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 100, pictureBox1.Width / 2, pictureBox1.Height / 2 + 100);
                DrawArrow(gr, mirrorPen, pictureBox1.Width / 2, pictureBox1.Height / 2 + 100, pictureBox1.Width / 2, pictureBox1.Height / 2 - 100);

                gr.DrawLine(dashedPen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);

                gr.DrawLine(blackPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50);

                gr.FillEllipse(Brushes.Black, 233, 265 - 5, 10, 10);
                gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(238, 240));
                gr.FillEllipse(Brushes.Black, 389, 265 - 5, 10, 10);
                gr.DrawString("F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(394, 240));

                gr.FillEllipse(Brushes.Black, 156, 265 - 5, 10, 10);
                gr.DrawString("2F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(161, 240));
                gr.FillEllipse(Brushes.Black, 467, 265 - 5, 10, 10);
                gr.DrawString("2F", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(472, 240));

                gr.DrawLine(redPen, pictureBox1.Width / 2 + f, pictureBox1.Height / 2, pictureBox1.Width / 2 + f, pictureBox1.Height / 2 + H);

                label3.Text = $"Положення предмету: {ClassifyPosition(d, 78)}";

                if (d < 78)
                {
                    gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50);
                    gr.DrawLine(rayDashedPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + f, pictureBox1.Height / 2 + H);
                    gr.DrawLine(rayDashedPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + f, pictureBox1.Height / 2 + H);
                    gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + d, pictureBox1.Height / 2 + 50);
                    gr.DrawLine(rayPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + 78, pictureBox1.Height / 2);
                    label4.Text = $"Зображення предмету: уявне, збільшене, пряме";
                }
                else
                {
                    gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50);
                    gr.DrawLine(rayPen, pictureBox1.Width / 2, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + f, pictureBox1.Height / 2 + H);
                    gr.DrawLine(rayPen, pictureBox1.Width / 2 - d, pictureBox1.Height / 2 - 50, pictureBox1.Width / 2 + f, pictureBox1.Height / 2 + H);
                    if (d > 78 && d < 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, збільшене, перевернуте";
                    }
                    else if (d == 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, рівне, перевернуте";
                    }
                    else if (d > 2 * 78)
                    {
                        label4.Text = $"Зображення предмету: дійсне, зменшене, перевернуте";
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            { 
                return; 
            }
            var result = MessageBox.Show("Ви дійсно хочете вийти?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        static string ClassifyPosition(double d, double f)
        {
            if (d > 2 * f)
            {
                return "Предмет розташований за подвійним фокусом";
            }
            else if (d == 2 * f)
            {
                return "Предмет розташований у подвійному фокусі";
            }
            else if (d > f && d < 2 * f)
            {
                return "Предмет розташований між подвійним фокусом та фокусом";
            }
            else if (d == f)
            {
                return "Предмет розташований у фокусі";
            }
            else 
            {
                return "Предмет розташований перед фокусом";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}