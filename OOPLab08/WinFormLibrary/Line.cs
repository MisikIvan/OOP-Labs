using System.Drawing;

namespace WinFormLibrary
{
    public class Line : Point
    {
        protected int xx;
        protected int yy;
        public Line()
        {
            xx = rnd.Next(250);
            yy = rnd.Next(250);
        }
        public Line(int proz, Color color, Graphics graph, int X, int Y, int XX, int YY) : base(proz, color, graph, X, Y)
        {
            xx = XX;
            yy = YY;
        }
        public Line(int XX, int YY)
        {

            xx = XX;
            yy = YY;
        }
        public Line(Line obj)
        {
            xx = obj.xx;
            yy = obj.yy;
        }
        public void Setxx(int XX)
        {
                xx = XX;
        }
        public int GetxX()
        {
            return xx;
        }
        public void Setyy(int YY)
        {
                yy = YY;
        }
        public int Getyy()
        {
            return yy;
        }
        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 8);
            graph.DrawLine(pen, x, y, xx, yy);
        }
    }
}
