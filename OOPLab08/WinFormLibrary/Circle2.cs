using System.Drawing;

namespace WinFormLibrary
{
    public class Circle2 : Circle1
    {
        protected int rr;
        public Circle2()
        {
            rr = rnd.Next(60);
        }
        public Circle2(int RR)
        {
            rr = RR;
        }
        public Circle2(int proz, Color color, Graphics graph, int X, int Y, int R, int RR) : base(proz, color, graph, X, Y, R)
        {
            rr = RR;
        }
        public Circle2(Circle2 obj)
        {
            rr = obj.rr;
        }
        public void Setrradius(int RR)
        {
            rr = RR;
        }
        public int Getrradius()
        {
            return rr;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 8);
            graph.DrawEllipse(pen, x, y, r, rr);
        }
    }
}
