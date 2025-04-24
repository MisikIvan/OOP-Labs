using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafficPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }
        void one()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen a = new Pen(Color.Blue, 1);
            Pen b = new Pen(Color.Green, 2);
            Font drawFont = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int sizeWidth = Form1.ActiveForm.Width;
            int sizeHeight = Form1.ActiveForm.Height;
            Point center = new Point(((int)(sizeWidth / 2) - 8), ((int)(sizeHeight / 2) -19));
            g.DrawLine(a, 10, center.Y, center.X, center.Y); // від'ємна вісь X
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y); // додатня вісь X
            g.DrawLine(a, center.X, 10, center.X, center.Y); // додатня вісь Y
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10); // від'ємна вісь Y
            g.DrawString("X", drawFont, drawBrush, new PointF(2 * center.X - 5, center.Y
           + 10), drawFormat); // вісь Х з позначкою
            g.DrawString("Y", drawFont, drawBrush, new PointF(center.X + 30, 5),
           drawFormat); // вісь Y з позначкою
            g.DrawString("0", drawFont, drawBrush, new PointF(center.X + 2, center.Y +
           1), drawFormat); // 0
            g.DrawLine(a, center.X, 10, center.X + 5, 20); // стрілка X+
            g.DrawLine(a, center.X, 10, center.X - 5, 20); // стрілка X-
            g.DrawLine(a, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y - 5);
            // стрілка Y+
            g.DrawLine(a, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y + 5);
            // стрілка Y-
            int stepForAxes = 25;
            int lengthShtrih = 3;
            int maxValueForAxesX = 20;
            int maxValueForAxesY = 20;
            float oneDelenieX = (float)maxValueForAxesX / ((float)center.X /
           stepForAxes); // позначки для Х
            float oneDelenieY = (float)maxValueForAxesY / ((float)center.Y /
           stepForAxes); // позначки для Y
            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -=
stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, i, center.Y - lengthShtrih, i, center.Y + lengthShtrih);
                g.DrawLine(a, j, center.Y - lengthShtrih, j, center.Y + lengthShtrih);
                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont,
                   drawBrush, new PointF(i + stepForAxes + 9, center.Y + 6), drawFormat);
                    g.DrawString((k * oneDelenieX).ToString("0.0").ToString() + "-",
                   signatureFont, drawBrush, new PointF(j - stepForAxes - 9, center.Y + 6), drawFormat);
                }
            }
            for (int i = center.Y, j = center.Y, k = 1; i < 2 * center.Y - 30; j -=
            stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, center.X - lengthShtrih, i, center.X + lengthShtrih, i);
                g.DrawLine(a, center.X - lengthShtrih, j, center.X + lengthShtrih, j);
                if (i < 2 * center.Y - 55)
                {
                    g.DrawString((k * oneDelenieY).ToString("0.0"), signatureFont,
                   drawBrush, new PointF(center.X - 5, j + stepForAxes - 56), drawFormat);
                    g.DrawString((k * oneDelenieY).ToString("0.0").ToString() + "-",
                   signatureFont, drawBrush, new PointF(center.X - 5, i + stepForAxes - 6), drawFormat);
                }
            }
            int numOfPoint = 100;
            float[] first = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX / (float)numOfPoint * (i + 1) -
               (float)(maxValueForAxesX / 2);
            }
            float[] second = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                second[i] = (float)(first[i] * Math.Sin(5 * first[i]));
            }
            Point[] pointOne = new Point[numOfPoint];
            float tempX = 1 / oneDelenieX * stepForAxes;
            float tempY = 1 / oneDelenieY * stepForAxes;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX);
                pointOne[i].Y = center.Y + (int)(second[i] * tempY);
                chart1.Series[0].Points.AddXY(pointOne[i].X, -pointOne[i].Y);
            }
            g.DrawLines(b, pointOne);
            g.DrawCurve(b, pointOne);
        }
    }
}
