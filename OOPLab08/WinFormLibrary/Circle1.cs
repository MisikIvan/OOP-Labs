using System.Drawing;

namespace WinFormLibrary
{
    public class Circle1 : Point
    {
        protected int r;
        public Circle1()
        {
            r = rnd.Next(60);
        }
        public Circle1(int R)
        {
            r = R;
        }
        public Circle1(int proz, Color color, Graphics graph, int X, int Y, int R) : base(proz, color, graph, X, Y)
        {
            r = R;
        }
        public Circle1(Circle1 obj)
        {
            r = obj.r;
        }
        public void Setradius(int R)
        {
            r = R;
        }
        public int Getradius()
        {
            return r;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 8);
            graph.DrawEllipse(pen, x, y, r, r);
        }
    }
}
