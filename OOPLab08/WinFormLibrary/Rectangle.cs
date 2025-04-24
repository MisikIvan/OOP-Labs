using System.Drawing;

namespace WinFormLibrary
{
    public class Rectangle : Line
    {
        protected int Wid;
        protected int Heig;
        public Rectangle()
        {
            Wid = rnd.Next(75);
            Heig = rnd.Next(75);
        }
        public Rectangle(int wid, int heig)
        {
            Wid = wid;
            Heig = heig;
        }
        public Rectangle(int proz, Color color, Graphics graph, int X, int Y, int XX, int YY, int wid, int heig) : base(proz, color, graph, X, Y, XX, YY)
        {
            Wid = wid;
            Heig = heig;
        }
        public Rectangle(Rectangle obj)
        {
            Wid = obj.Wid;
            Heig = obj.Heig;
        }
        public void SetWid(int wid)
        {
            Wid = wid;
        }
        public int GetWid()
        {
            return Wid;
        }
        public void SetHeig(int heig)
        {
            Heig = heig;
        }
        public int GetHeig()
        {
            return Heig;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 8);
            graph.DrawRectangle(pen, xx, yy, Wid, Heig);
        }
    }
}
