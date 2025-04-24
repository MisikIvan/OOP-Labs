using System;
using System.Drawing;

namespace WinFormLibrary
{
    public abstract class Shape
    {
        protected Color color;
        protected int Proz;
        protected Graphics Graph;
        public static Random rnd = new Random();
        public Shape()
        {
            Proz = rnd.Next(256);
            color = Color.FromArgb(Proz, rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        public Shape(int proz)
        {
            Proz = proz;
        }
        public Shape(int proz, Color clr, Graphics graph)
        {
            Proz = proz;
            color = clr;
            Graph = graph;
        }
        public virtual void Draw(Graphics graph)
        {
        }
        public void SetColor(Color cl)
        {
            color = cl;
        }
        public Color GetNkvytok()
        {
            return color;
        }
        public void SetProz(int proz)
        {
            Proz = proz;
        }
        public int GetProz()
        {
            return Proz;
        }
        public Shape(Shape obj)
        {
            Proz = obj.Proz;
            color = obj.color;
            Graph = obj.Graph;
        }

    }
}
