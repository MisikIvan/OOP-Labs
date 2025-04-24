using System.Drawing;

namespace WinFormLibrary
{
    public class Point : Shape
    {
        protected int x;
        protected int y;
        protected int wh;
        public Point()
        {
            x = rnd.Next(250);
            y = rnd.Next(250);
            wh = rnd.Next(15);
        }
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public Point(int proz, Color color, Graphics graph, int X, int Y) : base(proz, color, graph)
        {
            x = X;
            y = Y;
        }
        public Point(Point obj)
        {
            x = obj.x;
            y = obj.y;
        }
        public void Setx(int X)
        {
                x = X;
        }
        public int Getx()
        {
            return x;
        }
        public void Sety(int Y)
        {
                y = Y;
        }
        public int Gety()
        {
            return y;
        }
        public void Setwh(int WH)
        {
            wh = WH;
        }
        public int Getwh()
        {
            return wh;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 8);
            graph.DrawEllipse(pen, x, y, wh, wh);
        }
    }
}
