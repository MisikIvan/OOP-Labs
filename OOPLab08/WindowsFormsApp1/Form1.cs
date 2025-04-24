using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormLibrary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        protected Graphics Graph;
        protected Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void btdraw_Click(object sender, EventArgs e)
        {
            Graph = pictureBox1.CreateGraphics();
            Shape[] masiv = new Shape[20];
            for (int i = 0; i < masiv.Length; i++)
            {
                switch (rnd.Next(6))
                {
                    case 1:
                        masiv[i] = new WinFormLibrary.Point();
                        masiv[i].Draw(Graph);
                        break;
                    case 2:
                        masiv[i] = new Line();
                        masiv[i].Draw(Graph);
                        break;
                    case 3:
                        masiv[i] = new WinFormLibrary.Rectangle();
                        masiv[i].Draw(Graph);
                        break;
                    case 4:
                        masiv[i] = new Circle1();
                        masiv[i].Draw(Graph);
                        break;
                    case 5:
                        masiv[i] = new Circle2();
                        masiv[i].Draw(Graph);
                        break;
                }
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            Graph.Clear(DefaultBackColor);
        }
    }
}
